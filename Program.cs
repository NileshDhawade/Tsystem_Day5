using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    public delegate void ErrorDelegate(); // this delegate is regarding delegate implementations 
    public delegate void DisplayMsg();
    
    public class Program
    {

        static void ErrorMsg()  // this method is regarding delegate implementation ...see delegate implementation following 
        {
            Console.WriteLine("this user is not valid for votes");

        }

        static void FailMsg()
        {
            Console.WriteLine("Oops ..you are fail:");
        }
        static void PassMsg()
        {
            Console.WriteLine("Congratulations... you are pass:");
        }

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

            Console.WriteLine("=========Event and delegates========");

            EventAndDelegate_User2 ed = new EventAndDelegate_User2();
            ed.AgeEvent += new ErrorDelegate(ErrorMsg);
            ed.AcceptAge(20);

            Console.WriteLine("----------------------------------------------");
            Student st = new Student();
            st.FailEvent += new DisplayMsg(FailMsg);
            st.PassEvent += new DisplayMsg(PassMsg);
            st.AcceptMarks(45);



           
        }
    }
}
