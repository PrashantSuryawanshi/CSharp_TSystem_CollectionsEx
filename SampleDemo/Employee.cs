using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Employee
    {
        static int count;//default value is zero (o) in static
        protected int empid;
        protected string empname;
        protected double basicSalary, hra, da, pf, grossSalary;

        public Employee()
        {
            count++;
            empid = count;
            empname = "Jone";
            basicSalary = 3400.00;
        }
        public Employee(int empid, string empname, double basicSalary)
        {
            count++;
            this.empid = count;
            this.empname = empname;
            this.basicSalary = basicSalary;
        }
        public virtual void CalculateSalary()
        {
            hra = basicSalary * 0.40;
            da = basicSalary * 0.20;
            pf = basicSalary * 0.12;
            grossSalary = (basicSalary + hra + da) - pf;
        }
        public static int Getcount()
        {
            return count;
        }

        public override string ToString()
        {
            return ($"Employee Data :: \n       ID :: {empid} \n       Name ::{empname} \n       basicSalary ::{basicSalary} \n       GrossSalary ::{grossSalary}");
            //($"\nHRA ::{hra} \nDA ::{da} \nPF::{pf} \nGrossSalary ::{grossSalary}")
        }


    }
}
