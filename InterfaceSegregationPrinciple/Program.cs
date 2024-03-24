

using TestingTopic.Services;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Amazon amazon = new Amazon();
            amazon.CreateServer("Angren");
            amazon.ListServer("Toshkent");
            amazon.GetCDNAddress();
            amazon.StoreFile("example.txt");
            amazon.GetFile("test.txt");
            Console.WriteLine();
            Dropbox dropbox = new Dropbox();
            dropbox.GetFile("Dropbox get file");
            dropbox.StoreFile("Dropbox store file");

        }
    }
}