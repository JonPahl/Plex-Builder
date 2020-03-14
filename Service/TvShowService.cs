using PlexBuilder.Models.Tv;
using PlexBuilder.Service.Save;
using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Service
{
    public class TvShowService : PlexBase
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public List<SqlModels.TvShow> TvShowsLibraries { get; set; }

        private int Id;
        private int start = 0;
        private int pageSize = 1;
        PlexContext context;

        public TvShowService(PlexConfig config, PlexContext context) : base(config)
        {
            TvShowsLibraries = new List<SqlModels.TvShow>();
            this.context = context;
        }

        public async Task Execute(List<KeyValuePair<string, int>> tvShows)
        {
            if (tvShows == null) throw new ArgumentException(" No Tv Shows provided. ");

            foreach (var id in tvShows)
            {
                Id = id.Value;
                try
                {
                    var details = await GetLibaries<Models.Tv.TvShow.MediaContainer>(new Uri(config.BaseUrl))
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



            var save = new SaveToFile(@"C:\Temp\TvShowFile.txt");
            foreach (var tvShow in TvShowsLibraries)
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


            /*
             //todo: uncomment the following to save database instead of file.
            var saveTvShows = new SaveTvShowToDb();
            foreach (var tvShow in TvShowsLibraries)
            {
                try
                {
                    saveTvShows.SaveRecord(tvShow);
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    saveTvShows.Save();
                }
            }
            saveTvShows.Save();
            */


            ProcessResults(TvShowsLibraries);
        }

        public override async Task<T> GetLibaries<T>(Uri uri)
        {
            var list = new List<Models.Tv.TvShow.MediaContainerDirectory>();
            var url = RequestUrl(Id, start, pageSize);

            var results = await LoadData<Models.Tv.TvShow.MediaContainer>(url, list).ConfigureAwait(true);
            var result = new Models.Tv.TvShow.MediaContainer { Directory = results.ToArray() };

            return (T)Convert.ChangeType(result, typeof(T));
        }


        private async Task<List<Models.Tv.TvShow.MediaContainerDirectory>> LoadData<T>(Uri uri, List<Models.Tv.TvShow.MediaContainerDirectory> list)
        {
            Models.Tv.TvShow.MediaContainer xml = new Models.Tv.TvShow.MediaContainer();
            try
            {
                xml = LoadPlex<T>(uri) as Models.Tv.TvShow.MediaContainer;

                if (xml.Directory != null && xml.Directory.Any())
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
        /// 
        /// * todo: break into 2 sub-methods.
        /// * 1. Load Seasons list, this returns a directory of 0-n season.
        /// * 2. Key from season is then feed into episode method.
        /// * 2a.Once an episodes xml->object is complted the object is returned.
        /// * 3. Process season & episodes into DBobject to insert into the database.             
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="libraries"></param>
        public override void PrintResults<T>(T libraries)
        {
            var TvShows = libraries as Models.Tv.TvShow.MediaContainer;

            if (TvShows.Directory.Any())
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
                                IsAvailable = FileExists(episode.Media.Part.file),
                                LastUpdated = DateTime.Now
                            };

                            TvShowsLibraries.Add(show);
                        }
                    }
                }
            }
        }

        private T LoadMedia<T>(string media)
        {
            var url = $"{config.BaseUrl}{media}?X-Plex-Token={config.Token}";
            try
            {
                var xmlInputData = (LoadPlex<T>(new Uri(url)));
                return xmlInputData;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error with xml @{url}", ex);
            }
        }


        private void ProcessResults(IEnumerable<SqlModels.TvShow> Shows)
        {
            Console.WriteLine(BuildSeperator('='));
            Console.WriteLine($"# Tv Shows Found: {Shows.GroupBy(x => x.Title).Count()}");
            Console.WriteLine(BuildSeperator('*'));
            foreach (var TvShow in Shows.GroupBy(x => x.Title))
            {
                foreach (var info in TvShow)
                {
                    Console.WriteLine($"{info.Title}\t\t{info.Year}");
                    Console.WriteLine($"\t{info.Season}");
                    Console.WriteLine($"\t\tEpisode: {info.Episode}");
                    Console.WriteLine($"\t\t{info.EpisodeTitle}");
                    Console.WriteLine($"\t\t{info.File}");
                    Console.WriteLine($"\t\tIsAvailable: {info.IsAvailable}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine(BuildSeperator('*'));
            Console.WriteLine();
        }
    }
}