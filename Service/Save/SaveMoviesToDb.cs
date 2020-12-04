using PlexBuilder.SqlModels;
using System;
using System.Linq;

namespace PlexBuilder.Service.Save
{
    /// <summary>
    /// Save outputs from XML into a database.
    /// </summary>
    /// <seealso cref="IDisposable" />
    /// <seealso cref="ISaveRecord" />
    public class SaveMoviesToDb : IDisposable, ISaveRecord
    {
        private readonly PlexContext context;
        public SaveMoviesToDb()
        {
            context = new PlexContext();
        }

        public SaveMoviesToDb(PlexContext context)
        {
            this.context = context;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void SaveRecord<T>(T item)
        {
            Movies record = item as Movies;
            var recordId = RecordId(record);

            if (recordId == -1)
            {
                InsertRecord(record);
                Console.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}: Added");
            }
            //else{record.Id = recordId;UpdateRecord(record);Console.WriteLine("Updated");}
        }

        private void UpdateRecord<T>(T item)
        {
            Movies record = item as Movies;
            try
            {
                context.Update(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InsertRecord<T>(T item)
        {
            Movies record = item as Movies;
            try
            {
                context.Add(record);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int RecordId<T>(T item)
        {
            var record = item as Movies;

            var savedRecord = context.Movies
                        .Where(x => x.Title == record.Title)
                        .ToList()
                        .FirstOrDefault(x => x.Year == record.Year);

            return savedRecord == null ? -1 : savedRecord.Id;
        }

        public void Dispose(bool dispose)
        {
            Dispose();
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(context);
        }
    }
}