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
            builder.AppendFormat("{0} | ", Title)
                .AppendFormat("{0} | ", Year)
                .AppendFormat("{0} | ", Season)
                .AppendFormat("{0} | ", Episode)
                .AppendFormat("{0} | ", EpisodeTitle)
                .AppendFormat("{0} | ", File)
                .AppendFormat("{0} | ", IsAvailable)
                .AppendFormat("{0} | ", DateTime.Now);

            return builder.ToString();
        }
    }
}
