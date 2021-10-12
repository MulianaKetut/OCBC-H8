using System;
using System.Collections;

public class O11_I_Ketut_Muliana_assignment1
{
    public static void Main(string[] args)
    {
        int pilihan = 0;
        bool status = true;
        bool repeat = true;

        while (repeat)
        {
            do
            {
                Console.WriteLine("\n=== SELAMAT DATANG DI ASSIGNMENT 1 ===");
                Console.WriteLine("Nama : I Ketut Muliana");
                Console.WriteLine("Nomor Peserta : FSDO001ONL011");
                Console.WriteLine("Alamat : Surabaya");
                Console.WriteLine("\nMenu yang tersedia: ");
                Console.WriteLine("1. Segitiga Alfabet");
                Console.WriteLine("2. Segitiga Angka");
                Console.WriteLine("3. Faktorial");
                Console.WriteLine("4. Reserve Angka or String");
                Console.WriteLine("5. Convert Angka to Word");

                try
                {
                    Console.Write("\nMasukan pilihan menu (1/2/3/4/5): ");
                    pilihan = int.Parse(Console.ReadLine());
                    if (pilihan < 1 || pilihan > 5)
                    {
                        Console.WriteLine("\nMenu yang anda pilih tidak tersedia!");
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
                catch
                {
                    Console.WriteLine("\nMenu yang anda pilih tidak tersedia!");
                    status = true;
                }
            } while (status);

            if (pilihan == 1)
            {
                string[] alfabet = new string[]{
                    "A",
                    "B",
                    "C",
                    "D",
                    "E",
                    "F",
                    "G",
                    "H",
                    "I",
                    "J",
                    "K",
                    "L",
                    "M",
                    "N",
                    "O",
                    "P",
                    "Q",
                    "R",
                    "S",
                    "T",
                    "U",
                    "V",
                    "W",
                    "X",
                    "Y",
                    "Z"
                    };
                int a, b, c, d = 0;
                bool bol = true;
                int range = 0;
                do
                {
                    try
                    {
                        Console.Write("Enter the range (max 26): ");
                        range = int.Parse(Console.ReadLine());
                        if (range > 26)
                        {
                            Console.WriteLine("Range Input max 26 bro!");
                            bol = true;
                        }
                        else
                        {
                            bol = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Anda salah input bro!");
                        bol = true;
                    }
                } while (bol);

                for (a = 0; a < range; a++)
                {
                    for (b = range - 1; b > a; b--)
                    {
                        Console.Write(" ");
                    }
                    for (c = 0; c < a; c++)
                    {
                        Console.Write(alfabet[c]);
                    }
                    for (d = a; d >= 0; d--)
                    {
                        Console.Write(alfabet[d]);
                    }
                    Console.WriteLine();
                }
            }
            else if (pilihan == 2)
            {
                int a, b, c, d = 0;
                bool bol = true;
                int range = 0;
                do
                {
                    try
                    {
                        Console.Write("Enter the range: ");
                        range = int.Parse(Console.ReadLine());
                        bol = false;
                    }
                    catch
                    {
                        Console.WriteLine("Anda salah input bro!");
                        bol = true;
                    }
                } while (bol);

                for (a = 1; a <= range; a++)
                {
                    for (b = range - 1; b >= a; b--)
                    {
                        Console.Write(" ");
                    }
                    for (c = 1; c <= a; c++)
                    {
                        Console.Write(c);
                    }
                    for (d = a - 1; d >= 1; d--)
                    {
                        Console.Write(d);
                    }
                    Console.WriteLine();
                }
            }
            else if (pilihan == 3)
            {
                bool bol = true;
                int number = 0;
                int temp = 0, x = 0;
                do
                {
                    try
                    {
                        Console.Write("Enter any number: ");
                        number = int.Parse(Console.ReadLine());
                        temp = number;
                        x = number;
                        bol = false;
                    }
                    catch
                    {
                        Console.WriteLine("Anda salah input bro!");
                        bol = true;
                    }
                } while (bol);

                for (int i = 0; i < number; i++)
                {
                    temp *= number--;
                }
                Console.WriteLine("Factorial of " + x + " is " + temp);
            }
            else if (pilihan == 4)
            {
                Console.Write("Enter any number or string: ");
                string str = Console.ReadLine();

                Console.WriteLine("Hasil Reverse = " + Reverse(str));
            }
            else
            {
                bool bol = true;
                int number = 0;
                do
                {
                    try
                    {
                        Console.Write("Enter any number: ");
                        number = int.Parse(Console.ReadLine());
                        bol = false;
                    }
                    catch
                    {
                        Console.WriteLine("Anda salah input bro!");
                        bol = true;
                    }
                } while (bol);
                
                string str = number.ToString();
                string[] arrStr = new string[10]{
                    "zero",
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine"
                };
                char[] arrChar = str.ToCharArray();
                var arrResult = new ArrayList();
                for (int i = 0; i < arrChar.Length; i++)
                {
                    for (int j = 0; j < arrStr.Length; j++)
                    {
                        if (int.Parse(arrChar[i].ToString()) == j)
                        {
                            arrResult.Add(arrStr[j]);
                        }
                    }
                }

                for (int i = 0; i < arrResult.Count; i++)
                {
                    Console.Write(arrResult[i] + " ");
                }
                Console.WriteLine();
            }

            bool flag = true;
            do
            {
                Console.Write("\nRepeat again? (y/n): ");
                string re = Console.ReadLine();
                if (re.ToLower().Equals("y"))
                {
                    repeat = true;
                    flag = false;
                }
                else if (re.ToLower().Equals("n"))
                {
                    repeat = false;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Input yang benar bro!");
                    flag = true;
                }
            } while (flag);

        }
        Console.WriteLine("=== MATUR THANK YOU ===");

    }

    public static string Reverse(string str)
    {
        char[] arrChar = str.ToCharArray();
        Array.Reverse(arrChar);
        return new string(arrChar);
    }
}