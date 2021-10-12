using System;

class Improved
{
    public static void Main(string[] args)
    {
        bool x = true;
        while (x)
        {
            int pertama, kedua, ketiga, total = 0;
            double avg = 0.0;

            Console.WriteLine("\n=== LOGIN ===");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            string getStatus;
            bool y;
            do
            {
                Console.Write("status nikah (y/n): ");
                getStatus = Console.ReadLine();
                y = getStatus == "y" || getStatus == "n";
            } while (!y);
            bool status = false;

            if (getStatus == "y")
            {
                status = true;
            }

            bool isAdult = age > 18;
            bool isPassword = password == "OCBC";
            bool isUsername = username == "Ketut";

            //logic
            if (isAdult && isPassword && isUsername)
            {
                Console.WriteLine("\n=== Menghitung Nilai ===");
                Console.Write("Masukan Nilai Pertama: ");
                pertama = int.Parse(Console.ReadLine());

                Console.Write("Masukan Nilai Kedua: ");
                kedua = int.Parse(Console.ReadLine());

                Console.Write("Masukan Nilai Ketiga: ");
                ketiga = int.Parse(Console.ReadLine());

                total = pertama + kedua + ketiga;
                avg = total / 3.0;

                Console.WriteLine("\n=== BIODATA ===");
                Console.WriteLine("Username : " + username);
                Console.WriteLine("Password : " + password);
                Console.WriteLine("Age : " + age);
                Console.WriteLine("Jenis Kelamin : " + gender);
                Console.WriteLine("Status Nikah : " + status);

                Console.WriteLine("\n=== ARITMATIKA ===");
                Console.WriteLine("Total Nilai : " + total);
                Console.WriteLine("Rata-rata : " + avg);

                x = false;
            }
            else
            {
                Console.WriteLine("Sorry, Try again!");
            }
        }
    }
}