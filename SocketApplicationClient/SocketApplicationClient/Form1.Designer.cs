namespace SocketApplicationClient
{
    partial class frmClient
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Client Socket Program -";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 38);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(110, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Message from Server:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 172);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(133, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Type your message below:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(395, 296);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(15, 54);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(455, 103);
            this.txtServer.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 188);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(455, 102);
            this.txtMessage.TabIndex = 5;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 331);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmClient";
            this.Text = "Chat Application - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

