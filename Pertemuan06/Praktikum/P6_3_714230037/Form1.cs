using System.DirectoryServices;
using System.Linq.Expressions;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace P6_3_714230037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\na@b.c", "");
            }

        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Textbox angka 1 tidak boleh kosong!", "", "");
            }
            else if (txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka1, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox angka 2 tidak boleh kosong!", "", "");
            }
            else if (txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka2, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka2, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
            }
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            if (int.TryParse(txtAngka1.Text, out int angka1) && int.TryParse(txtAngka2.Text, out int angka2))
            {
                if (angka1 > angka2)
                {
                    SetErrorMessages(txtAngka1, "", "", "Betul!");
                    SetErrorMessages(txtAngka2, "", "", "Betul!");
                }
                else
                {
                    SetErrorMessages(txtAngka2, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                    SetErrorMessages(txtAngka1, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                }
            }
        }

    }
}
