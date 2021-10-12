using System;

class Length
{
    static void Main()
    {
        int[] angka = new int[10];

        Console.WriteLine("Panjang Array angka adalah " + angka.Length);

        for (int i = 0; i < angka.Length; i++)
        {
            angka[i] = i * i;
        }

        Console.WriteLine("Berikut adalah array angka: ");
        for (int i = 0; i < angka.Length; i++)
        {
            Console.Write(angka[i] + " ");
        }
        Console.WriteLine();
    }
}