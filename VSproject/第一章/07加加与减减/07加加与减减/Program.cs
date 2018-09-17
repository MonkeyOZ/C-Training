using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07加加与减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++ + ++a * 3 + --a + a++;
            //      10     12        11   11
            //a=12
            //一元运算符和二元运算符同时存在时，优先计算一元运算符。
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
