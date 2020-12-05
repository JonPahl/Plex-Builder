using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;

namespace PlexBuilder.Commands
{
    public class AllLibrariesCommand : ACommand
    {
        //public object Client { get; set; }
        //public string Name { get; set; }

        private AllLibrariesService Services { get; }

        public AllLibrariesCommand(PlexContext context, AppSettings setting) : base(context, setting)
        {
            Name = "AllLibraries";
            Services = new AllLibrariesService(Context);
        }

        public override void ExecuteAction()
        {
            Services.Execute().GetAwaiter().GetResult();
        }

        public override object GetResults()
        {
            var results = Services.Libraries;
            return results;
        }
    }
}