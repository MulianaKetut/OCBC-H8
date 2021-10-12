using System;

public class Logika3
{
    public static void Main(string[] args)
    {
        string username;
        string password;
        bool status;
        do
        {
            //input
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            //logic
            if (username == "ocbc" && password == "bootcamp")
            {
                Console.WriteLine("Anda berhasil Login!");
                status = false;
            }
            else
            {
                Console.WriteLine("Username atau password anda salah!");
                status = true;
            }
        } while (status);
        // Console.ReadKey();
    }
}