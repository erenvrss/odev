using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        HashSet<int> yoklama = new HashSet<int>();

        for (int i = 0; i < 8; i++)
        {
            Console.Write("{0}. Öğrenci Numarası: ", i + 1);
            int numara = Convert.ToInt32(Console.ReadLine());

            bool eklendiMi = yoklama.Add(numara);

            if (!eklendiMi)
            {
                Console.WriteLine("Bu numara zaten vardı, eklenmedi.");
            }
        }

        Console.WriteLine("Toplam benzersiz öğrenci sayısı: {0}", yoklama.Count);

        Console.Write("Kontrol edilecek numarayı giriniz: ");
        int kontrolNumarasi = Convert.ToInt32(Console.ReadLine());

        if (yoklama.Contains(kontrolNumarasi))
        {
            Console.WriteLine("Var");
        }
        else
        {
            Console.WriteLine("Yok");
        }
    }
}