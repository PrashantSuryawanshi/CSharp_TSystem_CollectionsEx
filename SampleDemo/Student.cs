using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Student
    {
        private int roll_No;
        private string sname;
        private double percentage;
        static int count;
        public void stud()
        {
            count++;
            roll_No = count;
            sname = "Joy";
            percentage = 66.88;
        }
        public void studDetails(int rNo,string sn, double per)
        {
            count++;
            roll_No = count;
            sname = sn;
            percentage = per;
        }
       
        public override string ToString()
        {
            return ($"RollNo ::{roll_No} \nStudent Name :: {sname} \nPercentage :: {percentage} \n========================= ");
        }
        
        public void IfElseMethod()
        {
            if (percentage < 40)
                Console.WriteLine("\nStudent is fail.");
            else
                Console.WriteLine("\nStudent is pass");
        }

        static void Main(string[] args)
        {
           
            Student studDetails = new Student();
            studDetails.IfElseMethod();
            studDetails.stud();
           
            Console.WriteLine(studDetails);
            studDetails.studDetails(0, "Raju", 87.56);
            studDetails.IfElseMethod();
            
            Console.WriteLine(studDetails);
            studDetails.studDetails(0, "Rajesh", 97.56);
            studDetails.IfElseMethod();
           
            Console.WriteLine(studDetails);
            studDetails.studDetails(0, "Jon", 67.56);
            studDetails.IfElseMethod();
            
            Console.WriteLine(studDetails);
            studDetails.studDetails(0, "Robert", 34.56);
            studDetails.IfElseMethod();
            Console.WriteLine(studDetails);
            
            //Student studDetails1 = new Student(0,"Raju",87.56);
            //studDetails1.IfElseMethod();
            //Console.WriteLine("\n"+studDetails1);
            
            //Student studDetails2 = new Student(0, "Rajesh", 97.56);
            //studDetails2.IfElseMethod();
            //Console.WriteLine("\n" + studDetails2);
           
            //Student studDetails3 = new Student(0, "Jon", 67.56);
            //studDetails3.IfElseMethod();
            //Console.WriteLine("\n" + studDetails3);
            
            //Student studDetails4 = new Student(0, "Robert", 34.56);
            //studDetails4.IfElseMethod();
            //Console.WriteLine("\n" + studDetails4);

            
        }
    }
}
