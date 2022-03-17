using System;
using System.Collections;


namespace SampleDemo
{
    public class Collection_StackAndQueue_Ex
    {
     public void stackList()
     {
            Stack st = new Stack();//FILO or LIFO

            st.Push("A");
            st.Push(34);
            st.Push("C");
            st.Push(33.45);
            st.Push("E");
            st.Push("F");

            Console.WriteLine("Current stack ::");
            foreach (string c in st)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine("\n=========================");
            Console.WriteLine("\nRemove Data From Stack ::");
            st.Pop();
            st.Pop();
            st.Pop();
           
            Console.WriteLine("After removing Data From stack ::");
            foreach (object c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\n====================================");
        }
        public void queueList()
        {
            Queue qt = new Queue();

            qt.Enqueue("A");
            qt.Enqueue("B");
            qt.Enqueue("C");
            qt.Enqueue("D");
            qt.Enqueue("E");
            qt.Enqueue("F");
            Console.WriteLine("\nCurrent queue ::");
            foreach (string q in qt)
            {
                Console.Write(q + " ");
            }

            qt.Dequeue();
            qt.Dequeue();
            qt.Dequeue();
            Console.WriteLine("\n==========================================");
            Console.WriteLine("\nAfter removing Data from 'Queue List' ::");

            foreach (string item in qt)
            {
                Console.Write(item+" ");
            }

        }
        static void Main(string[] args)
        {
            Collection_StackAndQueue_Ex list = new Collection_StackAndQueue_Ex();
            list.stackList();
            list.queueList();
               
        }
    }
}
