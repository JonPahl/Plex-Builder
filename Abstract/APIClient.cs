//using PlexBuilder.Models;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Serialization;

//namespace PlexBuilder.Abstract
//{
//    public abstract class APIClient
//    {
//        /// <summary>
//        /// Always start with a leading forward slash and end with a ?
//        /// </summary>
//        protected abstract string Endpoint { get; }
//        public abstract List<KeyValuePair<string, int>> LibraryIds { get; }
//        protected PlexConfig _config;

//        protected APIClient(PlexConfig config)
//        {
//            _config = config;            
//        }
//        public abstract Task<T> GetLibaries<T>(Uri uri);
//        public abstract void PrintResults<T>(T libraries);
//    }
//}