namespace TcpClient
{
    partial class ClientForm
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
            label1 = new Label();
            txtIP = new TextBox();
            btnConnect = new Button();
            txtinfo = new TextBox();
            txtMessage = new TextBox();
            label2 = new Label();
            btnSend = new Button();
            label3 = new Label();
            lstClientIP = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 80);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Server:";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(120, 80);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(302, 31);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:8080";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(444, 80);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(99, 36);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtinfo
            // 
            txtinfo.Location = new Point(120, 134);
            txtinfo.Multiline = true;
            txtinfo.Name = "txtinfo";
            txtinfo.ReadOnly = true;
            txtinfo.ScrollBars = ScrollBars.Both;
            txtinfo.Size = new Size(423, 195);
            txtinfo.TabIndex = 4;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(120, 351);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(423, 31);
            txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 351);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 5;
            label2.Text = "Message:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(447, 401);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(96, 36);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 82);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 11;
            label3.Text = "Client IP:";
            // 
            // lstClientIP
            // 
            lstClientIP.FormattingEnabled = true;
            lstClientIP.ItemHeight = 25;
            lstClientIP.Location = new Point(557, 134);
            lstClientIP.Name = "lstClientIP";
            lstClientIP.Size = new Size(216, 254);
            lstClientIP.TabIndex = 10;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 571);
            Controls.Add(label3);
            Controls.Add(lstClientIP);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(txtinfo);
            Controls.Add(btnConnect);
            Controls.Add(txtIP);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tcp/IP Client";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button btnConnect;
        private TextBox txtinfo;
        private TextBox txtMessage;
        private Label label2;
        private Button btnSend;
        private Label label3;
        private ListBox lstClientIP;
    }
}