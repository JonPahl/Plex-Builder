using PlexBuilder.Models.Movies;
using PlexBuilder.Service.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Service
{
    public class MoviesService : PlexBase<SqlModels.Movies>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public override List<SqlModels.Movies> Library { get; set; }

        private int Id;
        private int start = 0;
        private int pageSize = 1;

        public MoviesService(PlexConfig config) : base(config)
        {
            Library = new List<SqlModels.Movies>();            
        }

        public async Task Execute(List<KeyValuePair<string, int>> movies)
        {
            if (movies == null) throw new ArgumentException(" No Movies provided. ");

            foreach (var id in movies)
            {
                Id = id.Value;
                //movieSection.SetId(id.Value);
                try
                {
                    Console.WriteLine($"{Environment.NewLine}{BuildSeperator('-')}{Environment.NewLine}");

                    var details = await GetLibaries<Movies.MediaContainer>(new Uri(config.BaseUrl))
                        .ConfigureAwait(true);

                    PrintResults(details);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }


            var save = new SaveToFile(@"C:\Temp\TestFile.txt");
            foreach (var movie in Library)
            {
                try
                {  
                    save.SaveRecord(movie);                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                /*
                using var saveMovie = new SaveMoviesToDb();
                saveMovie.SaveRecord(movie);
                saveMovie.Save();
                */
            }

            //using(var saveMovie=new SaveMoviesToDb()){foreach(var movie in MovieLibraries){saveMovie.SaveRecord(movie);}saveMovie.Save();}
            ProcessResults(Library);
        }

        public override async Task<T> GetLibaries<T>(Uri uri)
        {
            var list = new List<Movies.MediaContainerVideo>();

            var Uri = RequestUrl(Id, start, pageSize);
            var results = await LoadData<Movies.MediaContainer>(Uri, list).ConfigureAwait(true);
            var result = new Movies.MediaContainer { Video = results.ToArray() };

            return (T)Convert.ChangeType(result, typeof(T));
        }



        private async Task<List<Movies.MediaContainerVideo>> LoadData<T>(Uri uri, List<Movies.MediaContainerVideo> list)
        {
            Movies.MediaContainer xml = new Movies.MediaContainer();
            try
            {
                xml = (LoadPlex<T>(uri)) as Movies.MediaContainer;

                if (xml.Video != null && xml.Video.Any())
                    list.AddRange(xml.Video.ToList().Select(video => video));

                if (xml.totalSize <= Convert.ToUInt64(start))
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
                //todo: copy error and url to list for future debugging.

                if (xml.totalSize <= Convert.ToUInt64(start))
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
        }


        public override void PrintResults<T>(T libraries)
        {
            var details = libraries as Movies.MediaContainer;
            if (details == null) throw new InvalidCastException("Libaries is of wrong type");

            if (details.Video != null && details.Video.Any())
            {
                foreach (var video in details.Video.ToList())
                {
                    foreach (var media in video.Media.ToList())
                    {
                        var file = media.Part.file;

                        var movie = new SqlModels.Movies
                        {
                            Title = video.title,
                            Year = video.year,
                            File = file,
                            IsAvailable = FileExists(file),
                            LastUpdated = DateTime.Now,
                        };

                        Library.Add(movie);
                    }
                }
            }
        }
               
        private void ProcessResults(IEnumerable<SqlModels.Movies> Movies)
        {
            Console.WriteLine(BuildSeperator('='));
            Console.WriteLine($"# Movies Found: {Movies.GroupBy(x => x.Title).Count()}");
            Console.WriteLine(BuildSeperator('*'));
            foreach (var movie in Movies)
            {
                Console.WriteLine($"{movie.Title}\t{movie.Year}");
            }
            Console.WriteLine(BuildSeperator('*'));
        }

    }
}