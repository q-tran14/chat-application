namespace ChatApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewGroupChat = new ChatApplication.CustomComponents.CustomButton();
            this.btnSignOut = new ChatApplication.CustomComponents.CustomButton();
            this.panelChatBoxs = new System.Windows.Forms.Panel();
            this.panelMessagesBox = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.txtbMessage = new PiStoreManagementSystem.CustomComponents.CustomTextInput();
            this.btnSend = new ChatApplication.CustomComponents.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnNewGroupChat);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.panelChatBoxs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnNewGroupChat
            // 
            this.btnNewGroupChat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewGroupChat.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewGroupChat.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewGroupChat.BorderRadius = 5;
            this.btnNewGroupChat.BorderSize = 0;
            this.btnNewGroupChat.ClickColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewGroupChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGroupChat.FlatAppearance.BorderSize = 0;
            this.btnNewGroupChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGroupChat.Font = new System.Drawing.Font("Californian FB", 14.25F);
            this.btnNewGroupChat.ForeColor = System.Drawing.Color.Black;
            this.btnNewGroupChat.Location = new System.Drawing.Point(113, 659);
            this.btnNewGroupChat.Name = "btnNewGroupChat";
            this.btnNewGroupChat.Size = new System.Drawing.Size(112, 40);
            this.btnNewGroupChat.TabIndex = 2;
            this.btnNewGroupChat.Text = "New Group";
            this.btnNewGroupChat.TextColor = System.Drawing.Color.Black;
            this.btnNewGroupChat.UseVisualStyleBackColor = false;
            this.btnNewGroupChat.Click += new System.EventHandler(this.btnNewGroupChat_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignOut.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignOut.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignOut.BorderRadius = 5;
            this.btnSignOut.BorderSize = 0;
            this.btnSignOut.ClickColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Californian FB", 14.25F);
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Location = new System.Drawing.Point(19, 659);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(88, 40);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextColor = System.Drawing.Color.Black;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // panelChatBoxs
            // 
            this.panelChatBoxs.AutoScroll = true;
            this.panelChatBoxs.Location = new System.Drawing.Point(3, 59);
            this.panelChatBoxs.Name = "panelChatBoxs";
            this.panelChatBoxs.Size = new System.Drawing.Size(243, 579);
            this.panelChatBoxs.TabIndex = 0;
            // 
            // panelMessagesBox
            // 
            this.panelMessagesBox.AutoScroll = true;
            this.panelMessagesBox.BackColor = System.Drawing.Color.Black;
            this.panelMessagesBox.Location = new System.Drawing.Point(277, 59);
            this.panelMessagesBox.Name = "panelMessagesBox";
            this.panelMessagesBox.Size = new System.Drawing.Size(976, 579);
            this.panelMessagesBox.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::ChatApplication.Properties.Resources.reject_gradient;
            this.btnExit.Location = new System.Drawing.Point(1242, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 26);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtbMessage
            // 
            this.txtbMessage.AutoSize = true;
            this.txtbMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtbMessage.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtbMessage.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txtbMessage.BorderRadius = 5;
            this.txtbMessage.BorderSize = 1;
            this.txtbMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbMessage.Location = new System.Drawing.Point(277, 662);
            this.txtbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtbMessage.Multiline = false;
            this.txtbMessage.Name = "txtbMessage";
            this.txtbMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbMessage.PasswordChar = false;
            this.txtbMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbMessage.PlaceholderText = "Somthing here";
            this.txtbMessage.Size = new System.Drawing.Size(827, 35);
            this.txtbMessage.TabIndex = 3;
            this.txtbMessage.Texts = "";
            this.txtbMessage.UnderlinedStyle = false;
            this.txtbMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbMessage_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSend.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSend.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSend.BorderRadius = 5;
            this.btnSend.BorderSize = 0;
            this.btnSend.ClickColor = System.Drawing.Color.CornflowerBlue;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(1126, 662);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.TextColor = System.Drawing.Color.Black;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtbMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelMessagesBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMessagesBox;
        private System.Windows.Forms.PictureBox btnExit;
        private PiStoreManagementSystem.CustomComponents.CustomTextInput txtbMessage;
        private CustomComponents.CustomButton btnSend;
        private System.Windows.Forms.Panel panelChatBoxs;
        private CustomComponents.CustomButton btnSignOut;
        private CustomComponents.CustomButton btnNewGroupChat;
    }
}

