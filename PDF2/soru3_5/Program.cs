using System;
using System.Collections.Generic;

class Program3
{
    static void Main()
    {
        HashSet<string> kullaniciYetkileri = new HashSet<string> { "Read", "Write", "Delete" };
        HashSet<string> minimumYetkiler = new HashSet<string> { "Read", "Write" };

        bool deleteVarMi = kullaniciYetkileri.Contains("Delete");
        Console.WriteLine("Kullanıcının Delete yetkisi var mı? {0}", deleteVarMi);

        Console.Write("Kaldırılacak yetkiyi yazınız: ");
        string silinecekYetki = Console.ReadLine();
        kullaniciYetkileri.Remove(silinecekYetki);

        bool yetkilerAyniMi = kullaniciYetkileri.SetEquals(minimumYetkiler);
        Console.WriteLine("Güncel yetkiler ile minimum yetkiler aynı mı? {0}", yetkilerAyniMi);

        kullaniciYetkileri.Clear();
        Console.WriteLine("Temizleme işlemi sonrası yetki sayısı (Count): {0}", kullaniciYetkileri.Count);
    }
}