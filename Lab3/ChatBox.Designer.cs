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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            mainPanel = new Panel();
            clientPanel = new Panel();
            label7 = new Label();
            nameTextBox = new TextBox();
            label5 = new Label();
            connectButton = new Button();
            label6 = new Label();
            clientIpTextBox = new MaskedTextBox();
            label3 = new Label();
            clientPortTextBox = new TextBox();
            serverPanel = new Panel();
            startButton = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            serverPortTextBox = new TextBox();
            serverIpTextBox = new MaskedTextBox();
            chatTCPBox = new RichTextBox();
            sendButton = new Button();
            messageBox = new TextBox();
            serverClientPanel = new GroupBox();
            clientRB = new RadioButton();
            serverRB = new RadioButton();
            mainPanel.SuspendLayout();
            clientPanel.SuspendLayout();
            serverPanel.SuspendLayout();
            serverClientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(clientPanel);
            mainPanel.Controls.Add(serverPanel);
            mainPanel.Controls.Add(chatTCPBox);
            mainPanel.Controls.Add(sendButton);
            mainPanel.Controls.Add(messageBox);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1143, 453);
            mainPanel.TabIndex = 37;
            // 
            // clientPanel
            // 
            clientPanel.Controls.Add(label7);
            clientPanel.Controls.Add(nameTextBox);
            clientPanel.Controls.Add(label5);
            clientPanel.Controls.Add(connectButton);
            clientPanel.Controls.Add(label6);
            clientPanel.Controls.Add(clientIpTextBox);
            clientPanel.Controls.Add(label3);
            clientPanel.Controls.Add(clientPortTextBox);
            clientPanel.Location = new Point(676, 194);
            clientPanel.Name = "clientPanel";
            clientPanel.Size = new Size(434, 177);
            clientPanel.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 110);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 58;
            label7.Text = "Имя:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(19, 133);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 27);
            nameTextBox.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 14);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 56;
            label5.Text = "Клиент";
            // 
            // connectButton
            // 
            connectButton.Cursor = Cursors.Hand;
            connectButton.Location = new Point(230, 133);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(182, 29);
            connectButton.TabIndex = 53;
            connectButton.Text = "Соединить";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 45);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 55;
            label6.Text = "IP-адрес:";
            // 
            // clientIpTextBox
            // 
            clientIpTextBox.Location = new Point(19, 68);
            clientIpTextBox.Name = "clientIpTextBox";
            clientIpTextBox.Size = new Size(182, 27);
            clientIpTextBox.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 45);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 54;
            label3.Text = "Порт:";
            // 
            // clientPortTextBox
            // 
            clientPortTextBox.Location = new Point(230, 68);
            clientPortTextBox.Name = "clientPortTextBox";
            clientPortTextBox.Size = new Size(182, 27);
            clientPortTextBox.TabIndex = 52;
            // 
            // serverPanel
            // 
            serverPanel.Controls.Add(startButton);
            serverPanel.Controls.Add(label4);
            serverPanel.Controls.Add(label2);
            serverPanel.Controls.Add(label1);
            serverPanel.Controls.Add(serverPortTextBox);
            serverPanel.Controls.Add(serverIpTextBox);
            serverPanel.Location = new Point(676, 11);
            serverPanel.Name = "serverPanel";
            serverPanel.Size = new Size(434, 177);
            serverPanel.TabIndex = 39;
            // 
            // startButton
            // 
            startButton.Cursor = Cursors.Hand;
            startButton.Location = new Point(128, 125);
            startButton.Name = "startButton";
            startButton.Size = new Size(182, 29);
            startButton.TabIndex = 48;
            startButton.Text = "Запуск";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 10);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 51;
            label4.Text = "Сервер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 47);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 50;
            label2.Text = "Порт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 49;
            label1.Text = "IP-адрес:";
            // 
            // serverPortTextBox
            // 
            serverPortTextBox.Location = new Point(230, 70);
            serverPortTextBox.Name = "serverPortTextBox";
            serverPortTextBox.Size = new Size(182, 27);
            serverPortTextBox.TabIndex = 47;
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(19, 70);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(182, 27);
            serverIpTextBox.TabIndex = 46;
            // 
            // chatTCPBox
            // 
            chatTCPBox.BackColor = Color.White;
            chatTCPBox.Location = new Point(11, 11);
            chatTCPBox.Name = "chatTCPBox";
            chatTCPBox.ReadOnly = true;
            chatTCPBox.Size = new Size(645, 360);
            chatTCPBox.TabIndex = 47;
            chatTCPBox.Text = "";
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(676, 398);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 41;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(11, 398);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(645, 27);
            messageBox.TabIndex = 40;
            messageBox.KeyDown += messageBox_KeyDown;
            // 
            // serverClientPanel
            // 
            serverClientPanel.Controls.Add(clientRB);
            serverClientPanel.Controls.Add(serverRB);
            serverClientPanel.Location = new Point(1184, 146);
            serverClientPanel.Name = "serverClientPanel";
            serverClientPanel.Size = new Size(183, 125);
            serverClientPanel.TabIndex = 38;
            serverClientPanel.TabStop = false;
            serverClientPanel.Text = "Сервер/клиент?";
            // 
            // clientRB
            // 
            clientRB.AutoSize = true;
            clientRB.Location = new Point(51, 65);
            clientRB.Name = "clientRB";
            clientRB.Size = new Size(79, 24);
            clientRB.TabIndex = 37;
            clientRB.TabStop = true;
            clientRB.Text = "Клиент";
            clientRB.UseVisualStyleBackColor = true;
            clientRB.CheckedChanged += clientRB_CheckedChanged;
            // 
            // serverRB
            // 
            serverRB.AutoSize = true;
            serverRB.Location = new Point(51, 35);
            serverRB.Name = "serverRB";
            serverRB.Size = new Size(81, 24);
            serverRB.TabIndex = 36;
            serverRB.TabStop = true;
            serverRB.Text = "Сервер";
            serverRB.UseVisualStyleBackColor = true;
            serverRB.CheckedChanged += serverRB_CheckedChanged;
            // 
            // ChatBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 478);
            Controls.Add(mainPanel);
            Controls.Add(serverClientPanel);
            Name = "ChatBox";
            Text = "Передача закодированной информации. TCP";
            Load += ChatBox_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            clientPanel.ResumeLayout(false);
            clientPanel.PerformLayout();
            serverPanel.ResumeLayout(false);
            serverPanel.PerformLayout();
            serverClientPanel.ResumeLayout(false);
            serverClientPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox chatBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel mainPanel;
        private GroupBox serverClientPanel;
        private RichTextBox chatTCPBox;
        private Button sendButton;
        private TextBox messageBox;
        private RadioButton clientRB;
        private RadioButton serverRB;
        private Panel serverPanel;
        private Button startButton;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox serverPortTextBox;
        private MaskedTextBox serverIpTextBox;
        private Panel clientPanel;
        private Label label7;
        private TextBox nameTextBox;
        private Label label5;
        private Button connectButton;
        private Label label6;
        private MaskedTextBox clientIpTextBox;
        private Label label3;
        private TextBox clientPortTextBox;
    }
}
