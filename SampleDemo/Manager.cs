using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Manager : Employee
    {
        private double foodAllonce, trevAllonce, cAllonce;

        public Manager() : base() //it will call base class constructor
        {
            ////foodAllonce = 0.00;
            trevAllonce = 0.00;
            cAllonce = 0.00;
        }
        public Manager(int id, string nm, double bs, double foodAllonce, double trevAllonce, double cAllonce) : base(id, nm, bs)
        {
            this.foodAllonce = foodAllonce;
            this.trevAllonce = trevAllonce;
            this.cAllonce = cAllonce;
        }
        public override void CalculateSalary()
        {
            hra = basicSalary * 0.40;
            da = basicSalary * 0.20;
            pf = basicSalary * 0.12;
            grossSalary = (basicSalary + hra + da + foodAllonce + trevAllonce + cAllonce) - pf;
        }
        public override string ToString()
        {
            return ($"Employee Data :: \n       ID :: {empid} \n       Name ::{empname} \n       basicSalary ::{basicSalary} {"\n"}\nFoodAllonce :: {foodAllonce} \nTravlingAllonce ::{trevAllonce} \nComitonAllonce ::{cAllonce}{"\n======================="}");
        }
    }
}

