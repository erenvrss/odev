using System;
using System.Collections.Generic;

class Program2
{
    static void Main()
    {
        HashSet<int> etkinlikA = new HashSet<int> { 101, 102, 103, 104, 105 };
        HashSet<int> etkinlikB = new HashSet<int> { 104, 105, 106, 107 };

        HashSet<int> birlesim = new HashSet<int>(etkinlikA);
        birlesim.UnionWith(etkinlikB);
        Console.WriteLine("A U B (Birleşim): {0}", string.Join(",", birlesim));

        HashSet<int> kesisim = new HashSet<int>(etkinlikA);
        kesisim.IntersectWith(etkinlikB);
        Console.WriteLine("A n B (Kesişim): {0}", string.Join(",", kesisim));

        HashSet<int> fark = new HashSet<int>(etkinlikA);
        fark.ExceptWith(etkinlikB);
        Console.WriteLine("A \\ B (Fark): {0}", string.Join(",", fark));
    }
}