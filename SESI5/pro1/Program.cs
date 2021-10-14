using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance obj
            Laptop laptop1 = new Laptop();
            bool status = true;
            do
            {
                try
                {
                    Console.Write("Enter Merk Laptop: ");
                    laptop1.merk = Console.ReadLine();
                    Console.Write("Enter Ram Laptop: ");
                    laptop1.ram = int.Parse(Console.ReadLine());
                    Console.Write("Enter Memory Laptop: ");
                    laptop1.memory = int.Parse(Console.ReadLine());
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

            Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas Ram adalah {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory adalah {0}", laptop1.memory);

            laptop1.chatting();
            laptop1.sosmed();
            laptop1.onlineShop();

            Console.Read();
        }
    }
}
