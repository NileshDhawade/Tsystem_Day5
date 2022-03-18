using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day5
{
    public  class Out_Keyword
    {
        public  void Calculation(int n1,int n2,out int add,out int sub,out int mult,out int div)
        {
            add = n1 + n2;
            sub = n1 - n2;
            mult = n1 * n2;
            div = n1 / n2;
        }
    }
}
