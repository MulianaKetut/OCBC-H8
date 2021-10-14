using System;

public class Pesawat
{
    public string name;

    protected string ketinggian;

    protected int jumlahPenumpang;

    protected int jumlahRoda;

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

    public int JumlahPenumpang
    {
        get
        {
            return this.jumlahPenumpang;
        }
        set
        {
            this.jumlahPenumpang = value;
        }
    }

    public int JumlahRoda
    {
        get
        {
            return this.jumlahRoda;
        }
        set
        {
            this.jumlahRoda = value;
        }
    }

    public virtual void terbang()
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
