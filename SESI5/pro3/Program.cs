using System;

namespace pro3
{
    class Program : Overriding
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                bool repeat1 = true;
                int pilihan = 1;
                do
                {
                    try
                    {
                        Console.WriteLine("=== SELAMAT DATANG DI SESI 5 ===");
                        Console.WriteLine("Menu yang tersedia: ");
                        Console.WriteLine("1. Pesawat Tempur ");
                        Console.WriteLine("2. Overloading ");
                        Console.WriteLine("3. Overriding ");
                        Console.WriteLine("4. About C# ");
                        Console.Write("Masukan menu yang dipilih (1/2/3/4): ");
                        pilihan = int.Parse(Console.ReadLine());
                        if (pilihan < 1 || pilihan > 4)
                        {
                            Console.WriteLine("Menu tidak tersedia!");
                            repeat1 = true;
                        }
                        else
                        {
                            repeat1 = false;
                        }
                        Console.WriteLine();
                    }
                    catch
                    {
                        Console
                            .WriteLine("Ada salah input, Mohon di isi dengan benar!");
                        repeat1 = true;
                    }
                }
                while (repeat1);

                if (pilihan == 1)
                {
                    PesawatTempur pesawatTempur = new PesawatTempur();
                    bool status = true;
                    do
                    {
                        try
                        {
                            Console.WriteLine("=== PESAWAT TEMPUR ===");
                            Console.Write("Enter Nama Pesawat: ");
                            pesawatTempur.name = Console.ReadLine();
                            Console.Write("Enter Ketinggian: ");
                            pesawatTempur.Ketinggian = Console.ReadLine();
                            Console.Write("Enter Jumlah Penumpang: ");
                            pesawatTempur.JumlahPenumpang =
                                int.Parse(Console.ReadLine());
                            Console.Write("Enter Jumlah Roda: ");
                            pesawatTempur.JumlahRoda =
                                int.Parse(Console.ReadLine());
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

                    pesawatTempur.terbang();
                    Console.WriteLine();
                }
                else if (pilihan == 2)
                {
                    Overloading ov = new Overloading();
                    bool status = true;
                    do
                    {
                        try
                        {
                            Console.WriteLine("=== OVERLOADING ===");
                            Console.Write("Enter Nama : ");
                            ov.nama = Console.ReadLine();
                            Console.Write("Enter No HP : ");
                            ov.nomorTelepon =
                                Convert.ToDouble(Console.ReadLine());
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

                    ov.print(ov.nama);
                    ov.print(ov.nomorTelepon);
                    Console.WriteLine();
                }
                else if (pilihan == 3)
                {
                    Overriding ov = new Overriding();
                    bool status = true;
                    int
                        angka1 = 0,
                        angka2 = 0;
                    int
                        number1 = 0,
                        number2 = 0;
                    do
                    {
                        try
                        {
                            Console.WriteLine("=== OVERRIDING ===");
                            Console.Write("Enter Angka-1 : ");
                            angka1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter Angka-2 : ");
                            angka2 = int.Parse(Console.ReadLine());
                            Console.Write("Enter Bilangan-1 : ");
                            number1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter Bilangan-2 : ");
                            number2 = int.Parse(Console.ReadLine());
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

                    ov.bilangan (angka1, angka2);
                    ov.penjumlahanPerkalianDll();
                    Console.WriteLine();
                    ov = new Program();
                    ov.bilangan (number1, number2);
                    ov.penjumlahanPerkalianDll();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("=== ABOUT C# ===");
                    Console
                        .WriteLine("Hai, saya I Ketut Muliana asal dari Indonesia.");
                    Console
                        .WriteLine("Tentang C#, karena baru pertama kali saya mencoba bahasa pemrograman ini");
                    Console
                        .WriteLine("yang menurut saya 11/12 dengan bahasa java (mungkin lebih simple ini terkait sintax serta struktur)");
                    Console
                        .WriteLine("jadi harus sering ngulik C# biar semakin terbiasa dengan sintax dan juga struktur code maupun struktur data");
                    Console
                        .WriteLine("Dari Sesi 1 sampai dengan Sesi 5 ini, saya tertarik dengan C#, karena dapat menambah pengetahuan");
                    Console
                        .WriteLine("serta pengalaman apalagi mendapatkan kesempatan dari OCBC seperti bootcamp ini dan dibimbing langsung oleh team Hacktiv8");
                    Console.WriteLine("Gassskeunn!!! #TAYTB");
                }
                bool flag = true;
                while (flag)
                {
                    Console.Write("Kembali ke menu? (y/n): ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        flag = false;
                        repeat = true;
                    }
                    else if (answer == "n")
                    {
                        flag = false;
                        repeat = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
            while (repeat);
            Console.WriteLine("=== MATUR THANK YOU ===");
        }

        public override void penjumlahanPerkalianDll()
        {
            Console.WriteLine("Overriding 2.......-------->>>>>>>>");
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
}
