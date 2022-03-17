using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class SwapInMyGenric
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 15;
            Swap<int>(ref a, ref b);
            Console.WriteLine("A ="+a+"     "+"B ="+b);

            double aa = 11.34, bb = 14.23;
            Swap<double>(ref aa, ref bb);
            Console.WriteLine("\nA =" + aa + "   " + "B =" + bb);



        }
    }
}
