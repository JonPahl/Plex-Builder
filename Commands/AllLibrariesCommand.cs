
using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;
using System.Threading.Tasks;

namespace PlexBuilder.Commands
{
    public class AllLibrariesCommand : ACommand
    {
        private AllLibrariesService Services { get; }

        public AllLibrariesCommand(PlexContext context, AppSettings setting) : base(context, setting)
        {
            Name = "AllLibraries";
            Services = new AllLibrariesService(Context);
        }

        public override async Task ExecuteActionAsync() => await Services.Execute().ConfigureAwait(false);
        public override object GetResults() => Services.Libraries;
    }
}
