using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01练习题
{
    public class Employee : Person
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public override void SayHi()
        {
            Console.WriteLine("Hi~~~ in Employee");
        }


    }
}
