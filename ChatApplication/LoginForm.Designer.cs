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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new ChatApplication.CustomComponents.CustomButton();
            this.btnSignUp = new ChatApplication.CustomComponents.CustomButton();
            this.customTextInput1 = new ChatApplication.CustomComponents.CustomTextInput();
            this.customTextInput2 = new ChatApplication.CustomComponents.CustomTextInput();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatApplication.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(42, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::ChatApplication.Properties.Resources.reject;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(347, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChatApplication.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(42, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignIn.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignIn.BorderRadius = 5;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.ClickColor = System.Drawing.Color.Navy;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(218, 408);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 40);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextColor = System.Drawing.Color.White;
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.BorderRadius = 5;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.ClickColor = System.Drawing.Color.Navy;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(65, 408);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 40);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // customTextInput1
            // 
            this.customTextInput1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextInput1.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.customTextInput1.BorderFocusColor = System.Drawing.Color.Navy;
            this.customTextInput1.BorderRadius = 5;
            this.customTextInput1.BorderSize = 2;
            this.customTextInput1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextInput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextInput1.Location = new System.Drawing.Point(81, 290);
            this.customTextInput1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextInput1.Multiline = false;
            this.customTextInput1.Name = "customTextInput1";
            this.customTextInput1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextInput1.PasswordChar = false;
            this.customTextInput1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextInput1.PlaceholderText = "";
            this.customTextInput1.Size = new System.Drawing.Size(260, 37);
            this.customTextInput1.TabIndex = 9;
            this.customTextInput1.Texts = "";
            this.customTextInput1.UnderlinedStyle = false;
            // 
            // customTextInput2
            // 
            this.customTextInput2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextInput2.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.customTextInput2.BorderFocusColor = System.Drawing.Color.Navy;
            this.customTextInput2.BorderRadius = 5;
            this.customTextInput2.BorderSize = 2;
            this.customTextInput2.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextInput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextInput2.Location = new System.Drawing.Point(81, 340);
            this.customTextInput2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextInput2.Multiline = false;
            this.customTextInput2.Name = "customTextInput2";
            this.customTextInput2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextInput2.PasswordChar = false;
            this.customTextInput2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextInput2.PlaceholderText = "";
            this.customTextInput2.Size = new System.Drawing.Size(260, 37);
            this.customTextInput2.TabIndex = 10;
            this.customTextInput2.Texts = "";
            this.customTextInput2.UnderlinedStyle = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 572);
            this.Controls.Add(this.customTextInput2);
            this.Controls.Add(this.customTextInput1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomComponents.CustomButton btnSignIn;
        private CustomComponents.CustomButton btnSignUp;
        private CustomComponents.CustomTextInput customTextInput1;
        private CustomComponents.CustomTextInput customTextInput2;
    }
}