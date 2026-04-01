using System;
using System.Collections.Generic;

class Program3
{
    static void Main()
    {
        Queue<int> kuyruk = new Queue<int>();

        kuyruk.Enqueue(10);
        kuyruk.Enqueue(20);
        kuyruk.Enqueue(30);
        kuyruk.Enqueue(40);

        int[] dizi = new int[10];

        kuyruk.CopyTo(dizi, 3);

        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine("İndeks {0} değeri: {1}", i, dizi[i]);
        }

        while (kuyruk.Count > 0)
        {
            Console.WriteLine("Çıkan: {0}", kuyruk.Dequeue());
        }
    }
}