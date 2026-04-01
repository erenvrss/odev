using System;

class Program1
{
    static void BirdenNeKadarYazdir(int n)
    {
        if (n == 0)
        {
            return;
        }

        BirdenNeKadarYazdir(n - 1);
        Console.WriteLine(n);
    }

    static void Main()
    {
        int bitisSayisi = 5;
        Console.WriteLine("1'den {0}'e kadar sayılar:", bitisSayisi);
        BirdenNeKadarYazdir(bitisSayisi);
    }
}