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
        private string _username;
        private Form1 _form;

        public ChatClient(string serverIp, int port, string username, Form1 form)
        {
            _client = new TcpClient(serverIp, port);
            _username = username;
            _form = form;
        }

        public void Connect()
        {
            _stream = _client.GetStream();
            byte[] nameData = Encoding.UTF8.GetBytes(_username);
            _stream.Write(nameData, 0, nameData.Length);

            Thread thread = new Thread(ReceiveMessages);
            thread.IsBackground = true;
            thread.Start();
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            _stream.Write(data, 0, data.Length);
        }

        private void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    _form.AppendMessage(message);
                }
            }
            catch (Exception)
            {
                _form.AppendMessage("Mất kết nối với server...");
            }
        }
    }
}
