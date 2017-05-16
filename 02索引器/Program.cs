
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02索引器
{

    class Program
     
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 3, 5, 7, 9 };
            //string str = "ABCDEFG";

            ////索引器的目的就是为了方便而已，可以在该类型的对象后面直接加一对中括号[]就能访问该类型中的成员内容了。
            //Console.WriteLine(str[3]);
            //Console.WriteLine(arr[0]);
            //Console.ReadKey();


            //Person p = new Person();
            //p[0] = 19;
            //Console.WriteLine(p[0]);
            //p[1] = "张三";
            //Console.WriteLine(p[1]);

            //p[2] = "zhangsan@yahoo.com";
            //Console.WriteLine(p[2]);

            //Console.WriteLine(p["age"]);
            //Console.ReadKey();

            //MyClass mc = new MyClass();
            ////mc._cars[0];
            //// mc[0]
            //for (int i = 0; i < mc.Length; i++)
            //{
            //    Console.WriteLine(mc[i]);
            //}
            //Console.ReadKey();

            ItcastClass ic = new ItcastClass();
            ic[0] = "aaaa";
            for (int i = 0; i < ic.NameLength; i++)
            {
                Console.WriteLine(ic[i]);
            }
            Console.ReadKey();
        }
    }




    public class MyClass
    {
        private string[] _cars = new string[] { "奔驰", "宝马", "法拉利", "福特", "布加迪威龙" };

        public int Length
        {
            get
            {
                return _cars.Length;
            }
        }

        //索引器最终编译的的时候会生成一个名字叫Item的属性
        public string this[int index]
        {
            get
            {
                return _cars[index];
            }
            set
            {
                _cars[index] = value;
            }
        }

        //public string Item
        //{
        //    get;
        //    set;
        //}

    }





    public class Person
    {


        //增加一个索引器, 索引器的语法格式与类的属性的语法格式很像、

        private int _age;

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return _age;
                    case 1:
                        return _name;
                    default:
                        return _email;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this._age = Convert.ToInt32(value);
                        break;
                    case 1:
                        this._name = (value == null) ? null : value.ToString();
                        break;
                    default:
                        this._email = (value == null) ? null : value.ToString();
                        break;
                }
            }
        }


        public object this[string key]
        {
            get
            {
                switch (key)
                {
                    case "age":
                        return _age;
                    case "name":
                        return _name;
                    default:
                        return _email;
                }
            }
            set
            {
                switch (key)
                {
                    case "age":
                        this._age = Convert.ToInt32(value);
                        break;
                    case "name":
                        this._name = value == null ? null : value.ToString();
                        break;
                    default:
                        this._email = value == null ? null : value.ToString();
                        break;
                }
            }
        }



        private string _name;


        private string _email;
    }
}
