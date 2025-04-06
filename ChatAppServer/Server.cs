using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using DAL;

class Server
{
    private TcpListener _listener;
    private List<Client> _clients = new List<Client>();
    private readonly object _lock = new object();

    // Tạo đối tượng UserBL
    private UserBL _userBL;
    public Server(string ip, int port)
    {
        _listener = new TcpListener(IPAddress.Parse(ip), port);
        UtilitiesDatabase db = UtilitiesDatabase.Instance;
        //Console.WriteLine(((IPEndPoint)_listener.LocalEndpoint).Address.ToString());
        _userBL = new UserBL(0, "", "", null, DateTime.Now);
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

    public UserBL AuthenticateLogin(string username, string password)
    {
        // Kiểm tra thông tin đăng nhập
        DataTable userTable = _userBL.GetAllUsers();
        foreach (DataRow row in userTable.Rows)
        {
            string storedUsername = row["Username"].ToString().Trim();
            string storedPasswordHash = row["PasswordHash"].ToString().Trim();
            string authenticationString = UserBL.HashPassword(username + password);
            // So sánh mật khẩu đã hash
            if (storedUsername == username && authenticationString == storedPasswordHash)
            {
                Console.WriteLine("Authenticated");
                // Tạo đối tượng UserBL để trả về thông tin người dùng
                int userID = (int)row["UserID"];
                byte[] avatarImage = row["AvatarImage"] as byte[];
                DateTime createdAt = (DateTime)row["CreatedAt"];

                return new UserBL(userID, username, authenticationString, avatarImage, createdAt);
            }
        }
        return null; // Nếu không tìm thấy người dùng, trả về null
    }

    public bool RegisterUser(string username, string password)
    {
        // Kiểm tra xem người dùng đã tồn tại chưa
        DataTable userTable = _userBL.GetAllUsers();
        foreach (DataRow row in userTable.Rows)
        {
            if (row["Username"].ToString() == username)
            {
                return false; // Người dùng đã tồn tại
            }
        }

        // Thêm người dùng mới vào cơ sở dữ liệu
        string pass = UserBL.HashPassword(username + password); 
        _userBL = new UserBL(0, username, pass, null, DateTime.Now); // Tạo người dùng mới
        _userBL.AddUser(); // Lưu người dùng vào database
        return true;
    }

    public bool ChangePassword(string username, string password)
    {
        // Kiểm tra xem người dùng đã tồn tại chưa
        DataTable userTable = _userBL.GetAllUsers();
        foreach (DataRow row in userTable.Rows)
        {
            if (row["Username"].ToString() == username)
            {
                
                // Thêm người dùng mới vào cơ sở dữ liệu
                string pass = UserBL.HashPassword(username + password);
                _userBL = new UserBL(0, username, pass, null, DateTime.Now); // Tạo người dùng mới
                _userBL.UpdateUser(); // Lưu người dùng vào database
                return true;
            }
        }
        return false; // Người dùng không tồn tại

    }

    public void BroadcastGroup(string message, Client sender)
    {
        // Gửi đến các client trong group
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

    public void SendToClient(string message, Client sender)
    {
        // Gửi đến client khác
    }

    public void GetAllMessageOfClient(Client sender)
    {

    }

    public void RemoveClient(Client client)
    {
        lock (_lock)
        {
            _clients.Remove(client);
        }
    }
}
