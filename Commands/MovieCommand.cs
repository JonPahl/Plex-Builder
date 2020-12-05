using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;

namespace PlexBuilder.Commands
{
    public class MovieCommand : ACommand
    {
        public MovieCommand(PlexContext context, AppSettings setting) : base(context, setting) => Name = "Movies";

        public override void ExecuteAction()
        {
            //var Config = GetConfig();
            var movies = GetAllLibraries(Name);
            var MoviceService = new MoviesService(Context);
            MoviceService.Execute(movies).GetAwaiter().GetResult();
        }
    }
}
