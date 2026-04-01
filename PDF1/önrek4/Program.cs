using System;
using System.Collections.Generic;

class Program4
{
    static void Main()
    {
        PriorityQueue<string, int> aiGorevleri = new PriorityQueue<string, int>();

        aiGorevleri.Enqueue("Patrol", 5);
        aiGorevleri.Enqueue("Chase", 2);
        aiGorevleri.Enqueue("Attack", 1);
        aiGorevleri.Enqueue("Run", 0);

        while (aiGorevleri.TryDequeue(out string gorev, out int oncelik))
        {
            Console.WriteLine("Çalışan AI Görevi: {0} (Priority: {1})", gorev, oncelik);
        }
    }
}