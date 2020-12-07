using PlexBuilder.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlexBuilder
{
    public class RunCommands
    {
        private List<ICommand> Commands { get; }
        private ICommand Command { get; set; }
        public RunCommands() => Commands = new List<ICommand>();
        public void SetCommand(ICommand command) => Command = command;
        public async Task Invoke()
        {
            Commands.Add(Command);
            await Command.ExecuteActionAsync().ConfigureAwait(false);
        }
    }
}