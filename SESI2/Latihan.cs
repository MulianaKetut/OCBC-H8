using System;

class Latihan
{
    public static void Main(string[] args)
    {
        string cutomerName = "Foxi";
        double harga1 = 10000, harga2 = 5000, harga3 = 20000;
        int jumlah1 = 10, jumlah2 = 7, jumlah3 = 13;

        double total1 = harga1 * jumlah1;
        double total2 = harga2 * jumlah2;
        double total3 = harga3 * jumlah3;

        int totalJumlah = jumlah1 + jumlah2 + jumlah3;
        double totalHarga = total1 + total2 + total3;

        Console.WriteLine("Customer Name: " + cutomerName);
        Console.WriteLine("Daftar Belanja");
        Console.WriteLine("Barang 1 berjumlah " + jumlah1 + " dengan harga " + harga1 + "/pcs yang harus dibayar " + total1);
        Console.WriteLine("Barang 2 berjumlah " + jumlah2 + " dengan harga " + harga2 + "/pcs yang harus dibayar " + total2);
        Console.WriteLine("Barang 3 berjumlah " + jumlah3 + " dengan harga " + harga3 + "/pcs yang harus dibayar " + total3);
        Console.WriteLine("Jumlah Barang " + totalJumlah);
        Console.WriteLine("Total Harga = " + totalHarga);
    }
}