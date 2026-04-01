using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        Queue<string> bankaKuyrugu = new Queue<string>();

        bankaKuyrugu.Enqueue("Ali");
        bankaKuyrugu.Enqueue("Ayşe");
        bankaKuyrugu.Enqueue("Mehmet");
        bankaKuyrugu.Enqueue("Zeynep");

        Console.WriteLine("Kuyruğun ilk elemanı: {0}", bankaKuyrugu.Peek());

        string musteri1 = bankaKuyrugu.Dequeue();
        Console.WriteLine("Hizmet verildi: {0}", musteri1);

        string musteri2 = bankaKuyrugu.Dequeue();
        Console.WriteLine("Hizmet verildi: {0}", musteri2);

        Console.WriteLine("Kalan müşteri sayısı: {0}", bankaKuyrugu.Count);

        foreach (string musteri in bankaKuyrugu)
        {
            Console.WriteLine("Sıradaki müşteri: {0}", musteri);
        }
    }
}