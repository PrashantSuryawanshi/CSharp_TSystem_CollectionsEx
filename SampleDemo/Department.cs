using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Department
    {
        //private int id;
        //private string dname;

        //public int Id
        //{
        //    set { id = value; }//value is build in keyword which assign the vale
        //    get { return id; }
        //}
        //public string DName
        //{
        //    set { dname = value; }
        //    get { return dname; }
        //}
        //auto implimentation properties
        public int Id { get; set; }
        public string DName { get; set; }
        static void Main(string[] args)
        {
            //property initializer
            Department d1 = new Department();
            d1.Id = 1;
            d1.DName = "HR";

            Console.WriteLine(d1.Id + "   " + d1.DName);//get
            //object initializer
            Department d2 = new Department { Id = 2, DName = "Admin" };
            Console.WriteLine(d2.Id + "   " + d2.DName);
        }
      
    }
}
