using System;

public class Data1
{
    public static void Main(string[] args)
    {
        string[] contoh = new string[4] { "Joni", "Meri", "David", "Tata" };

        Console.WriteLine("\nMenampilkan semua data dalam array:");
        foreach (string item in contoh)
        {
            Console.WriteLine(item);
        }
    }
}