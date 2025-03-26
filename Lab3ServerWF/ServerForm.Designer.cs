namespace Lab3ServerWF
{
    partial class ServerForm
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
            serverPanel = new Panel();
            serverPortTextBox = new MaskedTextBox();
            startButton = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            serverIpTextBox = new MaskedTextBox();
            serverBox = new RichTextBox();
            serverPanel.SuspendLayout();
            SuspendLayout();
            // 
            // serverPanel
            // 
            serverPanel.Controls.Add(serverPortTextBox);
            serverPanel.Controls.Add(startButton);
            serverPanel.Controls.Add(label4);
            serverPanel.Controls.Add(label2);
            serverPanel.Controls.Add(label1);
            serverPanel.Controls.Add(serverIpTextBox);
            serverPanel.Location = new Point(678, 102);
            serverPanel.Name = "serverPanel";
            serverPanel.Size = new Size(434, 177);
            serverPanel.TabIndex = 48;
            // 
            // serverPortTextBox
            // 
            serverPortTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            serverPortTextBox.Location = new Point(230, 70);
            serverPortTextBox.Mask = "0000";
            serverPortTextBox.Name = "serverPortTextBox";
            serverPortTextBox.Size = new Size(182, 27);
            serverPortTextBox.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.Cursor = Cursors.Hand;
            startButton.Location = new Point(128, 125);
            startButton.Name = "startButton";
            startButton.Size = new Size(182, 29);
            startButton.TabIndex = 2;
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
            // serverIpTextBox
            // 
            serverIpTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            serverIpTextBox.Location = new Point(19, 70);
            serverIpTextBox.Mask = "000.0.0.0";
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(182, 27);
            serverIpTextBox.TabIndex = 0;
            // 
            // serverBox
            // 
            serverBox.BackColor = Color.White;
            serverBox.Location = new Point(12, 12);
            serverBox.Name = "serverBox";
            serverBox.ReadOnly = true;
            serverBox.Size = new Size(645, 360);
            serverBox.TabIndex = 49;
            serverBox.Text = "";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 401);
            Controls.Add(serverPanel);
            Controls.Add(serverBox);
            Name = "ServerForm";
            Text = "Form1";
            FormClosed += ServerForm_FormClosed;
            Load += ServerForm_Load;
            serverPanel.ResumeLayout(false);
            serverPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel serverPanel;
        private Button startButton;
        private Label label4;
        private Label label2;
        private Label label1;
        private MaskedTextBox serverIpTextBox;
        private RichTextBox serverBox;
        private MaskedTextBox serverPortTextBox;
    }
}
