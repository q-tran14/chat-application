namespace ChatApplication.CustomComponents
{
    partial class ChatBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labUsername = new System.Windows.Forms.Label();
            this.picAva = new System.Windows.Forms.PictureBox();
            this.labLastedMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.Location = new System.Drawing.Point(71, 10);
            this.labUsername.MaximumSize = new System.Drawing.Size(142, 22);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(88, 22);
            this.labUsername.TabIndex = 1;
            this.labUsername.Text = "Username";
            // 
            // picAva
            // 
            this.picAva.Image = global::ChatApplication.Properties.Resources.user;
            this.picAva.Location = new System.Drawing.Point(10, 10);
            this.picAva.Name = "picAva";
            this.picAva.Size = new System.Drawing.Size(40, 40);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAva.TabIndex = 0;
            this.picAva.TabStop = false;
            // 
            // labLastedMessage
            // 
            this.labLastedMessage.AutoSize = true;
            this.labLastedMessage.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLastedMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labLastedMessage.Location = new System.Drawing.Point(72, 32);
            this.labLastedMessage.MaximumSize = new System.Drawing.Size(142, 0);
            this.labLastedMessage.Name = "labLastedMessage";
            this.labLastedMessage.Size = new System.Drawing.Size(141, 18);
            this.labLastedMessage.TabIndex = 2;
            this.labLastedMessage.Text = "Lasted Message ............";
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labLastedMessage);
            this.Controls.Add(this.labUsername);
            this.Controls.Add(this.picAva);
            this.MaximumSize = new System.Drawing.Size(225, 60);
            this.Name = "ChatBox";
            this.Size = new System.Drawing.Size(225, 60);
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAva;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.Label labLastedMessage;
    }
}
