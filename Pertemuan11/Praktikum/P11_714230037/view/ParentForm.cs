using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714230037.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void dataNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai form = new FormNilai();
            form.MdiParent = this;
            form.Show();
        }
    }
}
