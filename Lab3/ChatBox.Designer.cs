namespace Lab3
{
    partial class ChatBox
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
            connectButton = new Button();
            startButton = new Button();
            label6 = new Label();
            clientIpTextBox = new MaskedTextBox();
            label4 = new Label();
            sendButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            clientPortTextBox = new TextBox();
            serverPortTextBox = new TextBox();
            serverIpTextBox = new MaskedTextBox();
            messageBox = new TextBox();
            chatTCPBox = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            SuspendLayout();
            // 
            // connectButton
            // 
            connectButton.Cursor = Cursors.Hand;
            connectButton.Location = new Point(888, 293);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(182, 29);
            connectButton.TabIndex = 6;
            connectButton.Text = "Соединить";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // startButton
            // 
            startButton.Cursor = Cursors.Hand;
            startButton.Location = new Point(888, 108);
            startButton.Name = "startButton";
            startButton.Size = new Size(182, 29);
            startButton.TabIndex = 3;
            startButton.Text = "Запуск";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(677, 235);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 27;
            label6.Text = "IP-адрес:";
            // 
            // clientIpTextBox
            // 
            clientIpTextBox.Location = new Point(677, 258);
            clientIpTextBox.Name = "clientIpTextBox";
            clientIpTextBox.Size = new Size(182, 27);
            clientIpTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(677, 15);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 24;
            label4.Text = "Сервер";
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(677, 401);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 8;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(677, 302);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 22;
            label3.Text = "Порт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(677, 117);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 21;
            label2.Text = "Порт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 20;
            label1.Text = "IP-адрес:";
            // 
            // clientPortTextBox
            // 
            clientPortTextBox.Location = new Point(677, 325);
            clientPortTextBox.Name = "clientPortTextBox";
            clientPortTextBox.Size = new Size(182, 27);
            clientPortTextBox.TabIndex = 5;
            // 
            // serverPortTextBox
            // 
            serverPortTextBox.Location = new Point(677, 140);
            serverPortTextBox.Name = "serverPortTextBox";
            serverPortTextBox.Size = new Size(182, 27);
            serverPortTextBox.TabIndex = 1;
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(677, 75);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(182, 27);
            serverIpTextBox.TabIndex = 0;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(12, 401);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(645, 27);
            messageBox.TabIndex = 7;
            messageBox.KeyDown += messageBox_KeyDown;
            // 
            // chatTCPBox
            // 
            chatTCPBox.BackColor = Color.White;
            chatTCPBox.Location = new Point(12, 12);
            chatTCPBox.Name = "chatTCPBox";
            chatTCPBox.ReadOnly = true;
            chatTCPBox.Size = new Size(645, 360);
            chatTCPBox.TabIndex = 30;
            chatTCPBox.Text = "";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(677, 204);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 32;
            label5.Text = "Клиент";
            // 
            // ChatBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 443);
            Controls.Add(label5);
            Controls.Add(chatTCPBox);
            Controls.Add(connectButton);
            Controls.Add(startButton);
            Controls.Add(label6);
            Controls.Add(clientIpTextBox);
            Controls.Add(label4);
            Controls.Add(sendButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clientPortTextBox);
            Controls.Add(serverPortTextBox);
            Controls.Add(serverIpTextBox);
            Controls.Add(messageBox);
            Name = "ChatBox";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectButton;
        private Button startButton;
        private Label label6;
        private MaskedTextBox clientIpTextBox;
        private Label label4;
        private Button sendButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox clientPortTextBox;
        private TextBox serverPortTextBox;
        private MaskedTextBox serverIpTextBox;
        private RichTextBox chatBox;
        private TextBox messageBox;
        private RichTextBox chatTCPBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label5;
    }
}
