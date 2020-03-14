/*
using PlexBuilder.Abstract;
using PlexBuilder.Models;
using PlexBuilder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Concrete
{
    class LibraryAllSections : APIClient
    {
        protected override string Endpoint => "/library/sections";

        public override List<KeyValuePair<string, int>> LibraryIds { get; }

        private PlexConfig config;
        //private readonly XmlDocument document;

        public LibraryAllSections(PlexConfig config) : base(config)
        {
            this.config = config;
            LibraryIds = new List<KeyValuePair<string, int>>();
        }


        public override async Task<T> GetLibaries<T>(Uri uri)
        {
            var xmlInputData = PlexBase.LoadPlex<T>(uri);
            return (T)Convert.ChangeType(xmlInputData, typeof(T));
        }

        public override void PrintResults<T>(T libraries)
        {
            var library = libraries as Libraries.MediaContainer;
            LibraryIds
                .AddRange(library.Directory.ToList().OrderBy(x => x.key)
                .Select(location => new KeyValuePair<string, int>(location.title, location.key)));
        }

    }
}


*/