using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Array_2DEx
    {
        static void Main(string[] args)
        {
            //3 row ,7 colm
            //values 3*7 = 21;
            int[,] details = new int[3, 7]
                              {
                                  {101,102,103,204,205,206,207 },
                                  {101,102,103,204,205,206,207 },
                                  {101,102,103,204,205,206,207 }
                              };
            int[,] list = new int[6, 3]
                             {
                                  { 101,102,103 },
                                  { 101,102,103 },
                                  { 101,102,103 },
                                  { 101,102,103 },
                                  { 101,102,103 },
                                  { 101,102,103 }

                              };

            for (int i = 0; i < 3; i++)//treated as row
            {
                for (int j = 0; j < 7; j++)//treated as column
                {
                    Console.Write(details[i,j]+" ");
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("For list sorting");
            
            for (int i = 0; i < list.GetLength(0); i++)//treated as row
            {
                for (int j = 0; j < list.GetLength(1); j++)//treated as column
                {
                    Console.Write(list[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
