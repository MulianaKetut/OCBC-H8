using System;

class HitungNilai
{
    public static void Main(string[] args)
    {
        int pertama, kedua, ketiga, total;
        double avg;

        Console.WriteLine("=== Menghitung Nilai ===");
        Console.Write("Masukan Nilai Pertama: ");
        pertama = int.Parse(Console.ReadLine());

        Console.Write("Masukan Nilai Kedua: ");
        kedua = int.Parse(Console.ReadLine());

        Console.Write("Masukan Nilai Ketiga: ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        avg = total / 3.0;

        Console.WriteLine("Total Nilai adalah: " + total);
        Console.WriteLine("Rata-rata Nilai adalah: " + avg);
        Console.Read();
    }
}