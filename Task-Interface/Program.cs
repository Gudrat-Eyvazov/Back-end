
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine( calculator.sum(5.7, 12.5));
            Console.WriteLine(calculator.Multiply(5,7,7,8));
            Console.WriteLine(calculator.Difference(77,12));
            Console.WriteLine(calculator.Divide(5,12));

        }
    }
}
