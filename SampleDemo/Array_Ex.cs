using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Array_Ex
    {
        static void Main(string[] args)
        {
            //Index of arrey start from 0
            int[] weekDays = new int[7] { 1, 2, 3, 4, 5 ,6,7};
            int[] list1 = new int[7] ;

            string[] branch_list = { "IT", "Civil", "Mechanical", "E&Tc" };

            Console.WriteLine("Week Days after sorting::");
            for (int i = 0; i < weekDays.Length;  i++)
            {
                Console.WriteLine(weekDays[i]);
                           
            }
            Console.WriteLine("==========================");
            
            Array.Reverse(weekDays);
            Console.WriteLine("Reverse Array using reverse Method");
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
            Console.WriteLine("===========================");

            //Array.Clear(weekDays, 3, 4);
            //Console.WriteLine("Clear Data Index 3,4 ::");
            //for (int i = 0; i < list1.Length; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //Console.WriteLine("=======================");
            
            Array.Copy(weekDays,list1,7);            
            Console.WriteLine("Copid data");
            
            for (int i=0;i<list1.Length;i++)
            {
                Console.WriteLine(list1[i]);
            }
            
            Console.WriteLine("======================");
            for (int i = 0; i < branch_list.Length; i++)
            {
               
                Console.WriteLine(branch_list[i]);
            }
            Console.WriteLine("======================");
            Array.Reverse(branch_list);
            Console.WriteLine("Reverse Array using reverse Method");
            for (int i = 0; i < branch_list.Length; i++)
            {
                Console.WriteLine(branch_list[i]);
            }
            //Array.Sort(weekDays);
            //Console.WriteLine("Array After Sorting");
            //for(int i=0;i< weekDays.Length;i++)
            //{
            //    Console.WriteLine(weekDays[i]);
            //}

        }


    }
}
