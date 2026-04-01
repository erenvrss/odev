using System;

class Program2
{
    private static (string isim, string soyisim, int tecrube, string pozisyon) GetPerson(int id)
    {
        if (id == 1)
        {
            return ("Ibrahim", "Seckin", 5, "Developer");
        }
        else if (id == 2)
        {
            return ("Ayse", "Kaya", 2, "Tester");
        }
        else
        {
            return ("Bilinmiyor", "Bilinmiyor", 0, "N/A");
        }
    }

    static void Main()
    {
        var person = GetPerson(1);

        Console.WriteLine("Kişi Bilgileri:");
        Console.WriteLine("İsim: {0}", person.isim);
        Console.WriteLine("Soyisim: {0}", person.soyisim);
        Console.WriteLine("Tecrübe: {0} yıl", person.tecrube);
        Console.WriteLine("Pozisyon: {0}", person.pozisyon);
    }
}