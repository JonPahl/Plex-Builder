using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlexBuilder.Service
{
    public abstract class PlexBase
    {
        protected PlexConfig config;
        public abstract List<KeyValuePair<string, int>> LibraryIds { get; }

        public PlexBase(PlexConfig config)
        {
            this.config = config;
        }

        public static string BuildSeperator(char item, int cnt = 20) => new string(item, cnt);

        protected  Uri RequestUrl(int Id, int start, int pageSize)
        {
            var url = $"{config.BaseUrl}/library/sections/{Id}/all?X-Plex-Token={config.Token}";
            url += $"&X-Plex-Container-Start={start}&X-Plex-Container-Size={pageSize}";
            return new Uri(url); //Console.WriteLine(url);
        }

        public static bool FileExists(string path)
        {
            try
            {
                var exits = File.Exists(Path.GetFullPath(path.Trim()));
                return exits;                
            } catch (Exception)
            {
                return false;
            }
        }


        public static T LoadPlex<T>(Uri uri)
        {
            using XmlTextReader reader = new XmlTextReader(uri.AbsoluteUri);
            var serializer = new XmlSerializer(typeof(T));
            var library = (T)serializer.Deserialize(reader);

            return library;
        }

        public abstract Task<T> GetLibaries<T>(Uri uri);
        public abstract void PrintResults<T>(T libraries);

    }
}
