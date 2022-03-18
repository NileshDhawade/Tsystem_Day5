using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    public class Program
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

            Console.WriteLine("========Exception Handeling=========");

            int a1 = 4, b1 = 0, c1;

            try
            {
                c1 = a1 / b1;
                Console.WriteLine("division is " + c1);
            }
            catch(Exception ex)    // if we have exception in try bolck then direct control comes to catch block
                                   // and will display the message in try block
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("int the finally block");
            }
            Console.WriteLine("-----------custom exception-----------");
            User u = new User();
            try
            {
                int age = u.AcceptAge(13);
                Console.WriteLine("your age is " + age);
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
