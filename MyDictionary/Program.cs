using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> musteriler = new Dictionary<int, string>();
            musteriler.Add(0, "Erkan");
            musteriler.Add(1, "Ali");
            musteriler.Add(2, "Ayşe");
            musteriler.Add(3, "Fatma");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("ID= "+ musteri.Key + "   Ad= " + musteri.Value); 
            }

            Console.WriteLine("---------------My Dictionary----------------");
            MyDictionaryDemo<int, string> musteriler2 = new MyDictionaryDemo<int, string>();

            musteriler2.Add(0, "Erkan");
            musteriler2.Add(1, "Ali");
            musteriler2.Add(2, "Ayşe");
            musteriler2.Add(3, "Fatma");

            for (int i = 0; i < musteriler2.Count; i++)
            {
                Console.WriteLine("ID= "+musteriler2.Key[i]+"  Ad= "+musteriler2.Value[i]);
            }


            Console.ReadLine();
 
        }
    }
}
