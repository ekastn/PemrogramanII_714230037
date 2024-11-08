using System;
using System.Windows.Forms;

namespace P5_1_714230037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void HelloButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Hello World";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
