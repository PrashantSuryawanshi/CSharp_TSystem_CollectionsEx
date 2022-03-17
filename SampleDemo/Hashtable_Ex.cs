using System;
using System.Collections;

namespace SampleDemo
{
    public class Hashtable_Ex
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(14, "CSharp");
            hs.Add(23, "C++");
            hs.Add(10, "Sap");
            hs.Add(12, "Python");
            hs.Add(11, "C");
            hs.Add(22, ".Net");

            hs.Remove(63);
            Console.WriteLine("Key      Value\n");
            foreach (DictionaryEntry item in hs)
            {
                Console.WriteLine(item.Key+"      "+item.Value);
            }
            Console.WriteLine("=============================");
        }

    }
}
