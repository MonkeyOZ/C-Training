using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06运算符和占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业1
            //打印一个人的信息
            int age = 28;
            string name = "Mortimer";
            char gender = '男';
            string job = "Game Designer";
            float money = 23.33f;
            double IQ = 100.0000001;
            Console.WriteLine("{0}是一位{1}岁的{2}性{3}，收入{4}，IQ{5}。", name, age, gender, job, money, IQ);
            Console.ReadKey();

            //作业2
            //计算100+0.1
            int num1 = 100;
            float num2 = 0.1f;
            float num3 = num1 + num2;
            Console.WriteLine(num3);
            Console.ReadKey();

            //作业3
            //小明有3条腿，裤子店一个裤腿36元。问小明买一条裤子多少钱，打了8折之后多少钱。
            int leg = 3;
            int pricePerTrouser = 36;
            int legPerTrouses = 2;
            float discount = 0.8f;
            int pricePerTrousers = pricePerTrouser * legPerTrouses;
            float priceOnSale = pricePerTrousers * discount;
            Console.WriteLine("小明买一条裤子花{0}元，打了8折之后花{1}元。", pricePerTrousers, priceOnSale);
            Console.ReadKey();

        }
    }
}
