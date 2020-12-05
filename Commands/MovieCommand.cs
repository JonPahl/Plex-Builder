using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;

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

        public override void ExecuteAction()
        {
            //var Config = GetConfig();
            var movies = GetAllLibraries(Name);            
            MoviceService.Execute(movies).GetAwaiter().GetResult();
        }

        public override object GetResults()
        {
            //var results = MoviceService.GetResults();
            var results = MoviceService.Libraries;
            return results;
        }
    }
}
