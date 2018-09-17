using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12关系运算符与逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业2——让用户输入自己的语文与数学成绩。
            //判断1.两科都大于90分；2.语文与数学有一门大于90分。
            //Console.WriteLine("请输入你的语文成绩：");
            //string chinese = Console.ReadLine();
            //Console.WriteLine("请输入你的数学成绩：");
            //string math = Console.ReadLine();
            //int chineseInt = Convert.ToInt32(chinese);
            //int mathInt = Convert.ToInt32(math);
            //bool x1 = chineseInt > 90 && mathInt > 90;
            //bool x2 = chineseInt > 90 || mathInt > 90;
            //Console.WriteLine("你的成绩是否都大于90分？答案是{0}。\n你的成绩是否至少有一科大于90分？答案是{1}。", x1, x2);
            //Console.ReadKey();

            //作业3——判断是否是闰年
            Console.WriteLine("请输入年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isNot0 = year != 0;
            bool chu4 = year % 4 == 0;
            bool chu100 = year % 100 == 0;
            bool chu400 = year % 400 == 0;
            bool leapYear1 = chu4 && !chu100 && isNot0;
            bool leapYear2 = chu400 && isNot0;
            bool isLeapYear = leapYear1 || leapYear2;
            Console.WriteLine("你输入的年份是否是闰年呢？答案是{0}",isLeapYear);
            Console.ReadKey();


        }
    }
}
