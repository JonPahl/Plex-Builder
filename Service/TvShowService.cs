using PlexBuilder.Models.Tv;
using PlexBuilder.Service.Save;
using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Service
{
    public class TvShowService : PlexBase<SqlModels.TvShow>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public override List<SqlModels.TvShow> Libraries { get; set; }

        private int Id;
        private int start = 0;

        public TvShowService(PlexContext context) : base(context)
        {
            Libraries = new List<SqlModels.TvShow>();
        }

        public async Task Execute(List<KeyValuePair<string, int>> tvShows)
        {
            if (tvShows == null) throw new ArgumentException(" No Tv Shows provided. ");

            foreach (var id in tvShows)
            {
                Id = id.Value;
                try
                {
                    var details = await GetLibariesAsync<Models.Tv.TvShow.MediaContainer>(PlexConfig.BaseUrl)
                        .ConfigureAwait(true);

                    PrintResults(details);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }

            //SaveTvShows(TvShowsLibraries);

            #region Clean up
            var save = new SaveToFile(@"C:\Temp\TvShowFile.txt");
            foreach (var tvShow in Libraries)
            {
                try
                {
                    save.SaveRecord(tvShow);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            #endregion

            ProcessResults(Libraries);
        }

        public override async Task<T> GetLibariesAsync<T>(Uri uri)
        {
            var list = new List<Models.Tv.TvShow.MediaContainerDirectory>();
            var url = RequestUrl(Id, start, pageSize);

            var results = await LoadData<Models.Tv.TvShow.MediaContainer>(url, list).ConfigureAwait(true);
            var result = new Models.Tv.TvShow.MediaContainer { Directory = results.ToArray() };

            return (T)Convert.ChangeType(result, typeof(T));
        }

        private async Task<List<Models.Tv.TvShow.MediaContainerDirectory>> LoadData<T>(Uri uri, List<Models.Tv.TvShow.MediaContainerDirectory> list)
        {
            var xml = new Models.Tv.TvShow.MediaContainer();
            try
            {
                xml = LoadPlex<T>(uri) as Models.Tv.TvShow.MediaContainer;

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
                    //.TrimStart('/')
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
                var zzz = 0;
                throw new Exception($"Error with xml @ {uri} ", ex);
            }
        }

        private void ProcessResults(IEnumerable<SqlModels.TvShow> Shows)
        {
            Console.WriteLine(Utils.BuildSeperator('='));
            Console.WriteLine($"# Tv Shows Found: {Shows.GroupBy(x => x.Title).Count()}");
            Console.WriteLine(Utils.BuildSeperator('*'));
            foreach (var TvShow in Shows.GroupBy(x => x.Title))
            {
                Console.WriteLine(TvShow.Key);

                foreach (var info in TvShow)
                {
                    //Console.WriteLine($"{info.Title}\t\t{info.Year}");
                    Console.Write($"\t{info.Season}");
                    Console.WriteLine($"\t{info.Year}");
                    Console.WriteLine($"\t\tEpisode: {info.Episode}");
                    Console.WriteLine($"\t\t{info.EpisodeTitle}");
                    Console.WriteLine($"\t\t{info.File}");
                    Console.WriteLine($"\t\tIsAvailable: {info.IsAvailable}");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine(Utils.BuildSeperator('*'));
            Console.WriteLine();
        }
    }
}