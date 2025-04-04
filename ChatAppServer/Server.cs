using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Server
{
    private TcpListener _listener;
    private List<Client> _clients = new List<Client>();
    private readonly object _lock = new object();

    public Server(int port)
    {
        _listener = new TcpListener(IPAddress.Any, port);
    }

    public void Start()
    {
        _listener.Start();
        Console.WriteLine("Server started on port 12345...");

        while (true)
        {
            TcpClient client = _listener.AcceptTcpClient();
            Client handler = new Client(client, this);
            lock (_lock)
            {
                _clients.Add(handler);
            }
            Thread thread = new Thread(handler.HandleClient);
            thread.Start();
        }
    }

    public void Broadcast(string message, Client sender)
    {
        lock (_lock)
        {
            foreach (var client in _clients)
            {
                if (client != sender)
                {
                    client.SendMessage(message);
                }
            }
        }
    }

    public void RemoveClient(Client client)
    {
        lock (_lock)
        {
            _clients.Remove(client);
        }
    }
}
