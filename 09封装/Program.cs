using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _09封装
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyClass mc = new MyClass();

            // // mc.Name = "aaaaa";
            // mc.Name = "niha";
            // mc.Name = "张三";

            //// mc.Name

            // Console.WriteLine(mc.Name);
            // Console.ReadKey();

            //Do("张三", 18, "zs@yahoo.com");

            MyArgs md = new MyArgs();
            md.Email = "lisi@yahoo.com";
            md.Name = "lisi";
            md.Age = 20;
            Do(md);
            Console.ReadKey();


        }

        static void Do(MyArgs model)
        {
            Console.WriteLine(model.Name + "   " + model.Age + "   " + model.Email);
        }


        static void Do(string name, int age, string email)
        {
            Console.WriteLine(name + "   " + age + "   " + email);
        }
    }

    class MyArgs
    {
        public string Name
        {
            get;
            set;
        }

        public int Age { get; set; }

        public string Email { get; set; }
    }

    class MyClass
    {

        private int _age = 19;

        private string _name;

        public string Name
        {
            get
            {
                if (_age > 2)
                {
                    return File.ReadAllText("uname.txt");   //_name;
                }
                return "太小没有名字，Baby";



            }
            set
            {

                if (value.Length > 5)
                {
                    throw new Exception("名字太长");
                }
                else
                {
                    //_name = value;
                    File.WriteAllText("uname.txt", value);
                }

            }
        }
    }
}
