namespace PlexBuilder.Service
{
    public interface ISaveRecordToDb
    {
        //void Dispose();
        void Save();
        void SaveRecord<T>(T record);
    }
}