using PlexBuilder.Models.Tv;
using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TvShow = PlexBuilder.Models.Tv.TvShow;

namespace PlexBuilder.Service
{
    public class TvShowService : PlexBase<SqlModels.TvShow>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public override List<SqlModels.TvShow> Libraries { get; }

        private int Id;
        private int start;

        public TvShowService(PlexContext context) : base(context)
        {
            start = 0;
            Libraries = new List<SqlModels.TvShow>();
        }

        public async Task Execute(List<KeyValuePair<string, int>> tvShows)
        {
            if (tvShows == null) throw new ArgumentException(" No TV Shows provided. ");

            var details = await GetLibariesAsync<TvShow.MediaContainer>(PlexConfig.BaseUrl).ConfigureAwait(true);
            PrintResults(details);
        }

        public override async Task<T> GetLibariesAsync<T>(Uri uri)
        {
            var list = new List<TvShow.MediaContainerDirectory>();
            var url = RequestUrl(Id, start, pageSize);

            var results = await LoadData<TvShow.MediaContainer>(url, list).ConfigureAwait(true);
            var result = new TvShow.MediaContainer { Directory = results.ToArray() };
            return (T)Convert.ChangeType(result, typeof(T));
        }

        private async Task<List<TvShow.MediaContainerDirectory>> LoadData<T>(Uri uri, List<TvShow.MediaContainerDirectory> list)
        {
            var xml = new TvShow.MediaContainer();
            try
            {
                xml = LoadPlex<T>(uri) as TvShow.MediaContainer;

                if (xml?.Directory != null && xml.Directory.Length > 0)
                    list.AddRange(xml.Directory.ToList().Select(video => video));

                if (xml.totalSize == Convert.ToInt64(start))
                {
                    return list;
                }
                else
                {
                    start += pageSize;
                    var Uri = RequestUrl(Id, start, pageSize);
                    return await LoadData<T>(Uri, list).ConfigureAwait(true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(uri);

                start += pageSize;
                var Uri = RequestUrl(Id, start, pageSize);
                return await LoadData<T>(Uri, list).ConfigureAwait(true);
            }
        }

        /// <summary>
        /// * todo: break into 2 sub-methods.
        /// * 1. Load Seasons list, this returns a directory of 0-n season.
        /// * 2. Key from season is then feed into episode method.
        /// * 2a.Once an episodes xml->object is completed the object is returned.
        /// * 3. Process season & episodes into DBobject to insert into the database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="libraries"></param>
        public override void PrintResults<T>(T libraries)
        {
            var TvShows = libraries as Models.Tv.TvShow.MediaContainer;

            if (TvShows.Directory.Length > 0)
            {
                foreach (var tvShow in TvShows.Directory.ToList())
                {
                    var seasons = LoadMedia<Season.MediaContainer>(tvShow.key);

                    foreach (var season in seasons.Directory.Where(x => x.index > 0))
                    {
                        var seasonEpisodes = LoadMedia<Episode.MediaContainer>(season.key);

                        foreach (var episode in seasonEpisodes.Video.Where(x => x.index > 0))
                        {
                            var show = new SqlModels.TvShow
                            {
                                Title = tvShow.title,
                                Year = tvShow.year,
                                Season = season.title,
                                Episode = episode.index,
                                EpisodeTitle = episode.title,
                                File = episode.Media.Part.file,
                                IsAvailable = Utils.FileExists(episode.Media.Part.file),
                                LastUpdated = DateTime.Now
                            };

                            Libraries.Add(show);
                        }
                    }
                }
            }
        }

        private T LoadMedia<T>(string media)
        {
            var uri = new Uri(PlexConfig.BaseUrl, $"{media}?X-Plex-Token={PlexConfig.Token}");

            try
            {
                return LoadPlex<T>(uri);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error with xml @ {uri} ", ex);
            }
        }
    }
}