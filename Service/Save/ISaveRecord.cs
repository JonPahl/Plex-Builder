namespace PlexBuilder.Service
{
    public interface ISaveRecord
    {
        //void Dispose();
        void Save();
        void SaveRecord<T>(T record);
    }
}