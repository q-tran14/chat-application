using System;
using System.Net.Sockets;
using System.Text;

class Client
{
    private TcpClient _client;
    private Server _server;
    private NetworkStream _stream;
    private string _clientName;

    public Client(TcpClient client, Server server)
    {
        _client = client;
        _server = server;
        _stream = client.GetStream();
    }

    public void HandleClient()
    {
        try
        {
            byte[] buffer = new byte[1024];
            int bytesRead = _stream.Read(buffer, 0, buffer.Length);
            _clientName = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
            Console.WriteLine($"{_clientName} joined the chat.");

            while (true)
            {
                bytesRead = _stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"{_clientName}: {message}");

                _server.Broadcast($"{_clientName}: {message}", this);
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"{_clientName} disconnected.");
        }
        finally
        {
            _server.RemoveClient(this);
            _client.Close();
        }
    }

    public void SendMessage(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        _stream.Write(data, 0, data.Length);
    }
}
