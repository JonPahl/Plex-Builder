using System;
using System.IO;

namespace PlexBuilder.Service.Save
{    
    public class SaveToFile : ISaveRecord
    {
        private string SavePath { get; set; }

        public SaveToFile(string path)
        {
            SavePath = path;
        }

        public void Save()
        {
        }

        public void SaveRecord<T>(T item)
        {
            try
            {
                using StreamWriter sw = File.AppendText(SavePath);
                sw.WriteLine(item.ToString());
                sw.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}