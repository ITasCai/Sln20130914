using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 声明两个变量：int n1 = 10, n2 = 20;要求将两个变量交换，最后输出n1为20,n2为10。

            //int n1 = 10, n2 = 20;
            //int tmp = n1;
            //n1 = n2;
            //n2 = tmp;
            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();



            ////交换两个变量，不使用第三个变量
            //int n1 = 10, n2 = 20;
            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;
            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();

            //int n1 = 10, n2 = 20;

            //n2 = n1 + (n1 = n2) * 0;
            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();

            #endregion


            #region 交换两个变量，封装成方法

            //int n1 = 10, n2 = 20;

            //Swap(ref n1, ref n2);

            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();

            #endregion


            #region 通过编程计算1+2-3+4-5+6-7+......100的值。
            //int sum = 0;
            ////循环1-100的每个数字
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i == 1 || i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    else
            //    {
            //        //奇数
            //        sum += (i * -1);
            //    }

            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion

            #region 请用户输入一个字符串，计算字符串中的字符个数，并输出。

            //string msg = "你好a!中国";
            ////字符串的Length属性表示字符串中字符的个数，无论中文字符还是英文字符，一个字符就是一个字符，不是字节数。
            //Console.WriteLine(msg.Length);
            //Console.ReadKey();
            #endregion

            #region 定义方法来实现：计算两个数的最大值。提示：方法有几个参数？返回值是什么？【思考】：计算任意多个数间的最大值（提示：params）。

            //Console.WriteLine("请输入一个数字:");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("再次输入一个数字：");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int max = GetMaxValue(n1, n2);
            //Console.WriteLine("最大值是：{0}", max);
            //Console.ReadKey();

            //int max = GetMaxValue(10, 100, 1000, 3243, 43, 234);
            //Console.WriteLine(max);
            //Console.ReadKey();
            #endregion


            #region 计算1-100之间的所有整数的和。
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion

            #region 计算1-100之间的所有奇数的和。

            //int sum = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion

            #region 定义方法来实现：判断一个给定的整数是否为“质数”。Prime Number

            //while (true)
            //{
            //    Console.WriteLine("请输入一个整数：");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    //shift + alt + f10
            //    //ctrl + .
            //    bool b = IsPrimeNumber(n);

            //    Console.WriteLine(b);
            //}


            #endregion


            #region 计算1-100之间的所有质数（素数）的和。

            //int sum = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    // 对于每个数字判断是否是一个质数
            //    if (IsPrimeNumber(i))
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            #endregion


            #region 定义方法来实现：有一个整数数组：{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 },找出其中最大值，并输出。不能调用数组自身的Max()方法，自己定义一个方法。

            //int[] arrNumber = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };

            //int max = GetMaxValueFromArray(arrNumber);

            //Console.WriteLine(max);
            //Console.ReadKey();

            #endregion

            #region 定义方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出字符数最多的字符串。

            ////string[] name = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string[] name = new string[] { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特", "斯图加科维奇某某某" };

            //string userName = GetLongestName(name);
            //Console.WriteLine(userName);
            //Console.ReadKey();


            #endregion

            #region 定义方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }。要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。Math.Round()

            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //double avg = GetAvgFromArray(arrInt);
            ////在msdn中搜索"复合格式"。
            //Console.WriteLine("平均值是：{0:F}", avg);
            //Console.ReadKey();

            #endregion


            #region 请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。

            //int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };

            ////冒泡排序,这个排序方法无需返回值，因为数组本身就是引用类型，引用类型在方法中修改以后，外面的变量可以获得修改后的值，所以不需要返回值
            //MySort(arrInt);

            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    Console.WriteLine(arrInt[i]);
            //}
            //Console.ReadKey();

            #endregion



            #region 请输入一个十进制数字，计算出对应的二进制数字，以字符串方式输出。如：十进制数字120,输出结果为"1111000"。

            //while (true)
            //{
            //    Console.WriteLine("请输入一个十进制数字：");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    //根据10进制数字，返回一个二进制表示方式的字符串
            //    string result = GetBinaryNumber(num);
            //    Console.WriteLine(result);
            //}


            #endregion



            #region 请用户输入一个年份，判断该年份是否为闰年。判断闰年条件：1>能被4整除但不能被100整除2>能被400整除的。


            //while (true)
            //{
            //    Console.WriteLine("请输入一个年份：");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    bool b = IsLeapYear(year);
            //    Console.WriteLine(b);
            //}
            #endregion


            #region 在控制台输出如下显示的“乘法口诀表”。如图：

            //for (int i = 1; i <= 9; i++)
            //{
            //    //当前i是多少，那么内部这个循环就循环多少次
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", j, i, j * i);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            #endregion

            #region 自己编写一个函数，实现类似.net中Trim()函数的功能：去掉字符串两端的空格。
            ////"       A        "
            //string msg = "     你  好  吗？      ";
            //Console.WriteLine("============" + MyTrim(msg) + "===========");
            //Console.ReadKey();

            #endregion

            #region 随机生成10个1-100之间的不重复的偶数，填充到List<int>集合中。
            //List<int> list = new List<int>();
            //Random random = new Random();

            //int index = 0;
            //while (list.Count < 10)
            //{

            //    //随即生成一个1-100之间的数字
            //    int num = random.Next(1, 101);
            //    if (num % 2 == 0 && !list.Contains(num))
            //    {
            //        list.Add(num);
            //    }
            //    index++;
            //}

            ////输出集合中的内容
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("=================================");
            //Console.WriteLine(index);
            //Console.ReadKey();




            //同样的种子，每次生成的随机数是一样的。
            //Random random = new Random(98765);
            //for (int i = 0; i < 20; i++)
            //{
            //    int n = random.Next(1, 101);
            //    Console.WriteLine(n);
            //}
            //Console.ReadKey();



            #endregion


            #region 有如下字符串：【"患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”"】。需求：①请统计出该字符中“咳嗽”一词的出现次数，以及每次“咳嗽”出现的索引位置。②扩展（*）：统计出每个字符的出现次数。

            //string msg = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            ////统计"咳嗽"出现的次数
            ////思路：
            ////使用IndexOf(),该方法返回在整个字符串中，指定的字符或字符串第一次出现的索引位置，如果没有找到指定的字符或者字符串则返回-1
            ////统计次数
            //string word = "咳嗽";
            //int index = 0;//记录索引
            //int count = 0;
            //while ((index = msg.IndexOf(word, index)) != -1)
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现【咳嗽】,出现索引是：{1}", count, index);

            //    //下次查找的时候要从上一次找到的【咳嗽】的索引位置加上”咳嗽“这个字符串的Length，从该新索引之后开始继续查找是否有【咳嗽】出现。
            //    index = index + word.Length;
            //}
            //Console.ReadKey();

            #endregion


            #region 将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"。

            //string msg = "  hello      world,你  好 世界   !    ";
            //msg = msg.Trim();
            ////使用Split
            //string[] result = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            ////把result字符串数组中的每个字符使用' '连起来
            //string str = string.Join(" ", result);
            //Console.WriteLine(str);
            //Console.ReadKey();
            #endregion



            #region 请统计出数组：{1,2,3,4,5,6,7,8,9,1,2,3,79,23,45,64,9,3,2,4}中的不重复的数字的个数。【思考】如果题目要求变更为去除重复数字放到一个新数组中，如何实现？

            //1>统计不重复的元素的个数
            //int[] arrInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 79, 23, 45, 64, 9, 3, 2, 4, 1, 1, 1, 1, 1, 1 };

            ////统计不重复的元素的个数。
            //int count = 0;

            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    bool b = true;
            //    for (int j = 0; j < arrInt.Length; j++)
            //    {
            //        if (arrInt[i] == arrInt[j] && i != j)
            //        {
            //            b = false;
            //            break;
            //        }
            //    }
            //    //如果b为true,则表示没有找到重复的值
            //    if (b)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("不重复的元素的个数是：{0}", count);
            //Console.ReadKey();

            ////2>去除重复
            //int[] arrInt = { 1, 2, 3, 4, 79, 79, 5, 6, 7, 8, 9, 1, 2, 3, 79, 23, 45, 64, 9, 3, 2, 4, 1, 1, 1, 1, 1, 1, 79, 79 };//1,1,1,1,1,2,2,2,3,4,5,6

            ////对数组排序
            //Array.Sort(arrInt);
            //List<int> list = new List<int>();
            ////循环判断数组中的每个元素，是否与下一个元素相等
            //for (int i = 0; i < arrInt.Length - 1; i++)
            //{
            //    if (arrInt[i] != arrInt[i + 1])
            //    {
            //        list.Add(arrInt[i]);
            //    }
            //}
            //list.Add(arrInt[arrInt.Length - 1]);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.ReadKey();

            #endregion



            #region 制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，当用户输入quit（不区分大小写）时，程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名。

            //List<string> list = new List<string>();

            //string userName = string.Empty;
            //do
            //{
            //    Console.WriteLine("请输入姓名：");
            //    userName = Console.ReadLine();
            //    list.Add(userName);
            //} while (userName.ToLower() != "quit");

            //list.RemoveAt(list.Count - 1);
            //Console.WriteLine("共输入了：{0}个学生，每个学生信息是：", list.Count);
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadKey();



            //List<string> list = new List<string>();

            //string userName = string.Empty;
            ////count变量用来统计姓王的同学的个数
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("请输入姓名：");
            //    userName = Console.ReadLine();

            //    //如果姓名的第一个字是"王"
            //    if (userName.IndexOf('王') == 0)
            //    {
            //        count++;
            //    }
            //    list.Add(userName);
            //} while (userName.ToLower() != "quit");

            //list.RemoveAt(list.Count - 1);
            //Console.WriteLine("共输入了：{0}个学生，每个学生信息是：", list.Count);
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("姓王的同学的个数是：{0}", count);
            //Console.ReadKey();


            #endregion

            #region 将普通日期格式：“2011年6月4日” 转换成汉字日期格式：“二零一一年六月四日”。暂时不考虑10日、13日、23日等“带十”的问题。

            //while (true)
            //{
            //    Console.WriteLine("请输入一个日期：");
            //    string date = Console.ReadLine();
            //    date = ConvertDate(date);
            //    Console.WriteLine(date);
            //}


            #endregion


            #region 创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法。

            //




            #endregion




            //判断方法是否重载，只看两点：1>方法名必须一致  2>参数必须不一致。 



            #region 请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法。

            string[] names = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };

            MyReverse(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();


            #endregion

        }

        //反转一下数组中的内容
        private static void MyReverse(string[] names)
        {
            //交换names.Length/2轮
            for (int i = 0; i < names.Length / 2; i++)
            {
                string tmp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = tmp;

            }
        }


        private static void M1()
        {

        }

        //private static string M1()
        //{
        //    return string.Empty;
        //}


        private static int M1(int n)
        {
            return 100;
        }




        //把普通日期转换为中文日期
        private static string ConvertDate(string date)
        {
            //不能直接修改字符串，比如date[0]='零',字符串具有不可变性。

            //先根据字符串date，生成一个char数组（字符数组）
            char[] chs = date.ToCharArray();
            for (int i = 0; i < date.Length; i++)
            {

                #region switch
                switch (chs[i])
                {
                    case '0':
                        chs[i] = '零';
                        break;
                    case '1':
                        chs[i] = '一';
                        break;
                    case '2':
                        chs[i] = '二';
                        break;
                    case '3':
                        chs[i] = '三';
                        break;
                    case '4':
                        chs[i] = '四';
                        break;
                    case '5':
                        chs[i] = '五';
                        break;
                    case '6':
                        chs[i] = '六';
                        break;
                    case '7':
                        chs[i] = '七';
                        break;
                    case '8':
                        chs[i] = '八';
                        break;
                    case '9':
                        chs[i] = '九';
                        break;
                }

                #endregion
            }
            //return date;
            //把char数组变成string类型
            return new string(chs);

        }

        //模拟Trim()去掉字符串两端的空白符
        private static string MyTrim(string msg)
        {
            int start = 0;
            int end = msg.Length - 1;
            //寻找第一个不是空白符的字符的索引，并保存到start变量中。
            while (start < msg.Length)
            {
                if (!char.IsWhiteSpace(msg[start]))
                {
                    break;
                }
                start++;
            }


            //计算最后一个不是空白符的索引
            while (end >= start)
            {
                if (!char.IsWhiteSpace(msg[end]))
                {
                    break;
                }
                end--;
            }
            return msg.Substring(start, end - start + 1);

        }

        //判断是否是闰年
        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetBinaryNumber(int num)
        {
            #region 1
            ////拼接字符串用StringBuilder
            //StringBuilder sb = new StringBuilder();
            //while (num >= 2)
            //{
            //    //商
            //    int shang = num / 2;
            //    //余数
            //    int yushu = num % 2;
            //    sb.Append(yushu);
            //    //把本次计算的商赋值给num变量
            //    num = shang;
            //}
            //sb.Append(num);
            //return sb.ToString();
            #endregion


            //拼接字符串用StringBuilder
            List<string> list = new List<string>();
            while (num >= 2)
            {
                //商
                int shang = num / 2;
                //余数
                int yushu = num % 2;
                list.Add(yushu.ToString());
                //把本次计算的商赋值给num变量
                num = shang;
            }
            list.Add(num.ToString());
            list.Reverse();
            return string.Join("", list.ToArray());

        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arrInt"></param>
        private static void MySort(int[] arrInt)
        {
            //外层循环条件是比较的轮数，相邻两个比较要比较多少轮。
            for (int i = 0; i < arrInt.Length - 1; i++)
            {
                //这个循环使用来进行相邻两两比较的，从索引最后一个开始与前一个比较
                for (int j = arrInt.Length - 1; j > i; j--)
                {
                    if (arrInt[j] < arrInt[j - 1])
                    {
                        int tmp = arrInt[j];
                        arrInt[j] = arrInt[j - 1];
                        arrInt[j - 1] = tmp;
                    }
                }
            }
        }

        private static double GetAvgFromArray(int[] arrInt)
        {
            int sum = 0;

            for (int i = 0; i < arrInt.Length; i++)
            {
                sum += arrInt[i];
            }

            //Math.Round()对数字执行四舍五入。

            return Math.Round(sum * 1.0 / arrInt.Length, 2);
        }

        private static string GetLongestName(string[] name)
        {
            string longName = name[0];
            for (int i = 1; i < name.Length; i++)
            {
                if (name[i].Length > longName.Length)
                {
                    longName = name[i];
                }
            }
            return longName;
        }

        private static int GetMaxValueFromArray(int[] arrNumber)
        {
            int max = arrNumber[0];
            for (int i = 1; i < arrNumber.Length; i++)
            {
                if (arrNumber[i] > max)
                {
                    max = arrNumber[i];
                }
            }
            return max;
        }

        //判断一个整数是否是一个质数
        private static bool IsPrimeNumber(int n)
        {
            if (n > 1)
            {
                //Math.Sqrt();//开平方
                //循环判断除了1，与n本身以外，小于n的其他自然数中是否还有其他数字可以被整除
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                throw new ArgumentException("数字小于1不是质数！");
            }
        }





        static int GetMaxValue(params int[] nums)
        {
            //对数组nums中的元素求最大值
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        static int GetMaxValue(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }


        ////定义方法的时候职责一定要单一，方法中只做对应的处理，保证任何地方都可以调用该方法
        ////如果像下面这样编写方法，则该方法依赖于控制台程序，要求被比较的两个值必须是控制台输入的两个值。
        //static void GetMaxValue()
        //{
        //    Console.WriteLine("请输入一个数字:");
        //    int n1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("再次输入一个数字：");
        //    int n2 = Convert.ToInt32(Console.ReadLine());
        //    if (n1 > n2)
        //    {
        //        Console.WriteLine("最大值是{0}", n1);
        //    }
        //    else
        //    {
        //        Console.WriteLine("最大值是{0}", n2);
        //    }
        //}


        private static void Swap(ref int n1, ref int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
    }
}
