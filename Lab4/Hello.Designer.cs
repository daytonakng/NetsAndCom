namespace Lab4
{
    partial class Hello
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
            nextButton = new Button();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            localPortTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(188, 31);
            label1.Name = "label1";
            label1.Size = new Size(233, 67);
            label1.TabIndex = 55;
            label1.Text = "UDP Чат";
            // 
            // nextButton
            // 
            nextButton.Cursor = Cursors.Hand;
            nextButton.Location = new Point(217, 196);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(182, 29);
            nextButton.TabIndex = 2;
            nextButton.Text = "Продолжить";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 133);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 53;
            label3.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 133);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 52;
            label2.Text = "Локальный порт:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(100, 156);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 27);
            nameTextBox.TabIndex = 0;
            nameTextBox.Text = "user";
            // 
            // localPortTextBox
            // 
            localPortTextBox.Culture = new System.Globalization.CultureInfo("en-EN");
            localPortTextBox.Location = new Point(334, 156);
            localPortTextBox.Mask = "0000";
            localPortTextBox.Name = "localPortTextBox";
            localPortTextBox.Size = new Size(182, 27);
            localPortTextBox.TabIndex = 1;
            localPortTextBox.Text = "5001";
            // 
            // Hello
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 256);
            Controls.Add(localPortTextBox);
            Controls.Add(label1);
            Controls.Add(nextButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Name = "Hello";
            Text = "Hello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button nextButton;
        private Label label3;
        private Label label2;
        private TextBox nameTextBox;
        private MaskedTextBox localPortTextBox;
    }
}