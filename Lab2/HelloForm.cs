﻿
namespace Lab2
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null && localPortTextBox.Text == null)
            {
                MessageBox.Show("Имя и(или) локальный порт не заданы\nЗаполните поля и повторите попытку!");
            }
            else
            {
                try
                {
                    string name = nameTextBox.Text;
                    int localPort = int.Parse(localPortTextBox.Text);

                    ChatForm chatForm = new ChatForm(name, localPort);
                    chatForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникло исключение: " + ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
