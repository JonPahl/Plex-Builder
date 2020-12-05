using PlexBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexBuilder.Commands
{
    public class AllLibrariesCommand : ICommand
    {
        public object Client { get; set; }
        public string Name { get; set; }

        public AllLibrariesCommand()
        {
            Name = "AllLibraries";
        }

        public void ExecuteAction()
        {
            throw new NotImplementedException();
        }
    }
}
