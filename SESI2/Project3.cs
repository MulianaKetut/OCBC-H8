using System;

class Project3
{
    public static void Main(string[] args)
    {
        string nama;
        int umur;
        string alamat;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");

        //input
        Console.Write("Masukan Nama: ");
        nama = Console.ReadLine();

        Console.Write("Masukan Alamat: ");
        alamat = Console.ReadLine();

        Console.Write("Masukan Umur: ");
        umur = int.Parse(Console.ReadLine());

        //print
        Console.WriteLine();
        Console.WriteLine("Terima Kasih");
        Console.WriteLine("Data Berikut:");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur} tahun");
        Console.WriteLine("DATA BERHASIL DISIMPAN!");
    }
}