using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatApplication
{
    public class ChatClient
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public bool IsConnected => _client?.Connected ?? false;

        public void Connect(string ip, int port)
        {
            _client = new TcpClient();
            _client.Connect(ip, port);
            _stream = _client.GetStream();
        }

        public void SendMessage(string message)
        {
            if (_stream != null)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                _stream.Write(data, 0, data.Length);
            }
        }

        public string ReceiveMessage()
        {
            if (_stream != null)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            return null;
        }

        public void Close()
        {
            _stream?.Close();
            _client?.Close();
        }
    }
}
