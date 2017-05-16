using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //子类 is a 父类
        }
    }


    //继承的好处：1>代码重用  2>多态
    //继承特性：1>单根性。【C#中不允许多继承，一个类只能继承自一个父类。】 2>传递性。
    //父类 比子类范围更大，更抽象。 子类更具体。

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public int Height { get; set; }

    }

    class Player
    {

    }

    class Student : Person
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string SNO { get; set; }
    }

    class Teacher : Person
    {
        public double Salary { get; set; }
    }
}
