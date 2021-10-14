using System;

public class Laptop
{
    public string merk;

    public int ram;

    public int memory;

    public void chatting()
    {
        Console.WriteLine("\n{0} Sedang Chatting", this.merk);
    }

    public void sosmed()
    {
        Console.WriteLine("{0} Sedang Sosmed", this.merk);
    }

    public void onlineShop()
    {
        Console.WriteLine("{0} Sedang Online Shop", this.merk);
    }
}
