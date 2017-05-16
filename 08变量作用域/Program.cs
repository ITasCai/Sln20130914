using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08变量作用域
{
    class Program
    {

        static int n10 = 10;

        public static void M10()
        {
            int n10 = 101;

            if (n10 > 5)
            {
                //int n10 = 100;
                Console.WriteLine(n10);

            }
        }


        //类中成员的默认访问修饰符是private的。

        int age;


        bool b;

        string sss;

        static void Main(string[] args)
        {


            #region MyRegion

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(".");
            //}
            //Console.WriteLine(i);


            //M();
            //M1();
            //M2();
            //Console.ReadKey();

            //int n = 100;
            //if (++n > 100)
            //{
            //    Console.WriteLine(n);

            //    int x = 100;
            //    x++;
            //}
            ////Console.WriteLine("========={0}===============", x);
            //Console.ReadKey();


            #endregion


            int n = 10;
            Console.WriteLine(n++);

            
            ////局部变量要求使用前，必须先声明并且赋值。
            ////类的成员变量有默认值，所以可以不赋默认值。
            //int x;
            //if (n > 5)
            //{
            //    x = 10;
            //}
            //else
            //{
            //   // x++;
            //    x = x + 1;
            //}
            //Console.WriteLine(x);
            //Console.ReadKey();


        }
        static int n = 10;

        static void M()
        {
            Console.WriteLine(n);
        }

        static void M1()
        {
            n++;
            Console.WriteLine(n);
        }
        static void M2()
        {
            n++;
            Console.WriteLine(n);
        }
    }
}
