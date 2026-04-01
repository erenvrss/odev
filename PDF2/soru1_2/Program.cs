using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        List<int> notlar = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0}. notu giriniz: ", i + 1);
            int girilenNot = Convert.ToInt32(Console.ReadLine());
            notlar.Add(girilenNot);
        }

        Console.WriteLine("Girilen not sayisi: {0}", notlar.Count);

        notlar.Sort();

        Console.WriteLine("Kucukten buyuge siralanmis hali:");
        foreach (int n in notlar)
        {
            Console.WriteLine(n);
        }

        notlar.Reverse();

        Console.WriteLine("Ters cevrilmis hali:");
        foreach (int n in notlar)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Listenin 0. indeksindeki eleman: {0}", notlar[0]);
    }
}