namespace P5_4_714230037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTampilkan_Click(object sender, EventArgs e)
        {
            var kelasDipilih = gb_kelas.Controls
                .OfType<CheckBox>()
                .Where(checkBox => checkBox.Checked)
                .Select(checkBox => checkBox.Text)
                .ToArray();

            if (kelasDipilih.Length == 0)
            {
                MessageBox.Show(
                    "Harus memilih salah satu dari pilihan kelas",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var jadwalDipilih = gb_jadwal.Controls
                .OfType<RadioButton>()
                .Where(radioBtn => radioBtn.Checked)
                .Select(radioBtn => radioBtn.Text)
                .ToArray();

            if (jadwalDipilih.Length == 0)
            {
                MessageBox.Show(
                    "Harus memilih salah satu dari pilihan jadwal",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string? nama = InputNama.Text;
            string? jenisKelamin = InputJenisKelamin.SelectedItem?.ToString();
            string? tanggalLahir = InputTanggalLahir.Value.ToString("dd MMM yyyy");
            string kelas = string.Join(", ", kelasDipilih);
            string jadwal = string.Join(", ", jadwalDipilih);

            if (nama == "" || jenisKelamin == null) { 
                MessageBox.Show(
                    "Harus mengisi semua input",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            MessageBox.Show(
                $"""
                Nama: {nama}
                Jenis Kelamin: {jenisKelamin}
                Tanggal Lahir: {tanggalLahir}
                Pilihan Kelas: {kelas}
                Pilihan Jadwal: {jadwal}
                """,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnSelesai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
