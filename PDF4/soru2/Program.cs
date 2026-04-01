using System;

class Program2
{
    static void NdenBireKadarYazdir(int n)
    {
        if (n == 0)
        {
            return;
        }

        Console.WriteLine(n);
        NdenBireKadarYazdir(n - 1);
    }

    static void Main()
    {
        int baslangicSayisi = 5;
        Console.WriteLine("{0}'den 1'e kadar sayılar:", baslangicSayisi);
        NdenBireKadarYazdir(baslangicSayisi);
    }
}