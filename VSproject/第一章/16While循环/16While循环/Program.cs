using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16While循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业1——1+~100=？
            //int a = 1;
            //int b = 0;
            //while (a<=100)
            //{
            //    b = b + a;//或者用b += a
            //    a++;

            //}
            //Console.WriteLine("1+2+3+...+100={0}", b);
            //Console.ReadKey();

            //作业2——计算女生颜值，输入女生数量和依次的颜值，输出总分和平均分。
            Console.WriteLine("请输入班级中女生的数量：");
            int num = Convert.ToInt32(Console.ReadLine());
            int sort = 0;
            int yanzhi = 0;
            if (num>0)
            {
                while (sort < num)
                {
                    Console.WriteLine("请输入第{0}位女生的颜值（-100~100）：", sort + 1);
                    yanzhi = yanzhi + Convert.ToInt32(Console.ReadLine());
                    sort++;
                }
                double average = yanzhi / num;
                Console.WriteLine("根据系统计算，你班里女生的颜值总和为{0}，平均颜值为{1}", yanzhi, average);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("摸摸头~寺庙的生活不好过吧？");
                Console.ReadKey();
            }
            
        }
    }
}
