using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Product
    {
        int pcode;
        string pName;
        double price;
        double discountprice, finalPrice;
        public Product()
        {
            pcode = 12232;
            pName = "Laptop";
            price = 4000.00;          
        }
        public void discount()
        {
            if (price > 5000)
            {                
                discountprice = price * 0.1;
                finalPrice = price - discountprice;
            }
            else 
            {
                finalPrice = price; 
            }
        }

        public override string ToString()
        {
            return ($"Product Code ::{pcode} \nProduct Name ::{pName} \nProduct Price ::{price} \nAfter Discount Price :: {finalPrice}");
        }
    }
}
