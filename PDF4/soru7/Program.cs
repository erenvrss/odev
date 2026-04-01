using System;

class Program7
{
    static int BasamakToplami(int sayi)
    {
        if (sayi == 0)
        {
            return 0;
        }

        return (sayi % 10) + BasamakToplami(sayi / 10);
    }

    static void Main()
    {
        int sayi = 12345;
        int toplam = BasamakToplami(sayi);

        Console.WriteLine("{0} sayısının basamakları toplamı: {1}", sayi, toplam);
    }
}