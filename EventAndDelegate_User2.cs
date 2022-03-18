using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    

    public class EventAndDelegate_User2
    {
        //sequence is access specifier--event keyword --delegate name-- event name 
        public event ErrorDelegate AgeEvent;
        

        public int AcceptAge(int age)
        {
            if(age<18)
            {
                AgeEvent();
            }
            else
            {
                Console.WriteLine("you are eligible for vote");
            }
            return age;
        }


    }
}
