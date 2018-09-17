using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：求两个数的最大值，用函数；
            //练习2：判断闰年。
            Console.WriteLine("请输入第一个数字：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int b = Convert.ToInt32(Console.ReadLine());
            int max = Program.Max(a, b);
            Console.WriteLine("这两个数中较大的为：{0}",max);
            Console.ReadKey();

            Console.WriteLine("请输入年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.LeapYear(year));
            Console.ReadKey();
        }

        public static int Max(int a, int b)//求两个数的最大值
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public static string LeapYear(int a)//判断闰年
        {
            if (a % 4 == 0 && a % 100 != 0)
            {
                return "是闰年";
            }
            else if (a % 400 == 0)
            {
                return "是闰年";
            }
            else
            {
                return "不是闰年";
            }
        }
    }
}
