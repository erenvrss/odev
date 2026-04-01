using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        Dictionary<string, string> telefonRehberi = new Dictionary<string, string>();

        telefonRehberi.Add("Ali Yılmaz", "05550000001");
        telefonRehberi.Add("Ayşe Kaya", "05550000002");
        telefonRehberi.Add("Mehmet Demir", "05550000003");

        Console.Write("Bir isim giriniz: ");
        string arananIsim = Console.ReadLine();

        if (telefonRehberi.ContainsKey(arananIsim))
        {
            Console.WriteLine("Bu kişi zaten var, numarasını güncelleyin.");
            Console.Write("Yeni numarayı giriniz: ");
            string yeniNumara = Console.ReadLine();
            telefonRehberi[arananIsim] = yeniNumara;
        }
        else
        {
            Console.Write("Kişi bulunamadı. Eklemek için numarayı giriniz: ");
            string yeniKayitNumarasi = Console.ReadLine();
            telefonRehberi.Add(arananIsim, yeniKayitNumarasi);
        }

        Console.Write("Silmek istediğiniz kişinin ismini giriniz: ");
        string silinecekIsim = Console.ReadLine();

        if (telefonRehberi.ContainsKey(silinecekIsim))
        {
            telefonRehberi.Remove(silinecekIsim);
            Console.WriteLine("Kişi silindi.");
        }

        Console.WriteLine("Güncel kayıt sayısı: {0}", telefonRehberi.Count);
        Console.WriteLine("Rehberdeki Tüm Kayıtlar:");

        foreach (KeyValuePair<string, string> kayit in telefonRehberi)
        {
            Console.WriteLine("İsim: {0} - Telefon: {1}", kayit.Key, kayit.Value);
        }
    }
}