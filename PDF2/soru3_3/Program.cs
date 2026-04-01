using System;
using System.Collections.Generic;

class Program3
{
    static void Main()
    {
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

        ogrenciler.Add(1001, "Oyun Geliştirme");
        ogrenciler.Add(1002, "Yazılım");
        ogrenciler.Add(1003, "Grafik");
        ogrenciler.Add(1004, "Veri Bilimi");

        KeyValuePair<int, string>[] dizi = new KeyValuePair<int, string>[10];

        ogrenciler.CopyTo(dizi, 3);

        Console.WriteLine("Dizi İçeriği:");
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i].Key == 0 && dizi[i].Value == null)
            {
                Console.WriteLine("İndeks {0}: Boş", i);
            }
            else
            {
                Console.WriteLine("İndeks {0}: Öğrenci No: {1}, Bölüm: {2}", i, dizi[i].Key, dizi[i].Value);
            }
        }

        ogrenciler.Clear();

        Console.WriteLine("Sözlük temizlendikten sonraki eleman sayısı: {0}", ogrenciler.Count);
    }
}