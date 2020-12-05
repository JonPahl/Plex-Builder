using PlexBuilder.Abstract;
using PlexBuilder.Concrete;
using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;
using Serilog.Configuration;
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

        public abstract void ExecuteAction();
        public abstract object GetResults();

        //protected PlexConfig GetConfig()
        //{
        //    var login = new PlexLogin(setting);
        //    var token = login.Login().Result;

        //    PlexConfig.BaseUrl = new System.Uri(setting.PlexServer);
        //    PlexConfig.Token = token;

        //    //return new PlexConfig { BaseUrl = new System.Uri(setting.PlexServer), Token = token };
        //}

        protected List<KeyValuePair<string, int>> GetAllLibraries() => allLibraries;
        protected List<KeyValuePair<string, int>> GetAllLibraries(string Name) => allLibraries.Where(x => x.Key.Equals(Name)).OrderBy(x => x.Key).ToList();
        protected void SetAllLibraries(List<KeyValuePair<string, int>> value) => allLibraries = value;

        private async Task<List<KeyValuePair<string, int>>> LoadLibaries()
        {
            //var config = GetConfig();
            var allLibraries = new AllLibrariesService(this.Context);
            await allLibraries.Execute().ConfigureAwait(false);
            SetAllLibraries(allLibraries.LibraryIds);
            return allLibraries.LibraryIds;
        }
    }
}
