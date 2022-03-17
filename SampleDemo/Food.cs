using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Food
    {
        private string foodName;
        private double price;

        public Food(string fn,double pr)
        {
            foodName = fn;
            price = pr;
        }
        public override string ToString()
        {
            return ($" {foodName}        {price} rs.");
        }
    }
    
}
