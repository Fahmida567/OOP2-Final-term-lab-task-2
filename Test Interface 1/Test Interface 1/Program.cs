using System;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.sum(500, 400);
            c.sub(5, 4);
            c.multiplication(5, 4);
            c.division(5, 4);
          
            Console.WriteLine(" ");
            ScientificCalculator s = new ScientificCalculator();
            s.XtoY(5, 2);


        }
    }
}
