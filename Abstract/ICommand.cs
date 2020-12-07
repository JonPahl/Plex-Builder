using System.Threading.Tasks;

namespace PlexBuilder.Abstract
{
    public interface ICommand
    {
        public object Client { get; set; }
        public string Name { get; set; }
        void ExecuteAction();
        Task ExecuteActionAsync();
    }
}
