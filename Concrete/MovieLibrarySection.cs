/*
using PlexBuilder.Abstract;
using PlexBuilder.Models;
using PlexBuilder.Models.Movies;
using PlexBuilder.Models.Tv;
using PlexBuilder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PlexBuilder.Concrete
{
    public class MovieLibrarySection : APIClient
    {
        protected override string Endpoint => throw new NotImplementedException();
        public override List<KeyValuePair<string, int>> LibraryIds { get; }

        public List<Information> MovieLibraries;

        protected int start = 0;
        protected int pageSize = 1;
        //protected Uri Uri;

        public int Id;

        public MovieLibrarySection(PlexConfig config) : base(config)
        {
            MovieLibraries = new List<Information>();
        }

        public void SetId(int id)
        {
            this.Id = id;
        }


        public override async Task<T> GetLibaries<T>(Uri uri)
        {                       
            var list = new List<Movies.MediaContainerVideo>();
            var Uri = RequestUrl();
            var results = await LoadData<Movies.MediaContainer>(Uri, list).ConfigureAwait(true);
            var result = new Movies.MediaContainer { Video = results.ToArray() };

            return (T)Convert.ChangeType(result, typeof(T));
        }

        private Uri RequestUrl()
        {
            var url = $"{_config.BaseUrl}/library/sections/{Id}/all?X-Plex-Token={_config.Token}";
            url += $"&X-Plex-Container-Start={start}&X-Plex-Container-Size={pageSize}";

            return new Uri(url);
        }

        private async Task<List<Movies.MediaContainerVideo>> LoadData<T>(Uri uri, List<Movies.MediaContainerVideo> list)
        {
            //Console.WriteLine(uri.ToString());

            Movies.MediaContainer xml = new Movies.MediaContainer();
            try
            {
                var xmlInputData = (PlexBase.LoadPlex<T>(uri));
                xml = xmlInputData as Movies.MediaContainer;
                
                if (xml.Video != null && xml.Video.Any())
                    list.AddRange(xml.Video.ToList().Select(video => video));
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(uri);
                //todo: copy error and url to list for future debugging.
            }

            if (xml.totalSize != Convert.ToUInt64(start))
            {
                start += pageSize;
                var Uri = RequestUrl();                
                return await LoadData<T>(Uri, list).ConfigureAwait(true);
            }
            else
            {
                return list;
            }
        }

        public override void PrintResults<T>(T libraries)
        {
            var details = libraries as Movies.MediaContainer;
            if (details == null) throw new InvalidCastException("Libaries is of wrong type");
            #region Test

            if (details.Video != null && details.Video.Any())
            {
                foreach (var video in details.Video.ToList())
                {
                    var information = new Information
                    {
                        Name = video.title,
                        Year = video.year,
                        //episode = episode.index,
                        //episodeTitle = video.title,
                        //season = detail.title
                    };

                    MovieLibraries.Add(information);

                    /*
                    Console.Write($"{video.year} | ");

                    if (video.Genre != null)
                    {
                        var tags = LoadGenre(video.Genre.ToList());
                        Console.Write(tags + " | ");
                    }
                    Console.Write($"\t {video.title} |");

                    foreach (var media in video.Media.ToList())
                    {
                        Console.Write($"\t{media.Part.file} |");
                    }
                    Console.WriteLine(Environment.NewLine);
                    *
                }
                Console.WriteLine($"# Videos Found: {details.Video.Count()}");
            }
        }

        #endregion


        private static string LoadGenre(List<Movies.MediaContainerVideoGenre> Genres)
        {
            var results = "";

            foreach (var genre in Genres)
            {
                results += $" {genre.tag}, ";
            }
            return results;
        }

    }
}
*/