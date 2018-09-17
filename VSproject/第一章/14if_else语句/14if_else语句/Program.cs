using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14if_else语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业1——身高大于180，长度大于18才可以观看电影；身高等于200，长度大于16则可以免费观看。
            //Console.WriteLine("想要观看电影，请输入您的身高：");
            //int height = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请再输入您的长度：");
            //int length = Convert.ToInt32(Console.ReadLine());
            //if (height == 200 && length > 16)
            //{
            //    Console.WriteLine("哎呦~像您这样双长的人真是人间少有啊！您可以免费观看电影");
            //}
            //else if (height > 180 && length > 18)
            //{
            //    Console.WriteLine("您的身材很标准，可以观看电影");
            //}
            //else
            //{
            //    Console.WriteLine("您的身材不达标，禁止观看电影");
            //}
            //Console.ReadKey();

            //作业2——如果阿峰的考试成绩大于等于60分，他爸爸就会举高高，否则就是一顿毒打。
            Console.WriteLine("阿峰！不要再隐瞒了，老实交代你的成绩！");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score>=60)
            {
                Console.WriteLine("乖儿子！不枉爸爸的教导，你终于及格了！");
            }
            else
            {
                Console.WriteLine("我真怀疑你是不是我亲生的，你自行了断吧！");
            }
            Console.ReadKey();

        }
    }
}
