using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    public class Custom_Exception:Exception
    {
        public Custom_Exception(string msg):base(msg)
        {

        }
    }
    public class User
    {
        public int AcceptAge(int age)
        {
            if(age<18)
            {
                throw new Custom_Exception("this user is not valid for vote");
            }
            return age;
        }
    }
}
