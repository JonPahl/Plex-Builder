using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlexBuilder.Service
{
    public abstract class PlexBase<T>
    {
        public abstract List<KeyValuePair<string, int>> LibraryIds { get; }
        public virtual List<T> Libraries { get; set; }
        protected readonly int pageSize = 1;
        protected PlexContext Context { get; set; }

        protected PlexBase(PlexContext context)
        {
            Context = context;
        }

        protected Uri RequestUrl(int Id, int start, int pageSize = 1)
        {
            var pathBuilder = new StringBuilder();
            pathBuilder.Append("library/sections/").Append(Id).Append("/all");

            var queryBuilder = new StringBuilder();
            queryBuilder.Append('?').Append("X-Plex-Token=").Append(PlexConfig.Token);
            queryBuilder.Append("&X-Plex-Container-Start=").Append(start).Append("&X-Plex-Container-Size=")
                .Append(pageSize);

            var urlBuilder=new UriBuilder(PlexConfig.BaseUrl){Path=pathBuilder.ToString(),Query=queryBuilder.ToString()};
            return urlBuilder.Uri;
        }

        public virtual TOutput LoadPlex<TOutput>(Uri uri)
        {
            using var reader = new XmlTextReader(uri.ToString());
            var serializer = new XmlSerializer(typeof(TOutput));
            var envelope = (TOutput)serializer.Deserialize(reader);
            return (TOutput) Convert.ChangeType(envelope, typeof(TOutput));
        }

        public virtual Task<TOutput> GetLibariesAsync<TOutput>(Uri uri) { throw new NotImplementedException(""); }
        public virtual TOutput GetLibaries<TOutput>(Uri url) { throw new NotImplementedException(""); }
        public abstract void PrintResults<TInput>(TInput libraries);
    }
}
