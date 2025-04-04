using System;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        private ChatClient _client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _client = new ChatClient("127.0.0.1", 12345, username, this);
            _client.Connect();
            btnConnect.Enabled = false;
        }

        public void AppendMessage(string message)
        {
            if (txtChat.InvokeRequired)
            {
                txtChat.Invoke(new Action(() => txtChat.AppendText(message + Environment.NewLine)));
            }
            else
            {
                txtChat.AppendText(message + Environment.NewLine);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                _client.SendMessage(message);
                txtMessage.Clear();
            }
        }
    }
}
