namespace TestingTopic.Services
{
    internal class Amazon : ICloudHostingProvider, ICDNProvider,ICloudStorageProvider
    {
        public void CreateServer(string region)
        {
            Console.WriteLine($"Create server {region} Amazon");
        }

        public void GetCDNAddress()
        {
            Console.WriteLine("GEt CDN Address");
        }
        
        public void GetFile(string name)
        {
            Console.WriteLine($"Get File {name} Amazon");
        }

        public void ListServer(string region)
        {
            Console.WriteLine($"List Server {region} Amazon");
        }

        public void StoreFile(string name)
        {
            Console.WriteLine($"Store File {name} Amazon");
        }

    }
}
