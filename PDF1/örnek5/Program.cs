using System;
using System.Collections.Generic;

class Program5
{
    static void Main()
    {
        PriorityQueue<string, (int Oncelik, int Sayac)> stabilKuyruk = new PriorityQueue<string, (int Oncelik, int Sayac)>();
        int eklenmeSirasi = 0;

        stabilKuyruk.Enqueue("A Elemanı", (2, eklenmeSirasi++));
        stabilKuyruk.Enqueue("B Elemanı", (1, eklenmeSirasi++));
        stabilKuyruk.Enqueue("C Elemanı", (2, eklenmeSirasi++));
        stabilKuyruk.Enqueue("D Elemanı", (1, eklenmeSirasi++));
        stabilKuyruk.Enqueue("E Elemanı", (3, eklenmeSirasi++));

        while (stabilKuyruk.TryDequeue(out string eleman, out var priorityTup))
        {
            Console.WriteLine("İşlenen: {0} - Öncelik: {1} - Sayac/Sıra: {2}", eleman, priorityTup.Oncelik, priorityTup.Sayac);
        }
    }
}