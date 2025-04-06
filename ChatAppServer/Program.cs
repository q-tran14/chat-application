
class Program
{
    static void Main()
    {

        Server server = new Server("127.0.0.1",12345);
        server.Start();
    }
}