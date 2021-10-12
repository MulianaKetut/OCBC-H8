using System;

class HitungNilai2
{
    public static void Main(string[] args)
    {
        int nilai1 = 10;
        int nilai2 = 8;

        //overwrite
        nilai1 = 15;

        Console.WriteLine($"Nilai Pertama = {nilai1}");

        //menggunakan += untuk mengisi dan menjumlahkan
        nilai2 += 6;

        Console.WriteLine($"Nilai Kedua = {nilai2}");
    }
}      