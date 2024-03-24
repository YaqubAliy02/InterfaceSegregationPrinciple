namespace TestingTopic.Services
{
    internal interface ICloudStorageProvider
    {
        void StoreFile(string name);
        void GetFile(string name);
    }
}
