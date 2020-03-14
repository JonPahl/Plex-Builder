using Microsoft.Extensions.Hosting;
using PlexBuilder.Concrete;
using PlexBuilder.Service;
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

        public PlexService()
        {
            var username = "-- Plex Username --";
            var pwd = "-- Plex Password --";

            var login = new PlexLogin(username, pwd);
            var token = login.Login().Result;
            config = new PlexConfig
            {
                BaseUrl = "http://127.0.0.1:32400",
                Token = token
            };
        }


        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($@"Hello to the plex server api test app.{Environment.NewLine}");
            await Run().ConfigureAwait(false);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.Run(() => Console.Write("Stopped"))
                .ConfigureAwait(true); ;            
        }

        private async Task Run()
        {
            await FindAllLibraries().ConfigureAwait(true);
            await FindMovies().ConfigureAwait(true);
            await FindTvShows().ConfigureAwait(true);
            return;
        }

        private async Task FindAllLibraries()
        {
            allLibraries = new AllLibrariesService(config);
            await allLibraries.Execute().ConfigureAwait(true);

            Console.WriteLine(PlexBase.BuildSeperator('-'));
            Console.WriteLine(Environment.NewLine);
        }


        private async Task FindMovies()
        {
            var movies = allLibraries.LibraryIds
                .Where(x => x.Key == "Movies")
                .OrderBy(x => x.Key).ToList();

            var MoviceService = new MoviesService(config);
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
