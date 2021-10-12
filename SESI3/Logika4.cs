using System;

class Logika4
{
    public static void Main(string[] args)
    {
        double nilai;
        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());

        if (nilai >= 85)
        {
            Console.WriteLine("Grade A");
        }
        else if (nilai >= 65)
        {
            Console.WriteLine("Grade B");
        }
        else if (nilai >= 45)
        {
            Console.WriteLine("Grade C");
        }
        else if (nilai >= 25)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade E");
        }
    }
}