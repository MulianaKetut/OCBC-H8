using System;

public class Logika8
{
    public static void Main(string[] args)
    {
        int star = 0;
        int end = 0;
        bool status = false;
        do
        {
            try
            {
                Console.Write("Nilai Star: ");
                star = int.Parse(Console.ReadLine());
                Console.Write("Nilai End: ");
                end = int.Parse(Console.ReadLine());
                status = false;
            }
            catch
            {
                Console.WriteLine("ANDA SALAH INPUT!");
                status = true;
            }
        } while (status);

        bool x = false;
        string op = "";
        double temp = 0.0;
        double temp1 = 0.0;
        do
        {
            Console.Write("Input operator (*,/,+,-): ");
            op = Console.ReadLine();

            if (op == "*")
            {
                temp = star;
                for (int i = star; i <= end; i++)
                {
                    Console.WriteLine(i + " * " + temp + " = " + (i * temp));
                }
            }
            else if (op == "/")
            {
                temp = star;
                for (int i = star; i <= end; i++)
                {
                    temp1 = (i / temp);
                    Console.WriteLine(i + " / " + temp + " = " + temp1);
                }
            }
            else if (op == "+")
            {
                temp = star;
                for (int i = star; i <= end; i++)
                {
                    Console.WriteLine(i + " + " + temp + " = " + (i + temp));
                }
            }
            else if (op == "-")
            {
                temp = star;
                for (int i = star; i <= end; i++)
                {
                    Console.WriteLine(i + " - " + temp + " = " + (i - temp));
                }
            }
            else
            {
                Console.WriteLine("Eror!");
                x = true;
            }
        } while (x);
    }
}