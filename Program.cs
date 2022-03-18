using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====out keyword implementation=====");
            Out_Keyword ok = new Out_Keyword();
            int a = 20, b = 10;
            int add, sub, mult, div;
            ok.Calculation(a, b, out add, out sub, out mult, out div);

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            
        }
    }
}
