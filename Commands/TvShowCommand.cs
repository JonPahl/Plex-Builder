using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;

namespace PlexBuilder.Commands
{
    public class TvShowCommand : ACommand
    {
        private readonly TvShowService TvShowService;

        public TvShowCommand(PlexContext context, AppSettings setting) : base(context, setting) {
            Name = "TV Shows";
            TvShowService = new TvShowService(Context);
        }

        public override void ExecuteAction()
        {
            var TvShows = GetAllLibraries(Name);
            TvShowService.Execute(TvShows).GetAwaiter().GetResult();
        }

        public override object GetResults()
        {
            return TvShowService.Libraries;
        }
    }
}
