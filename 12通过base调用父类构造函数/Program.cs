using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12通过base调用父类构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //Father ff = new Father("aa", 99, "ab");

            //Son son = new Son("张三", 1000, "AB");

            //Father fat = new Father("张三", 10000, "O");

            //Son son = new Son("ZhangsanSon", 1000, "AB");


            //M1(son);
            //Console.ReadKey();
            //object obj = new Son();

            //里氏替换原则，要的是一个父类类型对象，给的是一个子类类型对象。
            //里氏替换原则反过来是不行的。
            Father ff = new Son("李四", 99999, "A");
            //ff.LastName;

            //Father ff = new Father();

            //Son son = new Son();

            object o = new Father("aa", 9999, "A");

            //错误！！！！
            //Son ss = new Father("王五", 999999, "AB");
        }

        static void M1(Father father)
        {
            Console.WriteLine(father.LastName);
        }
    }

    class Father
    {
        public Father(string xingming, double caichan, string xuexing)
        {
            this.LastName = xingming;
            this.Property = caichan;
            this.BloodType = xuexing;
        }

        public string LastName { get; set; }
        public double Property { get; set; }
        public string BloodType { get; set; }
    }

    class Son : Father
    {
        public Son(string xm, double cc, string xx)
            : base(xm, cc, xx)
        {

        }

        public void PlayGame()
        {
            Console.WriteLine("Dota中.....");
        }
    }

    //class Daughter : Father
    //{
    //    public void Dance()
    //    {
    //        Console.WriteLine("热歌劲舞！！！！！！");
    //    }
    //}
}
