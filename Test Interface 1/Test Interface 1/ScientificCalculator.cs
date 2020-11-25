using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_1
{
    class ScientificCalculator: ScientificCalculatorInterface
    {
        public ScientificCalculator()
        {

        }

        public int XtoY(int x, int y)
        {
            Console.WriteLine("X To Y : " + Convert.ToInt32(Math.Pow(x, y)));
            return Convert.ToInt32(Math.Pow(x, y));
        }
    }
}
