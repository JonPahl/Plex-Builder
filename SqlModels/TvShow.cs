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
            builder.AppendFormat("{0} | ", Title);
            builder.AppendFormat("{0} | ", Year);
            builder.AppendFormat("{0} | ", Season);
            builder.AppendFormat("{0} | ", Episode);
            builder.AppendFormat("{0} | ", EpisodeTitle);
            builder.AppendFormat("{0} | ", File);
            builder.AppendFormat("{0} | ", IsAvailable);
            builder.AppendFormat("{0} | ", DateTime.Now);

            return builder.ToString();
        }

    }
}
