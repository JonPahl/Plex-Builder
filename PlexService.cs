using Microsoft.Extensions.Hosting;
using PlexBuilder.Concrete;
using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PlexBuilder
{
    public class PlexService : IHostedService
    {
        private static PlexConfig config;

        private AllLibrariesService allLibraries;
        private PlexContext Context { get; }

        public PlexService(PlexContext context, AppSettings setting)
        {
            Context = context;
            var login = new PlexLogin(setting);
            var token = login.Login().Result;
            config = new PlexConfig
            {
                BaseUrl = setting.PlexServer,
                Token = token
            };
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Hello to the plex server api test app.{Environment.NewLine}");
            await Run().ConfigureAwait(false);
        }

        public async Task StopAsync(CancellationToken cancellationToken) 
            => await Task.Run(() => Console.Write("Stopped"), cancellationToken).ConfigureAwait(true);

        private async Task Run()
        {
            await FindAllLibraries().ConfigureAwait(true);
            await FindMovies().ConfigureAwait(true);
            //await FindTvShows().ConfigureAwait(true);
            return;
        }

        private async Task FindAllLibraries()
        {
            allLibraries = new AllLibrariesService(config, this.Context);
            await allLibraries.Execute().ConfigureAwait(true);

            Console.WriteLine(PlexBase<object>.BuildSeperator('-'));
            Console.WriteLine(Environment.NewLine);
        }

        private async Task FindMovies()
        {
            var movies = allLibraries.LibraryIds
                .Where(x => x.Key == "Movies")
                .OrderBy(x => x.Key).ToList();

            var MoviceService = new MoviesService(config, Context);
            await MoviceService.Execute(movies).ConfigureAwait(true);
        }

        private async Task FindTvShows()
        {
            var TvShows = allLibraries.LibraryIds
                .Where(x => x.Key == "TV Shows")
                .OrderBy(x => x.Key).ToList();

            var TvService = new TvShowService(config, new SqlModels.PlexContext());
            await TvService.Execute(TvShows).ConfigureAwait(true);
        }
    }
}
