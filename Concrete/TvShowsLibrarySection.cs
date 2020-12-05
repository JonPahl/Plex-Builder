/*
using PlexBuilder.Abstract;
using PlexBuilder.Models;
using PlexBuilder.Models.Tv;
using PlexBuilder.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Concrete
{
    public class TvShowsLibrarySection : APIClient
    {
        public List<Information> TvShowLibraries = new List<Information>();
        protected override string Endpoint => throw new NotImplementedException();

        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public int Id { get => id; set => id = value; }

        protected int start = 0;
        protected int pageSize = 1;

        private int id;

        public TvShowsLibrarySection(PlexConfig config) : base(config)
        {            
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public override async Task<T> GetLibaries<T>(Uri uri)
        {
            var url = RequestUrl();
            var xmlInputData = PlexBase.LoadPlex<T>(url);            
            return (T)Convert.ChangeType(xmlInputData, typeof(T));
        }

        private Uri RequestUrl()
        {
            var url = $"{_config.BaseUrl}/library/sections/{Id}/all?X-Plex-Token={_config.Token}";            
            return new Uri(url);
        }

        private async Task<List<TvShows.MediaContainerDirectory>> LoadData<T>(Uri uri, List<TvShows.MediaContainerDirectory> list)
        {
            TvShows.MediaContainer xml = new TvShows.MediaContainer();
            try
            {
                var xmlInputData = PlexBase.LoadPlex<T>(uri);
                xml = xmlInputData as TvShows.MediaContainer;
                //document.LoadXml(xmlInputData);
                //xml = (ConvertXmlDocument<T>(document)) as TvShows.MediaContainer;
                if (xml == null)
                {
                    Console.WriteLine("xml is null");
                }
                else
                {
                    if (xml.Directory != null && xml.Directory.Any())
                        list.AddRange(xml.Directory.ToList().Select(video => video));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(uri);
                //todo: copy error and url to list for future debugging.
            }
            return list;
        }

        public override void PrintResults<T>(T libraries)
        {
            var details = libraries as TvShows.MediaContainer;

            #region Test

            if (details.Directory.Any())
            {
                foreach (var video in details.Directory.ToList())
                {
                    try
                    {
                        var tvShowDetails = Task.Run(() => LoadTvShow<TvShow.MediaContainer>(video.key)).Result;

                        foreach (var detail in tvShowDetails.Directory.ToList().Where(x => x.index > 0))
                        {
                            var seasonEpisodes = Task.Run(() => LoadEpisodes<Episode.MediaContainer>(detail.key)).Result;

                            foreach (var episode in seasonEpisodes.Video.ToList())
                            {
                                try
                                {
                                    var information = new Information
                                    {
                                        Name = video.title,
                                        Year = episode.year,
                                        Episode = episode.index,
                                        EpisodeTitle = episode.title,
                                        Season = detail.title   
                                        , File = episode.Media.Part.file
                                        //, IsAvailable = 
                                    };

                                    TvShowLibraries.Add(information);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error processing xml. Episode");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {                        
                        Console.WriteLine("Error processing xml. Seasons");
                    }
                }
            }

            #endregion
        }

        private async Task<T> LoadTvShow<T>(string media)
        {
            var url = $"{_config.BaseUrl}{media}?X-Plex-Token={_config.Token}";            
            var xmlInputData = (PlexBase.LoadPlex<T>(new Uri(url)));            
            return (T)Convert.ChangeType(xmlInputData, typeof(T));
        }

        private async Task<T> LoadEpisodes<T>(string media)
        {
            var url = $"{_config.BaseUrl}{media}?X-Plex-Token={_config.Token}";            
            var xmlInputData = PlexBase.LoadPlex<T>(new Uri(url));            
            return (T)Convert.ChangeType(xmlInputData, typeof(T));
        }
    }
}
*/