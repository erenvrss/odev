using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        Queue<int> stokKuyrugu = new Queue<int>();

        stokKuyrugu.Enqueue(101);
        stokKuyrugu.Enqueue(203);
        stokKuyrugu.Enqueue(305);
        stokKuyrugu.Enqueue(407);
        stokKuyrugu.Enqueue(509);

        Console.Write("Lütfen bir ürün kodu giriniz: ");
        int urunKodu = Convert.ToInt32(Console.ReadLine());

        if (stokKuyrugu.Contains(urunKodu))
        {
            Console.WriteLine("Ürün mevcut");
        }
        else
        {
            Console.WriteLine("Ürün yok");
        }

        stokKuyrugu.Clear();
        Console.WriteLine("Temizleme sonrası kuyruk eleman sayısı: {0}", stokKuyrugu.Count);
    }
}