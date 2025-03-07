namespace Lab2
{
    partial class HelloForm
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
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            localPortTextBox = new TextBox();
            sendButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 127);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 47;
            label3.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 127);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 46;
            label2.Text = "Локальный порт:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(98, 150);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 27);
            nameTextBox.TabIndex = 45;
            // 
            // localPortTextBox
            // 
            localPortTextBox.Location = new Point(332, 150);
            localPortTextBox.Name = "localPortTextBox";
            localPortTextBox.Size = new Size(182, 27);
            localPortTextBox.TabIndex = 44;
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(215, 190);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 48;
            sendButton.Text = "Продолжить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(186, 25);
            label1.Name = "label1";
            label1.Size = new Size(233, 67);
            label1.TabIndex = 49;
            label1.Text = "UDP Чат";
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 256);
            Controls.Add(label1);
            Controls.Add(sendButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(localPortTextBox);
            Name = "HelloForm";
            Text = "HelloForm";
            Load += HelloForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox localPortTextBox;
        private Button sendButton;
        private Label label1;
    }
}