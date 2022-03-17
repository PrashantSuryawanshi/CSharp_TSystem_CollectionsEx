using System;
using System.Collections.Generic;

namespace SampleDemo
{
    public class Stack_Queue_generic_Ex
    {
        public void list_of_stack()
        {

            Stack<string> st = new Stack<string>();

            st.Push("A");
            st.Push("C");
            st.Push("E");
            st.Push("F");

            Console.WriteLine("Current stack ::");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\n=========================");
            Console.WriteLine("\nRemove Data From Stack ::");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("After removing Data From stack ::");
            foreach (string c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\n====================================");

        }
        static void Main(string[] args)
        {
            Collection_StackAndQueue_Ex list = new Collection_StackAndQueue_Ex();
            list.stackList();
           // list.queueList();

        }


    }
}
