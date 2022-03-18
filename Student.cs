using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    public  class Student
    {
        public event DisplayMsg FailEvent;
        public event DisplayMsg PassEvent;

        public void AcceptMarks(int marks)
        {
            if(marks<40)
            {
                FailEvent(); //we have given call to fail event 
            }
            else
            {
                PassEvent();
            }
        }
    }
}
