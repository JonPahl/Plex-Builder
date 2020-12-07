using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;
using System.Threading.Tasks;

namespace PlexBuilder.Commands
{
    public class MovieCommand : ACommand
    {
        private MoviesService MoviceService { get; }

        public MovieCommand(PlexContext context, AppSettings setting) : base(context, setting)
        {
            Name = "Movies";
            MoviceService = new MoviesService(context);
        }

        public override async Task ExecuteActionAsync() => await MoviceService.Execute(GetAllLibraries(Name)).ConfigureAwait(false);

        public override object GetResults() => MoviceService.Libraries;
    }
}
