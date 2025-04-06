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
using BLL;

namespace ChatApplication
{
    public partial class LoginForm : Form
    {
        private bool _loginOrRegister = true; // true = login, false = register
        private bool _forgotPass = false;
        public LoginForm()
        {
            InitializeComponent();
            txtbPassword.PasswordChar = true;
            txtbRegPass.PasswordChar = true;
            txtbRegConfPass.PasswordChar = true;
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
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtbUsername.KeyPress += textBox_KeyPress;
            txtbPassword.KeyPress += textBox_KeyPress;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtbUsername.Texts;
            string password = UserBL.HashPassword(txtbPassword.Texts.Trim());

            if (!Program.chatClient.IsConnected)
            {
                ToastManager.ShowToastNotification("Error", "Not connected to server.", "error", this);
                return;
            }

            if (validateAccount(username, password) == false)
            {
                ToastManager.ShowToastNotification("Login Error", "Incorrect username or password!", "error", this);
                return;
            }
            // Move to the next form (mainForm)
            MainForm main = new MainForm(); // Pass userId if needed
            main.Show();
            this.Hide(); // Hide the login form

            // Khi mainForm đóng, thoát ứng dụng
            main.FormClosed += (s, args) => this.Show();
        }

        private bool validateAccount(string username, string password)
        {
            string request = $"LOGIN|{username}|{password}";
            Program.chatClient.SendMessage(request);

            string response = Program.chatClient.ReceiveMessage();
            Console.WriteLine(response);
            if (response.StartsWith("LOGIN SUCCESS"))
            {
                string[] parts = response.Split('|');
                int userId = int.Parse(parts[1]);
                string usernameReturned = parts[2];
                //
                return true;
            }
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (_loginOrRegister == false && _forgotPass)
            {
                string username = txtbRegUsername.Texts.Trim();
                string password = UserBL.HashPassword(txtbRegConfPass.Texts.Trim());

                if (!Program.chatClient.IsConnected)
                {
                    ToastManager.ShowToastNotification("Error", "Not connected to server.", "error", this);
                    return;
                }
                if (txtbRegPass.Texts != txtbRegConfPass.Texts) return;

                string request = $"CHANGE_PASSWORD|{username}|{password}";
                Program.chatClient.SendMessage(request);

                string response = Program.chatClient.ReceiveMessage();

                if (response == "CHANGE SUCCESS")
                {
                    ToastManager.ShowToastNotification("Success", "Change password successful!", "success", this);
                    btnBack_Click(sender, EventArgs.Empty); // Quay lại giao diện đăng nhập
                }
                else
                {
                    ToastManager.ShowToastNotification("Error", "Username not exists!", "error", this);
                }
            }
            else
            {
                string username = txtbRegUsername.Texts.Trim();
                string password = UserBL.HashPassword(txtbRegConfPass.Texts.Trim());

                if (!Program.chatClient.IsConnected)
                {
                    ToastManager.ShowToastNotification("Error", "Not connected to server.", "error", this);
                    return;
                }
                if (txtbRegPass.Texts != txtbRegConfPass.Texts) return;

                string request = $"REGISTER|{username}|{password}";
                Program.chatClient.SendMessage(request);

                string response = Program.chatClient.ReceiveMessage();

                if (response == "REGISTER SUCCESS")
                {
                    ToastManager.ShowToastNotification("Success", "Registration successful!", "success", this);
                    btnBack_Click(sender, EventArgs.Empty); // Quay lại giao diện đăng nhập
                }
                else
                {
                    ToastManager.ShowToastNotification("Error", "Username already exists!", "error", this);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            moveOverlay();
            RegisterOrForgotPassword();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control currentControl = sender as Control;

                if (currentControl != null && currentControl.TabIndex == 0)
                {
                    this.SelectNextControl(currentControl, true, true, true, true);
                }
                else btnSignIn_Click(btnSignIn, EventArgs.Empty);
                e.Handled = true;
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labForgotPass_MouseUp(object sender, MouseEventArgs e)
        {
            labForgotPass.ForeColor = Color.Black;
        }

        private void labForgotPass_MouseDown(object sender, MouseEventArgs e)
        {
            _forgotPass = true;
            labForgotPass.ForeColor = Color.DarkBlue;
            moveOverlay();
            RegisterOrForgotPassword();
        }

        private void timerOverlay_Tick(object sender, EventArgs e)
        {
            int currentX = overlay.Location.X;
            int step = 35;
            if (_loginOrRegister == false)
            {
                if (currentX < 385)
                {
                    overlay.Location = new Point(currentX + step, 0);
                }
                else
                {
                    overlay.Location = new Point(385, 0);
                    timerOverlay.Stop();
                }
            }
            else
            {
                if (currentX > -305)
                {
                    overlay.Location = new Point(currentX - step, 0);
                }
                else
                {
                    overlay.Location = new Point(-305, 0);
                    timerOverlay.Stop();
                }
            }
            
            if (currentX == -305 && _forgotPass == false) RegisterOrForgotPassword();
        }

        private void moveOverlay()
        {
            _loginOrRegister = !_loginOrRegister;
            timerOverlay.Start();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            _forgotPass = false;
            moveOverlay();
            txtbRegConfPass.Leave -= txtbRegConfPass_Leave;
        }

        private void RegisterOrForgotPassword()
        {

            txtbRegUsername.PlaceholderText = "Your username";
            txtbRegPass.PlaceholderText = "Your password";
            if (_loginOrRegister == false && _forgotPass)
            {
                labRegister.Text = "Change Password";
                btnRegister.Text = "Confirm";
                txtbRegConfPass.PlaceholderText = "New password";
            }
            else
            {
                labRegister.Text = "Register";
                btnRegister.Text = "Register";
                txtbRegConfPass.PlaceholderText = "Confirm your password";
                txtbRegConfPass.Leave += txtbRegConfPass_Leave;
            }
            labRegister.Location = new Point(panel1.Width / 2 - labRegister.Width / 2, 47);
        }

        private void txtbRegConfPass_Leave(object sender, EventArgs e)
        {
            if (txtbRegPass.Texts != txtbRegConfPass.Texts)
            {
                txtbRegConfPass.BorderColor = Color.Tomato;
                ToastManager.ShowToastNotification("Error", "Password and Confirm Password not matched", "error", this);
            }else txtbRegConfPass.BorderColor = Color.LightSteelBlue;
        }
    }
}
