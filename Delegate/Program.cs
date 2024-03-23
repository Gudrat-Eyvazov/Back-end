using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        public delegate bool Checker(int a);
        static void Main(string[] args)
        {

            Console.WriteLine( sum(isodd, 5, 7, 12, 8));
        }
        public static int sum(Checker check, params int[] numbers)
        {
            int cemi = 0;
            foreach (int i in numbers)
            {
                if(check(i))
                {
                    cemi += i;
                }
            }
          return cemi;
        }

        public static bool isodd ( int number)
        {
                if(number%2==1)
                {
                    return true;
                }
            
            return false;
        }
        public static bool iseven( int number)
        {           
                if (number % 2 == 1)
                {
                   return true;
                }
            return false;
        }
    }
}
