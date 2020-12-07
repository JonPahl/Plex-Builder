using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;
using System.Threading.Tasks;

namespace PlexBuilder.Commands
{
    public class TvShowCommand : ACommand
    {
        private readonly TvShowService Service;

        public TvShowCommand(PlexContext context, AppSettings setting) : base(context, setting) {
            Name = "TV Shows";
            Service = new TvShowService(Context);
        }

        //public override void ExecuteAction() => TvShowService.Execute(GetAllLibraries(Name)).GetAwaiter().GetResult();

        public override async Task ExecuteActionAsync() => await Service.Execute(GetAllLibraries(Name)).ConfigureAwait(false);

        public override object GetResults() => Service.Libraries;
    }
}
