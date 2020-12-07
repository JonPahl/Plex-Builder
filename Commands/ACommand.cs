using PlexBuilder.Abstract;
using PlexBuilder.Concrete;
using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;
using Serilog.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlexBuilder.Commands
{
    public abstract class ACommand : ICommand
    {
        public object Client { get; set; }
        public string Name { get; set; }

        protected PlexContext Context { get; }
        protected AppSettings setting { get; }

        private List<KeyValuePair<string, int>> allLibraries;
        protected ACommand(PlexContext context, AppSettings setting)
        {
            Context = context;
            this.setting = setting;
            PlexConfig.SetupConfig(setting);
            SetAllLibraries(LoadLibaries().GetAwaiter().GetResult());
        }
        public virtual void ExecuteAction() { }
        public virtual Task ExecuteActionAsync() { return Task.FromException(new NotImplementedException("")); }

        public abstract object GetResults();

        protected List<KeyValuePair<string, int>> GetAllLibraries() => allLibraries;
        protected List<KeyValuePair<string, int>> GetAllLibraries(string Name) => allLibraries.Where(x => x.Key.Equals(Name)).OrderBy(x => x.Key).ToList();
        protected void SetAllLibraries(List<KeyValuePair<string, int>> value) => allLibraries = value;

        private async Task<List<KeyValuePair<string, int>>> LoadLibaries()
        {
            return new List<KeyValuePair<string, int>>();
            /*
            var allLibraries = new AllLibrariesService(Context);
            await allLibraries.Execute().ConfigureAwait(false);
            SetAllLibraries(allLibraries.LibraryIds);
            return allLibraries.LibraryIds;
            */
        }
    }
}
