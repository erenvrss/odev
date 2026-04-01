using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        PriorityQueue<string, int> queue = new PriorityQueue<string, int>();

        queue.Enqueue("Temizlik Yap", 4);
        queue.Enqueue("Acil Mail Gönder", 1);
        queue.Enqueue("Kitap Oku", 6);
        queue.Enqueue("Toplantıya Katıl", 2);
        queue.Enqueue("Kod Yaz", 3);
        queue.Enqueue("Alışveriş Yap", 5);

        while (queue.TryDequeue(out string task, out int priority))
        {
            Console.WriteLine("Görev: {0} - Öncelik Derecesi: {1}", task, priority);
        }
    }
}