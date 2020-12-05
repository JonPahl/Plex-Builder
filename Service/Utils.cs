using System.IO;

namespace PlexBuilder.Service
{
    public static class Utils
    {
        public static bool FileExists(string path) => File.Exists(Path.GetFullPath(path?.Trim()));
        public static string BuildSeperator(char item, int cnt = 20) => new string(item, cnt);
    }
}
