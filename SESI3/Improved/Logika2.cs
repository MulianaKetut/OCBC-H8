using System;

public class Logika2
{
    public static void Main(string[] args)
    {
        int nilai = 0;
        string name = "";
        bool status = false;

        do
        {
            try
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Nilai: ");
                nilai = int.Parse(Console.ReadLine());
                status = false;
            }
            catch
            {
                Console.WriteLine("SALAH INPUT!");
                status = true;
            }
        } while (status);

        Console.WriteLine();
        if (nilai < 60)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nilai Kamu C");
        }
        else if (nilai < 80)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nilai Kamu B");
        }
        else
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nilai Kamu A");
        }
    }
}