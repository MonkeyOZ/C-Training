using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09常用的转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("哈尼~我要出去洗头发~");
            Console.WriteLine("哈尼~\n我要出去洗头发~");
            Console.WriteLine("哈尼~我要出去\"洗头发\"~");
            Console.WriteLine("哈尼~\t\t我要出去洗头发~");
            Console.WriteLine("哈尼~我要出去\b\b洗头\b发~");
            Console.WriteLine(@"哈尼~我要出去\b\b洗头\b发~");
            Console.WriteLine(@"哈尼~我要出去\b
            \b洗头\b发~");
            Console.ReadKey();
        }
    }
}
