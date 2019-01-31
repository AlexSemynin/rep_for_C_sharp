using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_0_Class
{
    class findNumb
    {
        public int MaxNumb(int a, int b)
        {
            int result;
            if ( a > b )
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
    }
}
