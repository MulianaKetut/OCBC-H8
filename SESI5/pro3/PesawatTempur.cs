using System;

public class PesawatTempur : Pesawat
{
    public override void terbang()
    {
        Console
            .WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata",
            this.name,
            this.jumlahRoda,
            this.ketinggian,
            this.jumlahPenumpang);
    }
}
