using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_1
{
    class Calculator : BasicCalculatorInterface
    {
       public int division (int x, int y)
        {
            Console.WriteLine("Division of two number:"+(x/y) );
            return x / y;

        }

       public int multiplication(int x, int y)
        {
            Console.WriteLine(" multiplication of two number:" + (x * y));
            return x * y;
        }

        public int sub(int x, int y)
        {
            Console.WriteLine(" Subtraction of two number:" + (x - y));
            return x - y;

        }

        public int sum(int x, int y)
        {
            Console.WriteLine("Sum of two number:" + (x + y));
            return x + y;
        }

        public int XtoY(int x, int y)
        {
            Console.WriteLine("XtoY:" + (x^y));
            return x^y;
        }
    }
}
