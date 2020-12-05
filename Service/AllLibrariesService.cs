using PlexBuilder.Models;
using PlexBuilder.SqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Service
{
    public class AllLibrariesService : PlexBase<Libraries.MediaContainer>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        //public override Libraries.MediaContainer Libraries { get; set; }

        public AllLibrariesService(PlexContext context) : base(context)
        {
            //Libraries = new Libraries.MediaContainer;
            LibraryIds = new List<KeyValuePair<string, int>>();
        }

        public async Task Execute()
        {
            //var url = $"{PlexConfig.BaseUrl}library/sections?X-Plex-Token={PlexConfig.Token}";
            var uri = new Uri(PlexConfig.BaseUrl, $"library/sections?X-Plex-Token={PlexConfig.Token}");
            var results = GetLibaries<Libraries.MediaContainer>(uri);
            PrintResults(results);
        }

        public override T GetLibaries<T>(Uri uri) => (T)Convert.ChangeType(LoadPlex<T>(uri), typeof(T));

        public override void PrintResults<T>(T libraries)
        {
            var library = libraries as Libraries.MediaContainer;
            LibraryIds.AddRange(library.Directory.ToList().OrderBy(x => x.key)
                .Select(location => new KeyValuePair<string, int>(location.title, location.key)));

            foreach(var Libary in LibraryIds)
            {
                Console.WriteLine($"{Libary.Value} : {Libary.Key}");
            }
        }
    }
}
