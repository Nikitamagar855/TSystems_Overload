using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Overload
{
    class Calculation
    {
        public int addition(int a, int b)
        {
            return a + b;

        }
        public int addition(int a, int b, int c)//methode overloading = same methode name different parameter
        {
            return a + b + c;

        }
        public double addition(int a, double b)
        {
            return a + b;
        }

        
    }
}