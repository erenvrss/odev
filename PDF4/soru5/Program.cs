using System;

class Program5
{
    static int ToplamBul(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + ToplamBul(n - 1);
    }

    static void Main()
    {
        int n = 10;
        int sonuc = ToplamBul(n);

        Console.WriteLine("1'den {0}'e kadar olan sayıların toplamı: {1}", n, sonuc);
    }
}