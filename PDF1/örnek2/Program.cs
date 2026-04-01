using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        int[] sayilar = { 56, 12, 3, 99, 45, 8, 27, 1, 74, 19 };
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach (int sayi in sayilar)
        {
            heap.Enqueue(sayi, sayi);
        }

        for (int i = 0; i < 5; i++)
        {
            if (heap.TryDequeue(out int eleman, out int oncelik))
            {
                Console.WriteLine("{0}. En Küçük Eleman: {1}", i + 1, eleman);
            }
        }
    }
}