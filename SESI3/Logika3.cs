using System;

public class Logika3
{
    public static void Main(string[] args)
    {
        string username;
        string password;

        //input
        Console.Write("Username: ");
        username = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();

        //logic
        if (username == "ocbc" && password == "bootcamp")
        {
            Console.WriteLine("Anda berhasil Login!");
        }
        else
        {
            Console.WriteLine("Username atau password anda salah!");
        }
        // Console.ReadKey();
    }
}