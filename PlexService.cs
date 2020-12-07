using Microsoft.Extensions.Hosting;
using PlexBuilder.Abstract;
using PlexBuilder.Commands;
using PlexBuilder.Models;
using PlexBuilder.SqlModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlexBuilder
{
    public class PlexService : IHostedService
    {
        protected RunCommands Runner { get; set; }
        private PlexContext Context { get; }
        private AppSettings Setting { get; }

        public PlexService(PlexContext context, AppSettings setting)
        {
            Runner = new RunCommands();
            Setting = setting;
            Context = context;
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
            var movieCmd = new MovieCommand(Context, Setting);
            var tvShowCmd = new TvShowCommand(Context, Setting);
            await Execute(movieCmd).ConfigureAwait(false);
            await Execute(tvShowCmd).ConfigureAwait(false);
        }

        private async Task Execute(ICommand Command)
        {
            Runner.SetCommand(Command);
            await Runner.Invoke().ConfigureAwait(false);
        }
    }
}
