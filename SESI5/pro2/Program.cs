using System;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            bool status = true;
            do
            {
                try
                {
                    Console.Write("Enter Nama Pesawat: ");
                    pesawat.name = Console.ReadLine();
                    Console.Write("Enter Ketinggian: ");
                    pesawat.Ketinggian = Console.ReadLine();
                    status = false;
                }
                catch
                {
                    Console
                        .WriteLine("Ada salah input, Mohon di isi dengan benar!");
                    status = true;
                }
            }
            while (status);

            pesawat.terbang();
            pesawat.sudahTerbang();
            Console.Read();
        }
    }
}
