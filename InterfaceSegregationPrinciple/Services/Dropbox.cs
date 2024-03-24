namespace TestingTopic.Services
{
    internal class Dropbox : ICloudStorageProvider
    {
      
        public void GetFile(string name)
        {
            Console.WriteLine($"Get File { name}");
        }

        public void StoreFile(string name)
        {
            Console.WriteLine($"Store File{name}");
        }
    }
}

