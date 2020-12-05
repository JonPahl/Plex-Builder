using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlexBuilder.SqlModels
{
    public class TvShow
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Season { get; set; }
        public int Episode { get; set; }
        public string EpisodeTitle { get; set; }
        public string File { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? LastUpdated { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder
                .Append(Title).Append(" | ")
                .Append(Year).Append(" | ")
                .Append(Season).Append(" | ")
                .Append(Episode).Append(" | ")
                .Append(EpisodeTitle).Append(" | ")
                .Append(File).Append(" | ")
                .Append(IsAvailable).Append(" | ")
                .Append(DateTime.Now).Append(" | ");

            return builder.ToString();
        }
    }
}
