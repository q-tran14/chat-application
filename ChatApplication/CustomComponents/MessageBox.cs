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
    public partial class MessageBox : UserControl
    {
        public string message;
        public string timestamp;
        public string type;
        public MessageBox(string message, string type, string timestamp)
        {
            InitializeComponent();
            this.message = message;
            this.timestamp = timestamp;
            labMessage.Text = message;
            labTimeStamp.Text = timestamp;
            if (type == "Receive")
            {
                labTimeStamp.TextAlign = ContentAlignment.MiddleRight;
                labMessage.TextAlign = ContentAlignment.MiddleLeft;
            }else if (type == "Send")
            {
                labTimeStamp.TextAlign = ContentAlignment.MiddleLeft;
                labMessage.TextAlign = ContentAlignment.MiddleRight;
            }
        }
    }
}
