
namespace ASD_chatter
{
    partial class Chatter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.ltbChatLog = new System.Windows.Forms.ListBox();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(493, 418);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.send_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(493, 383);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.connect_Click);
            // 
            // ltbChatLog
            // 
            this.ltbChatLog.FormattingEnabled = true;
            this.ltbChatLog.ItemHeight = 20;
            this.ltbChatLog.Location = new System.Drawing.Point(12, 12);
            this.ltbChatLog.Name = "ltbChatLog";
            this.ltbChatLog.Size = new System.Drawing.Size(573, 324);
            this.ltbChatLog.TabIndex = 3;
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(12, 402);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(475, 27);
            this.txtMessageBox.TabIndex = 4;
            // 
            // Chatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 459);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.ltbChatLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Name = "Chatter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox ltbChatLog;
        private System.Windows.Forms.TextBox txtMessageBox;
    }
}

