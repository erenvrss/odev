using System;

class Program6
{
    static int EnBuyukBul(int[] dizi, int index)
    {
        if (index == dizi.Length - 1)
        {
            return dizi[index];
        }

        int sonrakiEnBuyuk = EnBuyukBul(dizi, index + 1);

        if (dizi[index] > sonrakiEnBuyuk)
        {
            return dizi[index];
        }
        else
        {
            return sonrakiEnBuyuk;
        }
    }

    static void Main()
    {
        int[] sayilar = { 15, 42, 8, 99, 23 };
        int enBuyuk = EnBuyukBul(sayilar, 0);

        Console.WriteLine("Dizideki en büyük eleman: {0}", enBuyuk);
    }
}