using PlexBuilder.Abstract;
using System.Collections.Generic;

namespace PlexBuilder
{
    public class RunCommands
    {
        private List<ICommand> Commands { get; }
        private ICommand Command { get; set; }
        //private ApiClientFactory Factory { get; }

        public RunCommands()
        {
            //ApiClientFactory factory
            Commands = new List<ICommand>();
            //Factory = factory;
        }
        public void SetCommand(ICommand command) => Command = command;
        public void Invoke()
        {
            Commands.Add(Command);
            Command.ExecuteAction();
        }
    }
}