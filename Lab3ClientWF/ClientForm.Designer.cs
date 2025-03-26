namespace Lab3ClientWF
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
            clientPanel = new Panel();
            clientPortTextBox = new MaskedTextBox();
            label7 = new Label();
            nameTextBox = new TextBox();
            label5 = new Label();
            connectButton = new Button();
            label6 = new Label();
            clientIpTextBox = new MaskedTextBox();
            label3 = new Label();
            clientBox = new RichTextBox();
            sendButton = new Button();
            messageBox = new TextBox();
            clientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientPanel
            // 
            clientPanel.Controls.Add(clientPortTextBox);
            clientPanel.Controls.Add(label7);
            clientPanel.Controls.Add(nameTextBox);
            clientPanel.Controls.Add(label5);
            clientPanel.Controls.Add(connectButton);
            clientPanel.Controls.Add(label6);
            clientPanel.Controls.Add(clientIpTextBox);
            clientPanel.Controls.Add(label3);
            clientPanel.Location = new Point(677, 103);
            clientPanel.Name = "clientPanel";
            clientPanel.Size = new Size(434, 177);
            clientPanel.TabIndex = 48;
            // 
            // clientPortTextBox
            // 
            clientPortTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            clientPortTextBox.Location = new Point(230, 68);
            clientPortTextBox.Mask = "0000";
            clientPortTextBox.Name = "clientPortTextBox";
            clientPortTextBox.Size = new Size(182, 27);
            clientPortTextBox.TabIndex = 1;
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
            nameTextBox.TabIndex = 2;
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
            connectButton.TabIndex = 3;
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
            clientIpTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            clientIpTextBox.Location = new Point(19, 68);
            clientIpTextBox.Mask = "000.0.0.0";
            clientIpTextBox.Name = "clientIpTextBox";
            clientIpTextBox.Size = new Size(182, 27);
            clientIpTextBox.TabIndex = 0;
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
            // clientBox
            // 
            clientBox.BackColor = Color.White;
            clientBox.Location = new Point(12, 12);
            clientBox.Name = "clientBox";
            clientBox.ReadOnly = true;
            clientBox.Size = new Size(645, 360);
            clientBox.TabIndex = 51;
            clientBox.Text = "";
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(677, 399);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 5;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(12, 399);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(645, 27);
            messageBox.TabIndex = 4;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 443);
            Controls.Add(clientPanel);
            Controls.Add(clientBox);
            Controls.Add(sendButton);
            Controls.Add(messageBox);
            Name = "ClientForm";
            Text = "Form1";
            Load += ClientForm_Load;
            clientPanel.ResumeLayout(false);
            clientPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel clientPanel;
        private Label label7;
        private TextBox nameTextBox;
        private Label label5;
        private Button connectButton;
        private Label label6;
        private MaskedTextBox clientIpTextBox;
        private Label label3;
        private RichTextBox clientBox;
        private Button sendButton;
        private TextBox messageBox;
        private MaskedTextBox clientPortTextBox;
    }
}
