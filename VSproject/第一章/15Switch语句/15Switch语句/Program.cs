using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("客人您好！本店有ABCDE五种套餐，请问您想购买哪种？");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "A":Console.WriteLine("这是您要的A套餐：一杯奶茶加被人咬过一口的馒头。");
                    break;
                case "B":Console.WriteLine("这是您要的B套餐：一杯奶茶加一个被人咬过两口的馒头。");
                    break;
                case "C":Console.WriteLine("这是您要的C套餐：一杯被人喝过的奶茶加被人咬过两口的馒头。");
                    break;
                case "D":Console.WriteLine("这是您要的D套餐：一杯水加被人吃了一半的馒头。");
                    break;
                case "E":Console.WriteLine("这是您要的E套餐：一杯被人喝过的水加被人吃了一半的馒头。");
                    break;
                default:Console.WriteLine("想必您是聋子吧？说了只有ABCDE五种套餐。");
                    break;
            }
            Console.ReadKey();
        }
    }
}
