using System;
using System.Collections.Generic;

class Program3
{
    static void Main()
    {
        List<int> sayilar = new List<int> { 4, 8, 15, 16, 23, 42 };

        int[] dizi = new int[15];

        sayilar.CopyTo(dizi, 5);

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine("Indeks {0}: {1}", i, dizi[i]);
        }

        sayilar.Clear();
        Console.WriteLine("Temizleme islemi sonrasi listedeki eleman sayisi: {0}", sayilar.Count);
    }
}