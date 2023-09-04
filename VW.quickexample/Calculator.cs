using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.quickexample
{
    public class Calculator
    {


        //method overloading
        public int Calculate(int x, int y)
        {
            return x + y;
        }
       
        public double Calculate(double x, double y)
        {
            return x + y;
        }

        public int Calculate(int x, int y, int z)
        {
            return x + y + z;
        }


    }
}
