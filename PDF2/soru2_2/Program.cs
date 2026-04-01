using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        List<string> urunler = new List<string> { "Mouse", "Klavye", "Monitör", "Kulaklık", "Webcam" };

        Console.Write("Bir urun adi giriniz: ");
        string arananUrun = Console.ReadLine();

        if (urunler.Contains(arananUrun))
        {
            int bulunanIndeks = urunler.IndexOf(arananUrun);
            Console.WriteLine("Girdiginiz urunun indeksi: {0}", bulunanIndeks);
        }

        Console.WriteLine("Gecerli indeks araligi: 0 - {0}", urunler.Count - 1);
        Console.Write("Silmek istediginiz urunun indeksini giriniz: ");
        int silinecekIndeks = Convert.ToInt32(Console.ReadLine());

        urunler.RemoveAt(silinecekIndeks);

        Console.WriteLine("Listenin son hali:");
        foreach (string urun in urunler)
        {
            Console.WriteLine(urun);
        }
    }
}