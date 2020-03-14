using PlexBuilder.SqlModels;
using System;
using System.Linq;

namespace PlexBuilder.Service
{
    #region save to Db

    public class SaveTvShowToDb : IDisposable, ISaveRecord
    {
        bool disposed = false;

        private readonly PlexContext context;
        public SaveTvShowToDb()
        {
            context = new PlexContext();
        }


        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        public void SaveRecord<T>(T item)
        {
            TvShow record = item as TvShow;

            try
            {
                var savedRecord = context.TvShow
                        .Where(x => x.Title == record.Title).ToList()
                        .Where(x => x.Episode == record.Episode).ToList()
                        .Where(x => x.File == record.File).FirstOrDefault();

                if (savedRecord == null)
                {
                    context.TvShow.Add(record);
                    Console.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}: Added");
                }
                else
                {
                    savedRecord.Title = record.Title;
                    savedRecord.Year = record.Year;
                    savedRecord.Season = record.Season;
                    savedRecord.Episode = record.Episode;
                    savedRecord.EpisodeTitle = record.EpisodeTitle;
                    savedRecord.File = record.File;
                    savedRecord.IsAvailable = record.IsAvailable;
                    savedRecord.LastUpdated = DateTime.Now;

                    context.TvShow.Update(savedRecord);
                    Console.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}: Updated");
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                this.Dispose();
            }
            disposed = true;
        }

        public void Dispose() => context.Dispose();
    }

    #endregion
}