namespace ChatApplication.CustomComponents
{
    partial class MessageBox
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
            this.tLPMessageBox = new System.Windows.Forms.TableLayoutPanel();
            this.labTimeStamp = new System.Windows.Forms.Label();
            this.labMessage = new System.Windows.Forms.Label();
            this.tLPMessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMessageBox
            // 
            this.tLPMessageBox.ColumnCount = 1;
            this.tLPMessageBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMessageBox.Controls.Add(this.labMessage, 0, 0);
            this.tLPMessageBox.Controls.Add(this.labTimeStamp, 0, 1);
            this.tLPMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMessageBox.Location = new System.Drawing.Point(0, 0);
            this.tLPMessageBox.Name = "tLPMessageBox";
            this.tLPMessageBox.RowCount = 2;
            this.tLPMessageBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMessageBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLPMessageBox.Size = new System.Drawing.Size(450, 80);
            this.tLPMessageBox.TabIndex = 0;
            // 
            // labTimeStamp
            // 
            this.labTimeStamp.AutoSize = true;
            this.labTimeStamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTimeStamp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimeStamp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labTimeStamp.Location = new System.Drawing.Point(8, 58);
            this.labTimeStamp.Margin = new System.Windows.Forms.Padding(8);
            this.labTimeStamp.Name = "labTimeStamp";
            this.labTimeStamp.Size = new System.Drawing.Size(434, 14);
            this.labTimeStamp.TabIndex = 0;
            this.labTimeStamp.Text = "07/04/2025 4:52";
            this.labTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMessage.Location = new System.Drawing.Point(8, 8);
            this.labMessage.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(434, 42);
            this.labMessage.TabIndex = 1;
            this.labMessage.Text = "Hello World !!!hhhhhhh hhhhhhhhhhhhhhh hhhhhhh hhhh hhhhhh hhhhhhhh h";
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tLPMessageBox);
            this.MaximumSize = new System.Drawing.Size(450, 0);
            this.MinimumSize = new System.Drawing.Size(150, 60);
            this.Name = "MessageBox";
            this.Size = new System.Drawing.Size(450, 80);
            this.tLPMessageBox.ResumeLayout(false);
            this.tLPMessageBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMessageBox;
        private System.Windows.Forms.Label labTimeStamp;
        private System.Windows.Forms.Label labMessage;
    }
}
