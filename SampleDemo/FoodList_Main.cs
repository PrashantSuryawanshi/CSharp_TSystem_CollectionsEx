using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class FoodList_Main
    {
        static void Main(string[] args)
        {
            List<Food> foodList = new List<Food>();
            Food f1 = new Food("Apple ", 40);
            Food f2 = new Food("Mango ", 30);
            Food f3 = new Food("Tometo", 50);
            Food f4 = new Food("Greps ", 45);
            Food f5 = new Food("Kivi  ", 80);

            foodList.Add(f1);
            foodList.Add(f2);
            foodList.Add(f3);
            foodList.Add(f4);
            foodList.Add(f5);

            Console.WriteLine("Food Name     Food Price");
            foreach (Food item in foodList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
