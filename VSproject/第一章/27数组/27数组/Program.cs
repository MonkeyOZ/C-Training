using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个整数数组，从当中选出最大值，最小值，数组的总和以及平均值。
            //int[] number = { 0, 9, 4, 6, 3, 2, 6 };
            //int max = number[0];
            //int min = number[0];
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (max<number[i])
            //    {
            //        max = number[i];
            //    }
            //    if (min>number[i])
            //    {
            //        min = number[i];
            //    }
            //    sum += number[i];
            //}
            //Console.WriteLine("数组中最大值为：{0}，最小值为：{1}，所有值的总和为：{2}，平均值为：{3}", max, min, sum, Convert.ToDouble(sum) / number.Length);
            //Console.ReadKey();

            ////定义一个string类型的数组，数组当中都是人名分割为：小明|小花|小草|小狗|小JJ
            //string[] name = { "小明", "小花", "小草", "小狗", "小JJ", };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (i+1<name.Length)
            //    {
            //        Console.Write(name[i] + "|");
            //    }
            //    else
            //    {
            //        Console.Write(name[i]);
            //    }
            //}
            //Console.ReadKey();

            //将一个整数数组的每一个元素进行如下处理：
            //如果元素是正数则将这个位置的元素加1，如果元素是负数则将这个位置的元素的值减1，如果元素是0则不变。
            int[] number1 = { -4, -5, 2, 5, 6, 0 };
            for (int i = 0; i < number1.Length; i++)
            {
                if (number1[i]>0)
                {
                    number1[i]++;
                }
                else if (number1[i]<0)
                {
                    number1[i]--;
                }
            }
            for (int i = 0; i < number1.Length; i++)
            {
                Console.Write(number1[i] + "|");
            }
            Console.ReadKey();
        }
    }
}
