using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        string metin = "(a + b) * (c - (d + e))";
        Stack<char> stack = new Stack<char>();
        bool dengeliMi = true;

        foreach (char c in metin)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    dengeliMi = false;
                    break;
                }
            }
        }

        if (stack.Count > 0)
        {
            dengeliMi = false;
        }

        if (dengeliMi)
        {
            Console.WriteLine("Metindeki parantezler DENGELİ. Metin: {0}", metin);
        }
        else
        {
            Console.WriteLine("Metindeki parantezler DENGELİ DEĞİL! Metin: {0}", metin);
        }
    }
}