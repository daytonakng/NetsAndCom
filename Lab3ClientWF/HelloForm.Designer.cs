namespace Lab3ClientWF
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
            label1 = new Label();
            sendButton = new Button();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            localPortTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(215, 40);
            label1.Name = "label1";
            label1.Size = new Size(233, 67);
            label1.TabIndex = 55;
            label1.Text = "UDP Чат";
            // 
            // sendButton
            // 
            sendButton.Cursor = Cursors.Hand;
            sendButton.Location = new Point(244, 205);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(182, 29);
            sendButton.TabIndex = 54;
            sendButton.Text = "Продолжить";
            sendButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 142);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 53;
            label3.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 142);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 52;
            label2.Text = "Локальный порт:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(127, 165);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 27);
            nameTextBox.TabIndex = 50;
            // 
            // localPortTextBox
            // 
            localPortTextBox.Location = new Point(361, 165);
            localPortTextBox.Name = "localPortTextBox";
            localPortTextBox.Size = new Size(182, 27);
            localPortTextBox.TabIndex = 51;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 310);
            Controls.Add(label1);
            Controls.Add(sendButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(localPortTextBox);
            Name = "HelloForm";
            Text = "HelloForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button sendButton;
        private Label label3;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox localPortTextBox;
    }
}