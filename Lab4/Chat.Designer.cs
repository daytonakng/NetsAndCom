namespace Lab4
{
    partial class Chat
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
            chatBox = new RichTextBox();
            sendButton = new Button();
            label3 = new Label();
            label1 = new Label();
            ipTextBox = new MaskedTextBox();
            messageBox = new TextBox();
            remotePortTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // chatBox
            // 
            chatBox.BackColor = Color.White;
            chatBox.Location = new Point(19, 14);
            chatBox.Name = "chatBox";
            chatBox.ReadOnly = true;
            chatBox.Size = new Size(645, 235);
            chatBox.TabIndex = 53;
            chatBox.Text = "";
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(684, 276);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 3;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(684, 137);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 52;
            label3.Text = "Удаленный порт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 51;
            label1.Text = "IP-адрес:";
            // 
            // ipTextBox
            // 
            ipTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            ipTextBox.Location = new Point(684, 77);
            ipTextBox.Mask = "000.0.0.0";
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(182, 27);
            ipTextBox.TabIndex = 0;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(19, 276);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(645, 27);
            messageBox.TabIndex = 2;
            // 
            // remotePortTextBox
            // 
            remotePortTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            remotePortTextBox.Location = new Point(684, 160);
            remotePortTextBox.Mask = "0000";
            remotePortTextBox.Name = "remotePortTextBox";
            remotePortTextBox.Size = new Size(182, 27);
            remotePortTextBox.TabIndex = 1;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 319);
            Controls.Add(remotePortTextBox);
            Controls.Add(chatBox);
            Controls.Add(sendButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ipTextBox);
            Controls.Add(messageBox);
            Name = "Chat";
            Text = "Form1";
            FormClosed += Chat_FormClosed;
            Load += Chat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox chatBox;
        private Button sendButton;
        private Label label3;
        private Label label1;
        private MaskedTextBox ipTextBox;
        private TextBox messageBox;
        private MaskedTextBox remotePortTextBox;
    }
}
