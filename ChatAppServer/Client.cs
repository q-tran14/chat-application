using BLL;
using System;
using System.Net.Sockets;
using System.Text;

class Client
{
    private TcpClient _client;
    private Server _server;
    private NetworkStream _stream;
    private string _clientName;
    private UserBL _userBL; // Đối tượng UserBL

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
            int bytesRead;

            // Gửi yêu cầu đăng nhập hoặc đăng ký
            while (true)
            {
                bytesRead = _stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] requestParts = request.Split('|');

                string command = requestParts[0];
                if (command == "LOGIN")
                {
                    string username = requestParts[1];
                    string password = requestParts[2];
                    _userBL = _server.AuthenticateLogin(username, password); // Nhận đối tượng UserBL khi đăng nhập thành công
                    if (_userBL != null)
                    {
                        _clientName = username;
                        SendMessage($"LOGIN SUCCESS|{_userBL.GetUserO()._UserID}|{_userBL.GetUserO()._Username}");
                        Console.WriteLine($"{_clientName} logged in successfully.");
                        break;
                    }
                    else
                    {
                        SendMessage("LOGIN FAILED");
                        Console.WriteLine("Login failed.");
                    }
                }
                else if (command == "REGISTER")
                {
                    string username = requestParts[1];
                    string password = requestParts[2];
                    bool success = _server.RegisterUser(username, password);
                    //Console.WriteLine("(Client.cs) Register status: " + success);
                    if (success)
                    {
                        _clientName = username;
                        SendMessage("REGISTER SUCCESS");
                        Console.WriteLine($"{_clientName} registered successfully.");
                    }
                    else
                    {
                        SendMessage("REGISTER FAILED");
                        Console.WriteLine("Registration failed.");
                    }
                }
                else if (command == "CHANGE_PASSWORD")
                {
                    string username = requestParts[1];
                    string password = requestParts[2];
                    bool success = _server.ChangePassword(username, password);
                    if (success)
                    {
                        _clientName = username;
                        SendMessage("CHANGE SUCCESS");
                        Console.WriteLine($"{_clientName} change password successfully.");
                    }
                    else
                    {
                        SendMessage("CHANGE PASSWORD FAILED");
                        Console.WriteLine("Change password failed.");
                    }
                }
            }

            // Get all message

            // Sau khi đăng nhập thành công, bắt đầu giao tiếp chat
            while (true)
            {
                bytesRead = _stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] requestParts = message.Split('|');

                string command = requestParts[0];
                string senderID = requestParts[1];
                string content = requestParts[3];
                // handle chat (private chat and group chat)
                if (command == "GROUPMSG") // GROUPMSG|senderID|groupID|content
                {
                    string groupID = requestParts[2];
                    
                    // Làm gì đó ở đây
                }
                else if (command == "PRIVMSG") // PRIVMSG|senderID|receiverID|content
                {
                    string receiverID = requestParts[2];
                    // Làm gì đó ở đây
                }
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
