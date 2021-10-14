using System;

public class Overriding
{
    public int

            bilangan1,
            bilangan2;

    public void bilangan(int angka1, int angka2)
    {
        bilangan1 = angka1;
        bilangan2 = angka2;
    }

    public virtual void penjumlahanPerkalianDll()
    {
        Console.WriteLine("Overriding 1.......-------->>>>>>>>");
        Console
            .WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}",
            bilangan1,
            bilangan2,
            (bilangan1 + bilangan2));
        Console
            .WriteLine("Hasil perkalian angka {0} dan angka {1} = {2}",
            bilangan1,
            bilangan2,
            (bilangan1 * bilangan2));
    }
}
