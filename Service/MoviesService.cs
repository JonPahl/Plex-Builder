using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Movies = PlexBuilder.Models.Movie.Movies;

namespace PlexBuilder.Service
{
    public class MoviesService : PlexBase<SqlModels.Movies>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public override List<SqlModels.Movies> Library { get; set; }

        private int Id;
        private int start = 0;

        public MoviesService(PlexConfig config, PlexContext context) : base(config, context)
        {
            Library = new List<SqlModels.Movies>();
        }

        public async Task Execute(List<KeyValuePair<string, int>> movies)
        {
            if (movies == null) throw new ArgumentException(" No Movies provided. ");

            foreach (var id in movies)
            {
                Id = id.Value;
                try
                {
                    Console.WriteLine(Environment.NewLine + BuildSeperator('-') + Environment.NewLine);

                    var details = await GetLibaries<List<Movies.MediaContainer>>(new Uri(config.BaseUrl))
                        .ConfigureAwait(false);

                    PrintResults(details);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }

            #region Test
            //var save = new SaveToFile(@"C:\Temp\MoviesFile.txt");
            //foreach (var movie in Library){
            //    try{save.SaveRecord(movie);}catch (Exception ex){Console.WriteLine(ex.Message);}
            //    using var saveMovie = new SaveMoviesToDb();saveMovie.SaveRecord(movie); saveMovie.Save();}
            #endregion
            //using(var saveMovie=new SaveMoviesToDb()){foreach(var movie in MovieLibraries){saveMovie.SaveRecord(movie);}saveMovie.Save();}
            //ProcessResults(Library);
        }

        public override async Task<T> GetLibaries<T>(Uri uri)
        {
            var list = new List<Movies.MediaContainer>();

            var Uri = RequestUrl(Id, start, pageSize);
            var results = await LoadData<Movies.MediaContainer>(Uri, list).ConfigureAwait(true);
            return (T)Convert.ChangeType(results, typeof(T));
        }

        private async Task<List<Movies.MediaContainer>> LoadData<T>(Uri uri, List<Movies.MediaContainer> list)
        {
            try
            {
                var xml = LoadPlex<Movies.MediaContainer>(uri);

                if (xml.totalSize <= Convert.ToUInt64(start))
                {
                    list.Add(xml);
                }
                else
                {
                    start += pageSize;
                    var Uri = RequestUrl(Id, start, pageSize);
                    return await LoadData<T>(Uri, list).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(uri);
            }

            return list;
        }

        public override TOutput LoadPlex<TOutput>(Uri uri)
        {
            var reader = new XmlTextReader(uri.ToString());
            var serializer = new XmlSerializer(typeof(Movies.MediaContainer));
            var envelope = serializer.Deserialize(reader) as Movies.MediaContainer;
            return (TOutput)Convert.ChangeType(envelope, typeof(Movies.MediaContainer));
        }

        public override void PrintResults<T>(T libraries)
        {
            if (!(libraries is List<Movies.MediaContainer> details))
                throw new InvalidCastException("Libraries is of wrong type");

            foreach (var item in details)
            {
                var media = item.Video.Media;

                var file = media.Part.file;

                var movie = new SqlModels.Movies
                {
                    Title = item.Video.title,
                    Year = item.Video.year,
                    File = file,
                    IsAvailable = FileExists(file),
                    LastUpdated = DateTime.Now,
                };

                foreach(var prop in movie.GetType().GetProperties().ToList())
                {
                    Console.WriteLine($"{prop.Name} ::{prop.GetValue(movie)}");
                }

                Library.Add(movie);
            }
        }

        /*private void ProcessResults(IEnumerable<SqlModels.Movies> Movies)
        {
            Console.WriteLine(BuildSeperator('='));
            Console.WriteLine($"# Movies Found: {Movies.GroupBy(x => x.Title).Count()}");
            Console.WriteLine(BuildSeperator('*'));
            foreach (var movie in Movies)
            {
                Console.WriteLine($"{movie.Title}\t{movie.Year}");
            }
            Console.WriteLine(BuildSeperator('*'));
        }*/
    }
}