using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        Dictionary<string, int> urunStoklari = new Dictionary<string, int>();

        urunStoklari.Add("Kalem", 20);
        urunStoklari.Add("Defter", 0);
        urunStoklari.Add("Silgi", 50);
        urunStoklari.Add("Kitap", 8);

        Console.Write("Stok bilgisini sorgulamak istediğiniz ürünü giriniz: ");
        string sorgulananUrun = Console.ReadLine();

        if (urunStoklari.ContainsKey(sorgulananUrun))
        {
            Console.WriteLine("{0} ürününün stok adedi: {1}", sorgulananUrun, urunStoklari[sorgulananUrun]);
        }
        else
        {
            Console.WriteLine("Ürün yok");
        }

        bool sifirStokVarMi = urunStoklari.ContainsValue(0);
        Console.WriteLine("Stoku 0 olan ürün var mı? Sonuç: {0}", sifirStokVarMi);

        Console.WriteLine("Sistemdeki toplam farklı ürün sayısı: {0}", urunStoklari.Count);
    }
}