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
        public override List<Libraries.MediaContainer> Libraries { get; }

        public AllLibrariesService(PlexContext context) : base(context)
        {
            Libraries = new List<Libraries.MediaContainer>();
            LibraryIds = new List<KeyValuePair<string, int>>();
        }
        public async Task Execute()
        {
            var uri = new Uri(PlexConfig.BaseUrl, $"library/sections?X-Plex-Token={PlexConfig.Token}");
            var results = await Task.Run(() => GetLibaries<Libraries.MediaContainer>(uri)).ConfigureAwait(false);
            //var results = GetLibaries<Libraries.MediaContainer>(uri);
            PrintResults(results);
        }

        public override T GetLibaries<T>(Uri uri) => (T)Convert.ChangeType(LoadPlex<T>(uri), typeof(T));

        public override void PrintResults<T>(T libraries)
        {
            var item = libraries as Libraries.MediaContainer;
            //var x = new List<Libraries.MediaContainer>();
            Libraries.Add(item);

            LibraryIds.AddRange(Libraries.FirstOrDefault()?.Directory.ToList().OrderBy(x => x.key)
                .Select(location => new KeyValuePair<string, int>(location.title, location.key)));
        }
    }
}
