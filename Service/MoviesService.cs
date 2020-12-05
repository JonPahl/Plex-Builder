using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Movies = PlexBuilder.Models.Movie.Movies;

namespace PlexBuilder.Service
{
    public class MoviesService : PlexBase<SqlModels.Movies>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public override List<SqlModels.Movies> Libraries { get; set; }

        private int Id;
        private int start;

        public MoviesService(PlexContext context) : base(context)
        {
            start = 0;
            Libraries = new List<SqlModels.Movies>();
        }
        public async Task Execute(List<KeyValuePair<string, int>> movies)
        {
            if (movies == null) throw new ArgumentException(" No Movies provided. ");

            foreach (var id in movies)
            {
                Id = id.Value;
                try
                {
                    Console.WriteLine(Environment.NewLine + Utils.BuildSeperator('-') + Environment.NewLine);
                    var details = await GetLibariesAsync<List<Movies.MediaContainer>>(PlexConfig.BaseUrl)
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
        public override async Task<TOutput> GetLibariesAsync<TOutput>(Uri uri)
        {
            var Uri = RequestUrl(Id, start, pageSize);
            var list = new List<Movies.MediaContainer>();
            var results = await LoadData<Movies.MediaContainer>(Uri, list).ConfigureAwait(true);
            return (TOutput)Convert.ChangeType(results, typeof(TOutput));
        }

        private async Task<List<Movies.MediaContainer>> LoadData<T>(Uri uri, List<Movies.MediaContainer> list)
        {
            try
            {
                var xml = LoadPlex<Movies.MediaContainer>(uri);
                list.Add(xml);

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
                Console.WriteLine(Environment.NewLine);
            }

            return await Task.Run(() => list).ConfigureAwait(false);
        }

        public override TOutput LoadPlex<TOutput>(Uri uri)
        {
            using var reader = new XmlTextReader(uri.ToString());
            var serializer = new XmlSerializer(typeof(Movies.MediaContainer));
            var envelope = serializer.Deserialize(reader) as Movies.MediaContainer;
            return (TOutput)Convert.ChangeType(envelope, typeof(Movies.MediaContainer));
        }

        public override void PrintResults<T>(T libraries)
        {
            if (libraries is not List<Movies.MediaContainer> details)
                throw new InvalidCastException("Libraries is of wrong type");

            var cnt = 1;
            foreach (var detail in details)
            {
                if (detail.Video != null)
                {
                    var media = detail.Video.Media;
                    var file = media.Part.file;
                    var movie = new SqlModels.Movies
                    {
                        Title = detail.Video.title,
                        Year = detail.Video.year,
                        File = file,
                        IsAvailable = Utils.FileExists(file),
                        LastUpdated = DateTime.Now,
                    };

                    //Console.WriteLine($"{cnt}:\t\t {movie}" );
                    Libraries.Add(movie);
                    cnt++;
                }
            }
        }
    }
}