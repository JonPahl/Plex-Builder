using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;

namespace PlexBuilder.Commands
{
    public class TvShowCommand : ACommand
    {
        public TvShowCommand(PlexContext context, AppSettings setting) : base(context, setting) => Name = "TV Shows";

        public override void ExecuteAction()
        {
            //var config = GetConfig();
            var TvShows = GetAllLibraries(Name);
            var TvService = new TvShowService(Context);
            TvService.Execute(TvShows).GetAwaiter().GetResult();
        }
    }
}
