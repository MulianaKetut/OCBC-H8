using System;

public class Data1{
    public static void Main(string[] args){
        // int[] dataAngka = new int[5];
        string[] dataNama = new string[]{"Joni","Meri","David"};
        object[] dataObj = new object[] {20.33, "Lorem", DateTime.Now, true, 'D'};

        for (int i = 0; i < dataNama.Length; i++)
        {
            Console.WriteLine(dataNama[i]);
            Console.WriteLine(dataObj[i]);
        }
    }
}