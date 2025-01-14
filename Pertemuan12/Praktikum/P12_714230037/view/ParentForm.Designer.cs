namespace P12_714230037.view
{
    partial class ParentForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem = new ToolStripMenuItem();
            dataMahasiswaToolStripMenuItem = new ToolStripMenuItem();
            dataNilaiToolStripMenuItem = new ToolStripMenuItem();
            tugasWeek11ToolStripMenuItem = new ToolStripMenuItem();
            dataMasterBarangToolStripMenuItem = new ToolStripMenuItem();
            dataTransaksiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dataMahasiswaToolStripMenuItem, dataNilaiToolStripMenuItem, tugasWeek11ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(116, 26);
            dToolStripMenuItem.Text = "Exit";
            dToolStripMenuItem.Click += dToolStripMenuItem_Click;
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            dataMahasiswaToolStripMenuItem.Size = new Size(131, 24);
            dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            dataMahasiswaToolStripMenuItem.Click += dataMahasiswaToolStripMenuItem_Click;
            // 
            // dataNilaiToolStripMenuItem
            // 
            dataNilaiToolStripMenuItem.Name = "dataNilaiToolStripMenuItem";
            dataNilaiToolStripMenuItem.Size = new Size(90, 24);
            dataNilaiToolStripMenuItem.Text = "Data Nilai";
            dataNilaiToolStripMenuItem.Click += dataNilaiToolStripMenuItem_Click;
            // 
            // tugasWeek11ToolStripMenuItem
            // 
            tugasWeek11ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataMasterBarangToolStripMenuItem, dataTransaksiToolStripMenuItem });
            tugasWeek11ToolStripMenuItem.Name = "tugasWeek11ToolStripMenuItem";
            tugasWeek11ToolStripMenuItem.Size = new Size(156, 24);
            tugasWeek11ToolStripMenuItem.Text = "Tugas Pertemuan 11";
            // 
            // dataMasterBarangToolStripMenuItem
            // 
            dataMasterBarangToolStripMenuItem.Name = "dataMasterBarangToolStripMenuItem";
            dataMasterBarangToolStripMenuItem.Size = new Size(224, 26);
            dataMasterBarangToolStripMenuItem.Text = "Data Master Barang";
            dataMasterBarangToolStripMenuItem.Click += dataMasterBarangToolStripMenuItem_Click;
            // 
            // dataTransaksiToolStripMenuItem
            // 
            dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            dataTransaksiToolStripMenuItem.Size = new Size(224, 26);
            dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            dataTransaksiToolStripMenuItem.Click += dataTransaksiToolStripMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "ParentForm";
            FormClosing += ParentForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private ToolStripMenuItem dataNilaiToolStripMenuItem;
        private ToolStripMenuItem tugasWeek11ToolStripMenuItem;
        private ToolStripMenuItem dataMasterBarangToolStripMenuItem;
        private ToolStripMenuItem dataTransaksiToolStripMenuItem;
    }
}
