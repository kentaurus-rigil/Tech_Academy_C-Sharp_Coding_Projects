using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment219
{
    public class Class1
    {
        public int method(int x)
        {
            int results = x + 5;
            return results;
        }
        public double method(double x, double y)
        {
            return x - y;
        }
        public int method(string x, string z)
        {
            
            int newNum = Convert.ToInt32(x);
            int newNum2 = Convert.ToInt32(z);
            return newNum / newNum2;

        }
    }
    }




//public int methodThree(int x)
//{
//    int results = x / 2;
//    return results;
//}
//    }
//}
