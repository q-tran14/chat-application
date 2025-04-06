using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.CustomComponents
{
    public partial class ChatBox : UserControl
    {
        public string userName;
        public string lastedMessage;
        public Image avatar;
        public ChatBox(string username, string lastedMessage, Image avatar = null)
        {
            InitializeComponent();  
            this.Cursor = Cursors.Hand;
            UpdateChatBox(username, lastedMessage, avatar);

        }
        public void LoadChatBox()
        {
            labUsername.Text = userName;
            labLastedMessage.Text = lastedMessage;
            if (avatar != null)
            {
                picAva.Image = avatar;
            }
        }

        public void UpdateChatBox(string username, string lastedMessage, Image avatar = null)
        {
            this.userName = username;
            this.lastedMessage = lastedMessage;
            this.avatar = avatar;
            LoadChatBox();
        }
    }
}
