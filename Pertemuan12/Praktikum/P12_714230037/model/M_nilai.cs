using P12_714230037.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_714230037.model
{
    internal class M_nilai
    {
        string matkul, kategori, npm, nilai;

        public M_nilai()
        {
        }

        public M_nilai(string matkul, string kategori, string npm, string nilai)
        {
            this.matkul = matkul;
            this.kategori = kategori;
            this.npm = npm;
            this.nilai = nilai;
        }

        public string Matkul { get => matkul; set => matkul = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public string Npm { get => npm; set => npm = value; }
        public string Nilai { get => nilai; set => nilai = value; }
    }
}
