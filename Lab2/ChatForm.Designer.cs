namespace Lab2
{
    partial class ChatForm
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
            chatBox = new RichTextBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            sendButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            remotePortTextBox = new TextBox();
            localPortTextBox = new TextBox();
            ipTextBox = new MaskedTextBox();
            messageBox = new TextBox();
            SuspendLayout();
            // 
            // chatBox
            // 
            chatBox.BackColor = Color.White;
            chatBox.Location = new Point(14, 12);
            chatBox.Name = "chatBox";
            chatBox.ReadOnly = true;
            chatBox.Size = new Size(645, 262);
            chatBox.TabIndex = 46;
            chatBox.Text = "";
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(679, 298);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 40;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 189);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 43;
            label3.Text = "Удаленный порт:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 117);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 42;
            label2.Text = "Локальный порт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(679, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 41;
            label1.Text = "IP-адрес:";
            // 
            // remotePortTextBox
            // 
            remotePortTextBox.Location = new Point(679, 212);
            remotePortTextBox.Name = "remotePortTextBox";
            remotePortTextBox.Size = new Size(182, 27);
            remotePortTextBox.TabIndex = 37;
            // 
            // localPortTextBox
            // 
            localPortTextBox.Location = new Point(679, 140);
            localPortTextBox.Name = "localPortTextBox";
            localPortTextBox.Size = new Size(182, 27);
            localPortTextBox.TabIndex = 34;
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(679, 75);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(182, 27);
            ipTextBox.TabIndex = 33;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(14, 298);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(645, 27);
            messageBox.TabIndex = 39;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 351);
            Controls.Add(chatBox);
            Controls.Add(sendButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(remotePortTextBox);
            Controls.Add(localPortTextBox);
            Controls.Add(ipTextBox);
            Controls.Add(messageBox);
            Name = "ChatForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox chatBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button sendButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox remotePortTextBox;
        private TextBox localPortTextBox;
        private MaskedTextBox ipTextBox;
        private TextBox messageBox;
    }
}
