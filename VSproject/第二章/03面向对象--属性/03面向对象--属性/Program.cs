using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象__属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Man afeng = new Man();//实例化出一个对象
            afeng.Name = "阿峰";
            afeng.Age = 180;
            afeng.Gender = '兽';
            afeng.Hobby();
            Console.ReadKey();
        }
    }
}
