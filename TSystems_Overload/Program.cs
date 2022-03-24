using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
           
            Console.WriteLine(c.addition(10,22));

            Console.ReadLine();
        }
    }
}
