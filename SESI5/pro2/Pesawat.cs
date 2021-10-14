using System;

public class Pesawat
{
    public string name;

    private string ketinggian;

    public string Ketinggian
    {
        get
        {
            return this.ketinggian;
        }
        set
        {
            this.ketinggian = value;
        }
    }

    public void terbang()
    {
        Console
            .WriteLine("Pesawat dengan nama {0}, sedang take off", this.name);
    }

    public void sudahTerbang()
    {
        Console
            .WriteLine("Pesawat sekarang berada pada ketinggian {0}",
            this.ketinggian);
    }
}
