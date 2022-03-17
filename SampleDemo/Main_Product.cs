using System;
using System.Collections.Generic;

namespace SampleDemo
{
    public class Main_Product
    {
        static void Main(string[] args)
        {
            List<ProductClass> produclist = new List<ProductClass>();

            ProductClass p1 = new ProductClass(101, "HP Laptop", 45000.45);
            ProductClass p2 = new ProductClass(102, "Mac Book", 55000);
            ProductClass p3 = new ProductClass(103, "Lenovo Laptop", 35000);
            ProductClass p4 = new ProductClass(104, "Dell Laptop", 25000);
            produclist.Add(p1);
            produclist.Add(p2);
            produclist.Add(p3);
            produclist.Add(p4);


            List<ProductClass> produclist1 = new List<ProductClass>()
                                            {
                                              new ProductClass(101, "HP Laptop", 45000),
                                              new ProductClass(102, "Mac Book", 55000),
                                              new ProductClass(103, "Lenovo Laptop", 35000),
                                              new ProductClass(104, "Dell Laptop", 25000)
                                             };

            foreach (ProductClass p in produclist1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("=====================");
            foreach (ProductClass p in produclist)
            {
                Console.WriteLine(p);
            }
        }
       
    }
}
