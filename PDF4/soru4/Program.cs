using System;

class Program4
{
    static string StringTersCevir(string metin)
    {
        if (metin.Length <= 1)
        {
            return metin;
        }

        return metin[metin.Length - 1] + StringTersCevir(metin.Substring(0, metin.Length - 1));
    }

    static void Main()
    {
        string kelime = "rekursif";
        string tersKelime = StringTersCevir(kelime);

        Console.WriteLine("Orijinal: {0}", kelime);
        Console.WriteLine("Ters Çevrilmiş: {0}", tersKelime);
    }
}