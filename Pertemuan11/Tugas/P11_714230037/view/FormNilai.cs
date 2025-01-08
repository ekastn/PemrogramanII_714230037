using MySql.Data.MySqlClient;
using P11_714230037.controller;
using P11_714230037.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P11_714230037.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_nilai m_nilai = new M_nilai();
        string id_nilai;

        public FormNilai()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }

        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                int npm = reader.GetInt32("npm");
                comboBoxNPM.Items.Add(npm);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxMatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxKategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxNPM.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " + "WHERE t_nilai.npm LIKE '%' '" + textBoxCariData.Text + "' '%' " + "OR nama LIKE '%' '" + textBoxCariData.Text + "' '%'" + "OR matkul LIKE '%' '" + textBoxCariData.Text + "' '%'");
        }

        private void comboBoxNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        public void GetNamaMhs()
        {
            //ambil data nama ketika combobox npm dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + comboBoxNPM.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBoxNama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void ResetForm()
        {
            comboBoxMatkul.SelectedIndex = -1;
            comboBoxKategori.SelectedIndex = -1;
            comboBoxNPM.SelectedIndex = -1;
            textBoxNilai.Text = "";
            textBoxNama.Text = "";
            textBoxCariData.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxMatkul.SelectedIndex == -1 ||
                comboBoxKategori.SelectedIndex == -1 ||
                comboBoxNPM.SelectedIndex == -1 ||
                textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = comboBoxMatkul.Text;
                m_nilai.Kategori = comboBoxKategori.Text;
                m_nilai.Npm = comboBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;

                nilai.Insert(m_nilai);
                ResetForm();
                Tampil();
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (comboBoxMatkul.SelectedIndex == -1 ||
                comboBoxKategori.SelectedIndex == -1 ||
                comboBoxNPM.SelectedIndex == -1 ||
                textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = comboBoxMatkul.Text;
                m_nilai.Kategori = comboBoxKategori.Text;
                m_nilai.Npm = comboBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;

                nilai.Update(m_nilai, id_nilai);
                ResetForm();
                Tampil();
            }

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
            }
            ResetForm();
            Tampil();
        }
    }
}
