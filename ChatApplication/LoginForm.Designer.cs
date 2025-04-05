namespace ChatApplication
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.overlay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.txtbPassword = new PiStoreManagementSystem.CustomComponents.CustomTextInput();
            this.txtbUsername = new PiStoreManagementSystem.CustomComponents.CustomTextInput();
            this.btnSignUp = new ChatApplication.CustomComponents.CustomButton();
            this.btnSignIn = new ChatApplication.CustomComponents.CustomButton();
            this.labForgotPass = new System.Windows.Forms.Label();
            this.timerOverlay = new System.Windows.Forms.Timer(this.components);
            this.labRegister = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbRegUsername = new PiStoreManagementSystem.CustomComponents.CustomTextInput();
            this.txtbRegPass = new PiStoreManagementSystem.CustomComponents.CustomTextInput();
            this.txtbRegConfPass = new PiStoreManagementSystem.CustomComponents.CustomTextInput();
            this.btnRegister = new ChatApplication.CustomComponents.CustomButton();
            this.btnBack = new ChatApplication.CustomComponents.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.overlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 56);
            this.label1.TabIndex = 99;
            this.label1.Text = "Sign In";
            // 
            // overlay
            // 
            this.overlay.Image = global::ChatApplication.Properties.Resources.overlay;
            this.overlay.Location = new System.Drawing.Point(-305, 0);
            this.overlay.Name = "overlay";
            this.overlay.Size = new System.Drawing.Size(750, 490);
            this.overlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.overlay.TabIndex = 12;
            this.overlay.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChatApplication.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(488, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatApplication.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(488, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.BackgroundImage = global::ChatApplication.Properties.Resources.reject;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(792, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 23);
            this.closeBtn.TabIndex = 150;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtbPassword.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtbPassword.BorderFocusColor = System.Drawing.Color.Navy;
            this.txtbPassword.BorderRadius = 5;
            this.txtbPassword.BorderSize = 2;
            this.txtbPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbPassword.Location = new System.Drawing.Point(527, 262);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbPassword.Multiline = false;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbPassword.PasswordChar = false;
            this.txtbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbPassword.PlaceholderText = "";
            this.txtbPassword.Size = new System.Drawing.Size(265, 37);
            this.txtbPassword.TabIndex = 1;
            this.txtbPassword.Texts = "";
            this.txtbPassword.UnderlinedStyle = false;
            // 
            // txtbUsername
            // 
            this.txtbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtbUsername.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtbUsername.BorderFocusColor = System.Drawing.Color.Navy;
            this.txtbUsername.BorderRadius = 5;
            this.txtbUsername.BorderSize = 2;
            this.txtbUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbUsername.Location = new System.Drawing.Point(527, 212);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUsername.Multiline = false;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbUsername.PasswordChar = false;
            this.txtbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbUsername.PlaceholderText = "";
            this.txtbUsername.Size = new System.Drawing.Size(265, 37);
            this.txtbUsername.TabIndex = 0;
            this.txtbUsername.Texts = "";
            this.txtbUsername.UnderlinedStyle = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignUp.BorderRadius = 5;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.ClickColor = System.Drawing.Color.DarkBlue;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.Location = new System.Drawing.Point(488, 320);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(140, 40);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextColor = System.Drawing.Color.Black;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignIn.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignIn.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignIn.BorderRadius = 5;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.ClickColor = System.Drawing.Color.DarkBlue;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(652, 320);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(140, 40);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextColor = System.Drawing.Color.Black;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // labForgotPass
            // 
            this.labForgotPass.AutoSize = true;
            this.labForgotPass.Font = new System.Drawing.Font("Cambria", 12F);
            this.labForgotPass.Location = new System.Drawing.Point(574, 380);
            this.labForgotPass.Name = "labForgotPass";
            this.labForgotPass.Size = new System.Drawing.Size(134, 19);
            this.labForgotPass.TabIndex = 152;
            this.labForgotPass.Text = "Forgot password?";
            this.labForgotPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labForgotPass_MouseDown);
            this.labForgotPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labForgotPass_MouseUp);
            // 
            // timerOverlay
            // 
            this.timerOverlay.Interval = 5;
            this.timerOverlay.Tick += new System.EventHandler(this.timerOverlay_Tick);
            // 
            // labRegister
            // 
            this.labRegister.AutoSize = true;
            this.labRegister.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegister.Location = new System.Drawing.Point(99, 47);
            this.labRegister.Name = "labRegister";
            this.labRegister.Size = new System.Drawing.Size(160, 56);
            this.labRegister.TabIndex = 153;
            this.labRegister.Text = "Register";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtbRegConfPass);
            this.panel1.Controls.Add(this.txtbRegPass);
            this.panel1.Controls.Add(this.txtbRegUsername);
            this.panel1.Controls.Add(this.labRegister);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 400);
            this.panel1.TabIndex = 154;
            // 
            // txtbRegUsername
            // 
            this.txtbRegUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtbRegUsername.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtbRegUsername.BorderFocusColor = System.Drawing.Color.Navy;
            this.txtbRegUsername.BorderRadius = 5;
            this.txtbRegUsername.BorderSize = 2;
            this.txtbRegUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbRegUsername.Location = new System.Drawing.Point(42, 138);
            this.txtbRegUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbRegUsername.Multiline = false;
            this.txtbRegUsername.Name = "txtbRegUsername";
            this.txtbRegUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbRegUsername.PasswordChar = false;
            this.txtbRegUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbRegUsername.PlaceholderText = "Your username";
            this.txtbRegUsername.Size = new System.Drawing.Size(281, 37);
            this.txtbRegUsername.TabIndex = 154;
            this.txtbRegUsername.Texts = "";
            this.txtbRegUsername.UnderlinedStyle = false;
            // 
            // txtbRegPass
            // 
            this.txtbRegPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtbRegPass.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtbRegPass.BorderFocusColor = System.Drawing.Color.Navy;
            this.txtbRegPass.BorderRadius = 5;
            this.txtbRegPass.BorderSize = 2;
            this.txtbRegPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbRegPass.Location = new System.Drawing.Point(42, 188);
            this.txtbRegPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtbRegPass.Multiline = false;
            this.txtbRegPass.Name = "txtbRegPass";
            this.txtbRegPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbRegPass.PasswordChar = false;
            this.txtbRegPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbRegPass.PlaceholderText = "Your password";
            this.txtbRegPass.Size = new System.Drawing.Size(281, 37);
            this.txtbRegPass.TabIndex = 155;
            this.txtbRegPass.Texts = "";
            this.txtbRegPass.UnderlinedStyle = false;
            // 
            // txtbRegConfPass
            // 
            this.txtbRegConfPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtbRegConfPass.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtbRegConfPass.BorderFocusColor = System.Drawing.Color.Navy;
            this.txtbRegConfPass.BorderRadius = 5;
            this.txtbRegConfPass.BorderSize = 2;
            this.txtbRegConfPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRegConfPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbRegConfPass.Location = new System.Drawing.Point(42, 236);
            this.txtbRegConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtbRegConfPass.Multiline = false;
            this.txtbRegConfPass.Name = "txtbRegConfPass";
            this.txtbRegConfPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbRegConfPass.PasswordChar = false;
            this.txtbRegConfPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbRegConfPass.PlaceholderText = "Confirm your password";
            this.txtbRegConfPass.Size = new System.Drawing.Size(281, 37);
            this.txtbRegConfPass.TabIndex = 156;
            this.txtbRegConfPass.Texts = "";
            this.txtbRegConfPass.UnderlinedStyle = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegister.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegister.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.ClickColor = System.Drawing.Color.DarkBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(42, 308);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 40);
            this.btnRegister.TabIndex = 157;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextColor = System.Drawing.Color.Black;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.BorderRadius = 5;
            this.btnBack.BorderSize = 0;
            this.btnBack.ClickColor = System.Drawing.Color.DarkBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(205, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 40);
            this.btnBack.TabIndex = 158;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.Black;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 490);
            this.Controls.Add(this.overlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.labForgotPass);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomComponents.CustomButton btnSignIn;
        private CustomComponents.CustomButton btnSignUp;
        private PiStoreManagementSystem.CustomComponents.CustomTextInput txtbUsername;
        private PiStoreManagementSystem.CustomComponents.CustomTextInput txtbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox overlay;
        private System.Windows.Forms.Label labForgotPass;
        private System.Windows.Forms.Timer timerOverlay;
        private System.Windows.Forms.Label labRegister;
        private System.Windows.Forms.Panel panel1;
        private PiStoreManagementSystem.CustomComponents.CustomTextInput txtbRegUsername;
        private PiStoreManagementSystem.CustomComponents.CustomTextInput txtbRegPass;
        private PiStoreManagementSystem.CustomComponents.CustomTextInput txtbRegConfPass;
        private CustomComponents.CustomButton btnRegister;
        private CustomComponents.CustomButton btnBack;
    }
}