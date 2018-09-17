using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业1——打印1-10
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //作业2——计算1-100之间所有奇数的和，再计算所有偶数的和
            //int sum1 = 0;
            //int sum2 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    int yushu = i % 2;
            //    switch (yushu)
            //    {
            //        case 1:sum1 += i;
            //            break;
            //        case 0:sum2 += i;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine("1-100之间所有奇数和为{0}\n1-100之间所有偶数和为{1}", sum1, sum2);
            //Console.ReadKey();

            //作业3——打印三角乘法口诀表
            //方法1
            for (int i = 1; i <= 9; i++)
            {
                string suanshi = "";
                for (int j = 1; j <= i; j++)
                {
                    int jieguo = j * i;
                    string suanshi_1 = j + "*" + i + "=" + jieguo + "\t";
                    suanshi += suanshi_1;
                }
                Console.WriteLine(suanshi);
            }
            Console.ReadKey();

            //方法2
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, j * i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
