using System;

class Program1
{
    static void Main()
    {
        Console.WriteLine("Item1: İsim, Item2: Soyisim, Item3: Tecrübe yılı, Item4: Pozisyon");

        Tuple<string, string, int, string> kisi = new Tuple<string, string, int, string>("Ibrahim", "Seckin", 5, "Developer");

        Console.WriteLine("{0} {1} - {2} yıl - {3}", kisi.Item1, kisi.Item2, kisi.Item3, kisi.Item4);
    }
}