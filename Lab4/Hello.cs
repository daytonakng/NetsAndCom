
namespace Lab4
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
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

                    Chat chat = new Chat(name, localPort);
                    chat.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникло исключение: " + ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
