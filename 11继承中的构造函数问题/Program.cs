using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11继承中的构造函数问题
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileStream fs = new FileStream(@"c:\aa.txt", FileMode.Create);

            Teacher t1 = new Teacher("杨中科", 18, "yzk@itcast.cn", 1000000);

            Student s1 = new Student("陈超", 19, "cz@yahoo.com", "100001");


        }
    }


    //构造函数不能被继承。
    //由于在创建子类对象的时候，一定会调用子类的构造函数，而任何一个子类构造函数默认情况下都会去调用父类的无参数的构造函数，所以当父类中没有无参数的构造函数时就出错了。
    //解决办法：
    //1>在父类中增加一个无参数的构造函数

    //或者

    //2>在子类中指定子类的构造函数调用父类中的有参数的那个构造函数。
    class Person
    {
        public Person()
        {
            Console.WriteLine("========================");
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }



        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Teacher : Person
    {
        public Teacher(string name, int age, string email, double salary)
            : base(name, age, email)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Email = email;
            this.Salary = salary;
        }
        public double Salary { get; set; }
    }

    class Student : Person
    {
        //通过:base(),手动指定子类个构造函数去调用父类的哪个构造函数。
        //注意执行顺序是:先调用父类的构造函数，然后再执行子类自己的构造函数。 
        public Student(string name, int age, string email, string sno)
            : base(name, age, email)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Email = email;
            this.SNo = sno;
        }
        //学号
        public string SNo { get; set; }
    }



    //通过:this()调用本类中的其他构造函数

    //:base()调用父类的构造函数

    //:this()调用当前类中的其他构造函数。
    public class MyClass
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string Email { get; set; }

        public MyClass()
        {

        }

        public MyClass(string name, int age)
            : this(name, age, 0, null)
        {

        }
        public MyClass(string name, string email)
            : this(name, 0, 0, email)
        {

        }
        public MyClass(string name, int age, int height, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Email = email;
        }
    }
}
