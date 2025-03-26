using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3ClientWF
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null)
            {
                MessageBox.Show("Имя не задано\nЗаполните поле и повторите попытку!");
            }
            else
            {
                try
                {
                    string name = nameTextBox.Text;

                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
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
