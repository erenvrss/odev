using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string kelime = "game";
        Stack<char> stack = new Stack<char>();

        foreach (char c in kelime)
        {
            stack.Push(c);
        }

        string tersKelime = "";

        while (stack.Count > 0)
        {
            tersKelime += stack.Pop();
        }

        Console.WriteLine("Orijinal kelime: {0}", kelime);
        Console.WriteLine("Ters çevrilmiş kelime: {0}", tersKelime);
    }
}