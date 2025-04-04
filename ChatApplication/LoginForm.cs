using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChatApplication.Ultilities;
namespace ChatApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
        }

        #region UI CUSTOM
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int radius = 40; // Độ cong góc

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
        #endregion
    }
}
