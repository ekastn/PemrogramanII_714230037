namespace P13_714230037.view
{
    partial class FormNilai
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
            DataNilai = new DataGridView();
            gbFormNilai = new GroupBox();
            textBoxNama = new TextBox();
            textBoxNilai = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxNPM = new ComboBox();
            comboBoxKategori = new ComboBox();
            comboBoxMatkul = new ComboBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBoxCariData = new TextBox();
            groupBox2 = new GroupBox();
            buttonHapus = new Button();
            buttonUbah = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            groupBox3 = new GroupBox();
            buttonExportExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)DataNilai).BeginInit();
            gbFormNilai.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DataNilai
            // 
            DataNilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataNilai.Location = new Point(30, 36);
            DataNilai.Name = "DataNilai";
            DataNilai.RightToLeft = RightToLeft.No;
            DataNilai.RowHeadersWidth = 51;
            DataNilai.Size = new Size(685, 250);
            DataNilai.TabIndex = 0;
            DataNilai.CellClick += DataNilai_CellClick;
            // 
            // gbFormNilai
            // 
            gbFormNilai.Controls.Add(textBoxNama);
            gbFormNilai.Controls.Add(textBoxNilai);
            gbFormNilai.Controls.Add(label4);
            gbFormNilai.Controls.Add(label3);
            gbFormNilai.Controls.Add(label2);
            gbFormNilai.Controls.Add(label1);
            gbFormNilai.Controls.Add(comboBoxNPM);
            gbFormNilai.Controls.Add(comboBoxKategori);
            gbFormNilai.Controls.Add(comboBoxMatkul);
            gbFormNilai.Location = new Point(28, 358);
            gbFormNilai.Name = "gbFormNilai";
            gbFormNilai.Size = new Size(333, 357);
            gbFormNilai.TabIndex = 1;
            gbFormNilai.TabStop = false;
            gbFormNilai.Text = "Form Input Nilai";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(154, 166);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(151, 27);
            textBoxNama.TabIndex = 8;
            // 
            // textBoxNilai
            // 
            textBoxNilai.Location = new Point(154, 222);
            textBoxNilai.Name = "textBoxNilai";
            textBoxNilai.Size = new Size(151, 27);
            textBoxNilai.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 225);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 6;
            label4.Text = "Nilai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 135);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "NPM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Matkul";
            // 
            // comboBoxNPM
            // 
            comboBoxNPM.FormattingEnabled = true;
            comboBoxNPM.Location = new Point(154, 132);
            comboBoxNPM.Name = "comboBoxNPM";
            comboBoxNPM.Size = new Size(151, 28);
            comboBoxNPM.TabIndex = 2;
            comboBoxNPM.SelectedIndexChanged += comboBoxNPM_SelectedIndexChanged;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Items.AddRange(new object[] { "ATS", "AAS" });
            comboBoxKategori.Location = new Point(154, 83);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(151, 28);
            comboBoxKategori.TabIndex = 1;
            // 
            // comboBoxMatkul
            // 
            comboBoxMatkul.FormattingEnabled = true;
            comboBoxMatkul.Items.AddRange(new object[] { "Pemrograman I", "Pemrograman II", "Pemrograman III", "Pemrograman IV", "Literasi Data", "Sistem ERP", "RPL", "Metodologi Penelitian", "PKN", "General English I" });
            comboBoxMatkul.Location = new Point(154, 37);
            comboBoxMatkul.Name = "comboBoxMatkul";
            comboBoxMatkul.Size = new Size(151, 28);
            comboBoxMatkul.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonExportExcel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxCariData);
            groupBox1.Location = new Point(377, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 118);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Pencarian";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 41);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Cari Data";
            // 
            // textBoxCariData
            // 
            textBoxCariData.Location = new Point(142, 38);
            textBoxCariData.Name = "textBoxCariData";
            textBoxCariData.Size = new Size(218, 27);
            textBoxCariData.TabIndex = 8;
            textBoxCariData.TextChanged += textBoxCariData_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonHapus);
            groupBox2.Controls.Add(buttonUbah);
            groupBox2.Controls.Add(buttonSimpan);
            groupBox2.Controls.Add(buttonRefresh);
            groupBox2.Location = new Point(377, 482);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 233);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tombol Action";
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(31, 175);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(329, 29);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonUbah
            // 
            buttonUbah.Location = new Point(31, 133);
            buttonUbah.Name = "buttonUbah";
            buttonUbah.Size = new Size(329, 29);
            buttonUbah.TabIndex = 2;
            buttonUbah.Text = "Ubah";
            buttonUbah.UseVisualStyleBackColor = true;
            buttonUbah.Click += buttonUbah_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(31, 88);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(329, 29);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(31, 46);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(329, 29);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DataNilai);
            groupBox3.Location = new Point(22, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(744, 320);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Table Data Nilai";
            // 
            // buttonExportExcel
            // 
            buttonExportExcel.Location = new Point(142, 73);
            buttonExportExcel.Name = "buttonExportExcel";
            buttonExportExcel.Size = new Size(218, 29);
            buttonExportExcel.TabIndex = 4;
            buttonExportExcel.Text = "Export Excel";
            buttonExportExcel.UseVisualStyleBackColor = true;
            buttonExportExcel.Click += buttonExportExcel_Click;
            // 
            // FormNilai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 755);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbFormNilai);
            Name = "FormNilai";
            Text = "FormNilai";
            Load += FormNilai_Load;
            ((System.ComponentModel.ISupportInitialize)DataNilai).EndInit();
            gbFormNilai.ResumeLayout(false);
            gbFormNilai.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataNilai;
        private GroupBox gbFormNilai;
        private Label label1;
        private ComboBox comboBoxNPM;
        private ComboBox comboBoxKategori;
        private ComboBox comboBoxMatkul;
        private TextBox textBoxNilai;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBoxCariData;
        private GroupBox groupBox2;
        private Button buttonHapus;
        private Button buttonUbah;
        private Button buttonSimpan;
        private Button buttonRefresh;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox textBoxNama;
        private Button buttonExportExcel;
    }
}