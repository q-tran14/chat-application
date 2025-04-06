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
using ChatApplication.CustomComponents;
namespace ChatApplication
{
    public partial class MainForm : Form
    {
        private List<ChatBox> chatBoxs = new List<ChatBox>();
        public MainForm()
        {
            InitializeComponent();
            EnableBlur();
            ChatBox chatBox = new ChatBox("User1", "hihi");
            ChatBox chatBox1 = new ChatBox("User1", "hehe");
            ChatBox chatBox2 = new ChatBox("User1", "haha");
            ChatBox chatBox3 = new ChatBox("q-tran14", "hoho");
            ChatBox chatBox4 = new ChatBox("quantran14", "hihi");
            ChatBox chatBox5 = new ChatBox("User1", "hihi");
            ChatBox chatBox6 = new ChatBox("User1", "hihi");
            ChatBox chatBox7 = new ChatBox("User1", "hihi");
            ChatBox chatBox8 = new ChatBox("User1", "hihi");
            ChatBox chatBox9 = new ChatBox("User1", "hihi");
            ChatBox chatBox10 = new ChatBox("User1", "hihi");
            ChatBox chatBox11 = new ChatBox("User1", "hihi");
            ChatBox chatBox12 = new ChatBox("User1", "hihi");
            ChatBox chatBox13 = new ChatBox("User1", "hihi");
            ChatBox chatBox14 = new ChatBox("User1", "hihi");
            chatBoxs.Add(chatBox);
            chatBoxs.Add(chatBox1);
            chatBoxs.Add(chatBox2);
            chatBoxs.Add(chatBox3);
            chatBoxs.Add(chatBox4);
            chatBoxs.Add(chatBox5);
            chatBoxs.Add(chatBox6);
            chatBoxs.Add(chatBox7);
            chatBoxs.Add(chatBox8);
            chatBoxs.Add(chatBox9);
            chatBoxs.Add(chatBox10);
            chatBoxs.Add(chatBox11);
            chatBoxs.Add(chatBox12);
            chatBoxs.Add(chatBox13);
            chatBoxs.Add(chatBox14);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpChatBox();
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

        private void EnableBlur()
        {
            var blur = new DWM_BLURBEHIND
            {
                dwFlags = 1,
                fEnable = true,
                hRgnBlur = IntPtr.Zero
            };

            DwmEnableBlurBehindWindow(this.Handle, ref blur);

            // Áp dụng hiệu ứng Acrylic nếu chạy trên Windows 10+
            if (Environment.OSVersion.Version.Major >= 10)
            {
                var accent = new AccentPolicy
                {
                    AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND,
                    AccentFlags = 2,
                    GradientColor = (250 << 24) | (0xFFFFFF & 0x505050) // Độ trong suốt (Alpha = 120)
                };

                int size = Marshal.SizeOf(accent);
                IntPtr accentPtr = Marshal.AllocHGlobal(size);
                Marshal.StructureToPtr(accent, accentPtr, false);

                var data = new WindowCompositionAttributeData
                {
                    Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                    SizeOfData = size,
                    Data = accentPtr
                };

                SetWindowCompositionAttribute(this.Handle, ref data);
                Marshal.FreeHGlobal(accentPtr);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DWM_BLURBEHIND
        {
            public int dwFlags;
            public bool fEnable;
            public IntPtr hRgnBlur;
            public bool fTransitionOnMaximized;
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmEnableBlurBehindWindow(IntPtr hwnd, ref DWM_BLURBEHIND blurBehind);

        [StructLayout(LayoutKind.Sequential)]
        private struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        private enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_ENABLE_ACRYLICBLURBEHIND = 4, // Acrylic Blur (Windows 10+)
            ACCENT_ENABLE_HOSTBACKDROP = 5
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        private enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);
        #endregion

        private void btnNewGroupChat_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void txtbMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSend_Click(sender, EventArgs.Empty);
            }
        }

        private void ChatBox_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            ChatBox b = control as ChatBox ?? control.Parent as ChatBox ?? control.Parent?.Parent as ChatBox;

            (b.Controls.Find("labUsername",true)[0] as Label).Text = "Change here";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // Tìm loginForm nếu nó đang ẩn
            Form loginForm = Application.OpenForms["LoginForm"];
            if (loginForm != null)
            {
                loginForm.Show(); // Hiển thị lại loginForm cũ
            }
            else
            {
                // Nếu không tìm thấy, tạo lại
                loginForm = new LoginForm();
                loginForm.Show();
            }

            btnExit_Click(sender, EventArgs.Empty); // Đóng mainForm
        }

        private void SetUpChatBox()
        {
            int step = 0;
            foreach (ChatBox box in chatBoxs)
            {
                panelChatBoxs.Controls.Add(box);
                box.Location = new Point(0, step);
                step = box.Location.Y + box.Height;
                foreach (Control control in box.Controls)
                {
                    control.Click += ChatBox_Click;
                }
                box.Click += ChatBox_Click;
            }
        }
    }
}
