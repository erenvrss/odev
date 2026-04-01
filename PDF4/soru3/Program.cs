using System;

class Program3
{
    static void DiziYazdir(int[] dizi, int index)
    {
        if (index == dizi.Length)
        {
            return;
        }

        Console.WriteLine("İndeks {0}: {1}", index, dizi[index]);
        DiziYazdir(dizi, index + 1);
    }

    static void Main()
    {
        int[] sayilar = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Dizi Elemanları:");
        DiziYazdir(sayilar, 0);
    }
}