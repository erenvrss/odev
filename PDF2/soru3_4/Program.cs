using System;

class Program3
{
    private static (int, int, int, double) Hesapla(int a, int b)
    {
        int toplam = a + b;
        int fark = a - b;
        int carpim = a * b;
        double bolum = (double)a / b;

        return (toplam, fark, carpim, bolum);
    }

    static void Main()
    {
        (int toplam, int fark, int carpim, double bolum) sonuc = Hesapla(10, 4);

        Console.WriteLine("Hesaplama Sonuçları:");
        Console.WriteLine("Toplam: {0}", sonuc.toplam);
        Console.WriteLine("Bölüm: {0}", sonuc.bolum);
    }
}