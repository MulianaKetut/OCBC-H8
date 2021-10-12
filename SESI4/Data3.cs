using System;

public class Data3
{
    public static void Main(string[] args)
    {
        int[,] tabel = new int[3, 4];

        for (int t = 0; t < 3; t++)
        {
            for (int i = 0; i < 4; i++)
            {
                tabel[t, i] = (t * 4) + i + 1;
                Console.Write(tabel[t, i] + " ");
            }
            Console.WriteLine();
        }
    }
}