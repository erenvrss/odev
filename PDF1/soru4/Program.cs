using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(5);

        for (int i = 1; i <= 10; i++)
        {
            if (stack.Count > 0)
            {
                int ustteki = stack.Peek();

                if (ustteki % 2 == 0)
                {
                    stack.Pop();
                    Console.WriteLine("Adım {0}: Üstteki eleman çift ({1}) -> Pop edildi.", i, ustteki);
                }
                else
                {
                    stack.Push(ustteki + 1);
                    Console.WriteLine("Adım {0}: Üstteki eleman tek ({1}) -> Push({2}) yapıldı.", i, ustteki, ustteki + 1);
                }
            }
            else
            {
                Console.WriteLine("Adım {0}: Stack boş, işlem yapılamıyor.", i);
            }
        }
    }
}