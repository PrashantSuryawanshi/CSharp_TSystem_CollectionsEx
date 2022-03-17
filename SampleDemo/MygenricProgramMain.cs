using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class MygenricProgramMain
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> obj1 = new MyGenericClass<int>(110);
            Console.WriteLine(obj1);
            Console.WriteLine("=====================================");

            MyGenericClass<string> obj2 = new MyGenericClass<string>("Prashant");
            Console.WriteLine(obj2);

            Console.WriteLine("=====================================");

            MyGenericClass<float> obj3 = new MyGenericClass<float>(12.33f);
            Console.WriteLine(obj3);

            Console.WriteLine("====================================");

            MyGenericClass<bool> obj4 = new MyGenericClass<bool>(true);
            Console.WriteLine(obj4);

        }
    }
    
}
