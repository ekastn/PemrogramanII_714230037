do {
    Console.Clear();

    Console.WriteLine("=== MENU PERSEGI PANJANG ===");
    Console.WriteLine("1. Hitung Luas");
    Console.WriteLine("2. Hitung Keliling");
    Console.WriteLine("3. Keluar");

    Console.Write("Pilih menu (1-3): ");
    int menu = Convert.ToInt16(Console.ReadLine()!);

    switch (menu) {
        case 1:
            (double panjang, double lebar) = inputPersegi();
            double hasil = luasPersegi(panjang, lebar);
            Console.WriteLine($"Luas Persegi Panjang: {hasil}");
            break;
        case 2:
            (panjang, lebar) = inputPersegi();
            hasil = kelilingPersegi(panjang, lebar);
            Console.WriteLine($"Keliling Persegi Panjang: {hasil}");
            break;
        case 3:
            goto end;
        default:
            Console.WriteLine("Menu tidak tersedia, Silahkan pilih menu yang valid");
            break;
    }


    Console.Write("\ningin mengulang kembali(Y/T)? ");

} while (Console.ReadLine() == "Y");

end:

Console.WriteLine("Program selesai.");
Console.WriteLine("Terima kasih!");
Console.ReadKey();

static (double panjang, double lebar) inputPersegi() {
    Console.Write("Masukan panjang: ");
    double panjang = Convert.ToDouble(Console.ReadLine());
    Console.Write("Masukan lebar: ");
    double lebar = Convert.ToDouble(Console.ReadLine());
    return (panjang, lebar);
}

static double luasPersegi(double panjang, double lebar) {
    return panjang * lebar;
}

static double kelilingPersegi(double panjang, double lebar) {
    return 2 * (panjang + lebar);
}

