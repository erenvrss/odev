using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 5;
        Stack<int> stack = new Stack<int>();

        Console.WriteLine("1'den {0}'e kadar sayılar Stack'e ekleniyor (Push)...", n);

        for (int i = 1; i <= n; i++)
        {
            stack.Push(i);
        }

        int toplam = 0;

        while (stack.Count > 0)
        {
            int cikarilan = stack.Pop();
            toplam += cikarilan;
        }

        Console.WriteLine("Stack'ten çıkarılan (Pop) sayıların toplamı: {0}", toplam);
    }
}