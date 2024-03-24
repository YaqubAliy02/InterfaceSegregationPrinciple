namespace TestingTopic.Services
{
    internal interface ICloudHostingProvider
    {
        void CreateServer(string region);
        void ListServer(string region);
    }
}

