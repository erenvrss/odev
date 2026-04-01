using System;
using System.Collections.Generic;

class Program3
{
    static void Main()
    {
        PriorityQueue<string, int> skorTablosu = new PriorityQueue<string, int>();

        skorTablosu.Enqueue("Oyuncu1", -500);
        skorTablosu.Enqueue("Oyuncu2", -1200);
        skorTablosu.Enqueue("Oyuncu3", -850);
        skorTablosu.Enqueue("Oyuncu4", -3000);
        skorTablosu.Enqueue("Oyuncu5", -2100);

        for (int i = 0; i < 3; i++)
        {
            if (skorTablosu.TryDequeue(out string oyuncu, out int negatifSkor))
            {
                Console.WriteLine("{0}. Sıradaki Oyuncu: {1} - Skor: {2}", i + 1, oyuncu, -negatifSkor);
            }
        }
    }
}