using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomMessageBox : Form
    {
        public bool Continue { get; private set; }

        public CustomMessageBox(string message)
        {
            InitializeComponent();
            labelInfo.Text = message; // Установка текста сообщения
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Continue = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Continue = false;
            this.Close();
        }
    }
}