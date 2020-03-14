using PlexBuilder.Models;
using PlexBuilder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexBuilder.Service
{
    public class AllLibrariesService : PlexBase<Libraries.MediaContainer>
    {
        public override List<KeyValuePair<string, int>> LibraryIds { get; }
        public override List<Libraries.MediaContainer> Library { get; set; }

        public AllLibrariesService(PlexConfig config) : base(config)
        {
            Library = new List<Libraries.MediaContainer>();
            LibraryIds = new List<KeyValuePair<string, int>>();            
        }

        public async Task Execute()
        {
            var url = $"{config.BaseUrl}/library/sections?X-Plex-Token={config.Token}";
            var results = await GetLibaries<Libraries.MediaContainer>(new Uri(url)).ConfigureAwait(true);
            PrintResults(results);
        }

        public override async Task<T> GetLibaries<T>(Uri uri)
        {
            var xmlInputData = LoadPlex<T>(uri);
            return (T)Convert.ChangeType(xmlInputData, typeof(T));
        }

        public override void PrintResults<T>(T libraries)
        {
            var library = libraries as Libraries.MediaContainer;
            
            //foreach(var location in library.Directory) {
            //    var item = new KeyValuePair<string, int>(location.title, location.key);
            //    LibraryIds.Add(item);
            //    LibraryIds.AddRange(from loc in location.Location.ToList()
            // select new KeyValuePair<string, int>(location.title, loc.id)); }
            
            LibraryIds
                .AddRange(library.Directory.ToList().OrderBy(x => x.key)
                .Select(location => new KeyValuePair<string, int>(location.title, location.key)));
        }
    }
}
