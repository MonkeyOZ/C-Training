using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08接受用户输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业1
            //写一个“测试自己智商的小程序”
            Console.WriteLine("欢迎使用“驼铃智商监测工具”");
            Console.WriteLine("请输入您的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("请输入您的性别：");
            string gender = Console.ReadLine();
            Console.WriteLine("您的年龄是{0}岁，您的性别是{1}性，经系统鉴定——您的智商为-1。",age,gender);
            Console.ReadKey();

            //作业2
            //写一个和美女搭讪的小程序
            Console.WriteLine("欢迎使用“100%成功搭讪宝典”！");
            Console.WriteLine("请输入想要搭讪的美女的年龄：");
            string age1 = Console.ReadLine();
            Console.WriteLine("请输入想要搭讪的美女的身高：");
            string height = Console.ReadLine();  
            Console.WriteLine("您想搭讪的是一位{0}岁，身高{1}cm的美女。\r\n系统推荐的搭讪用语为：“妞儿哎~去大爷家玩呀~”",age1,height);
            Console.ReadKey();

            //作业3
            //写一个聊天机器人程序
        }
    }
}
