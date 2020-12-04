using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlexBuilder.Service
{
    public abstract class PlexBase<T>
    {
        protected PlexConfig config;
        public abstract List<KeyValuePair<string, int>> LibraryIds { get; }
        public virtual List<T> Libraries { get; set; }

        protected readonly int pageSize = 1;
        protected readonly PlexContext context;

        protected PlexBase(PlexConfig config, PlexContext context)
        {
            this.config = config;
            this.context = context;
        }

        public static string BuildSeperator(char item, int cnt = 20) => new string(item, cnt);

        protected Uri RequestUrl(int Id, int start, int pageSize)
        {
            var url = $"{config.BaseUrl}/library/sections/{Id}/all?X-Plex-Token={config.Token}";
            url += $"&X-Plex-Container-Start={start}&X-Plex-Container-Size={pageSize}";
            return new Uri(url);
        }

        public virtual TOutput LoadPlex<TOutput>(Uri uri)
        {
            using var reader = new XmlTextReader(uri.ToString());
            var serializer = new XmlSerializer(typeof(TOutput));
            var envelope = (TOutput)serializer.Deserialize(reader);
            return (TOutput)Convert.ChangeType(envelope, typeof(TOutput));
        }

        public static bool FileExists(string path) => File.Exists(Path.GetFullPath(path?.Trim()));

        public virtual Task<TOutput> GetLibariesAsync<TOutput>(Uri uri) { throw new NotImplementedException(""); }
        public virtual TOutput GetLibaries<TOutput>(Uri url) { throw new NotImplementedException(""); }
        public abstract void PrintResults<TInput>(TInput libraries);
    }
}
