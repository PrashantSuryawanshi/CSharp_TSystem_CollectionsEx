using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class ProductMainMethod
    {
        static void Main(string[] args)
        {
            Product prod = new Product();
            prod.discount();
            Console.WriteLine(prod);

        }
    }
}
