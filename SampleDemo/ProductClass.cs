using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class ProductClass
    {
        private int code;
        private string name;
        private double price;

        public ProductClass(int code,string name,double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return code + " " + name + " " + price;
        }
    }
}
