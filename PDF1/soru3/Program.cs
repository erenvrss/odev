using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> islemGecmisi = new Stack<string>();
        string komut = "";

        Console.WriteLine("İşlemleri girin (Add, Remove, Update). Geri almak için 'undo', çıkmak için 'exit' yazın.");

        while (true)
        {
            Console.Write("Komut: ");
            komut = Console.ReadLine();

            if (komut == "exit")
            {
                break;
            }
            else if (komut == "undo")
            {
                if (islemGecmisi.Count > 0)
                {
                    string geriAlinan = islemGecmisi.Pop();
                    Console.WriteLine("Geri alınan işlem: {0}", geriAlinan);
                }
                else
                {
                    Console.WriteLine("Geri alınacak işlem bulunmuyor (Stack boş).");
                }
            }
            else
            {
                islemGecmisi.Push(komut);
                Console.WriteLine("İşlem yığına eklendi: {0}", komut);
            }
        }
    }
}