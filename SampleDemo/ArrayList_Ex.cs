using System;
using System.Collections;


namespace SampleDemo
{
    public class ArrayList_Ex
    {
        public void arrayList1()
        {
            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add(12.34);
            list.Add("Test");
            list.Add(45);

            Console.WriteLine("count number of data add in List :: " + list.Count);
            Console.WriteLine("Take Memory :: " + list.Capacity +"Byte");

            Console.WriteLine("=============================");
            list.Insert(1, 15);
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\n========================");
            Console.WriteLine("\nAfter remove value 12.34 ::\n");
            list.Remove(12.34);
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\n============================");
            Console.WriteLine("\nAfter remove index value (2)::\n");
            list.RemoveAt(2);
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("============================");

            ArrayList list1 = new ArrayList();

            list1.Add(10);
            list1.Add(12.34);
            list1.Add("Test");
            list1.Add(45);
            foreach (object item1 in list1)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("\nAfter remove index value given range (0,2) ::\n");
            
            list1.RemoveRange(0,2);
            foreach (object item1 in list1)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine("count number of data add in List ::" + list1.Count);
            Console.WriteLine("Take Memory by Data ::"+list1.Capacity+"\n");
        }
        static void Main(string[] args)
        {
            ArrayList_Ex list = new ArrayList_Ex();
            list.arrayList1();

        }
    }
}
