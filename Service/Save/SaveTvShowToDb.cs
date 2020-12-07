using PlexBuilder.SqlModels;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace PlexBuilder.Service
{
    #region save to Db
    public class SaveTvShowToDb : IDisposable, ISaveRecord
    {
        private bool isDisposed;
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);
        //private AnotherResource managedResource = new AnotherResource();

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
                        .Find(x => x.File == record.File);

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

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // The bulk of the clean-up code is implemented in Dispose(bool)
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;
            if (disposing)
            {
                // free managed resources                
                context.Dispose();
            }

            // free native resources if there are any.
            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            isDisposed = true;
        }

        // NOTE: Leave out the finalizer altogether if this class doesn't
        // own unmanaged resources, but leave the other methods
        // exactly as they are.
        /*~SaveTvShowToDb() { // Finalizer calls Dispose(false) Dispose(false); }*/
    }

    #endregion
}