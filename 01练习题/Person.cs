using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01练习题
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        //自动属性
        public string Gender
        {
            get;
            set;
        }

        public int Age { get; set; }


        public virtual void SayHi()
        {
            Console.WriteLine("Hi~~~ in Person");
        }
    }
}
