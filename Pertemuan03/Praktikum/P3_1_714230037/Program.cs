do {
    Console.Clear();

    Console.WriteLine("MENENTUKAN INDEKS PRESTASI MAHASISWA");
    Console.WriteLine("------------------------------------");
    Console.Write("Masukan Nama Mahasiswa: ");

    String nama = Console.ReadLine()!;

    Console.WriteLine("Masukan Nilai: ");

    int nilai = Convert.ToInt16(Console.ReadLine());

    String[] grade = { "A", "B", "C", "D" };

    if (nilai >= 85) {
        Console.WriteLine("Index nilai {0} adalah {1}", nama, grade[0]);
    } else if (nilai >= 70 && nilai < 85) {
        Console.WriteLine("Index nilai {0} adalah {1}", nama, grade[1]);
    } else if (nilai >= 60 && nilai < 70) {
        Console.WriteLine("Index nilai {0} adalah {1}", nama, grade[2]);
    } else {
        Console.WriteLine("Index nilai {0} adalah {1}", nama, grade[3]);
    }

    Console.Write("\nMasukan indeks yang ditampilkan: ");
    char indeks = Convert.ToChar(Console.ReadLine()!);
    Console.Write("indeks prestasi {0} adalah ", nama);

    prestasi(indeks);

    Console.Write("\ningin mengulang kembali(Y/T)?");

} while (Console.ReadLine() == "Y");

static void prestasi(char indeks) {
    switch (indeks) {
        case 'A':
            Console.WriteLine("sangat baik");
            break;
        case 'B':
            Console.WriteLine("baik");
            break;
        case 'C':
            Console.WriteLine("cukup");
            break;
        case 'D':
            Console.WriteLine("buruk");
            break;
        default:
            Console.WriteLine("invalid indeks prestasi");
            break;
    }
}
