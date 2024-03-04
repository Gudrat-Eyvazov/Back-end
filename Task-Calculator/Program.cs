using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean sert = true;
            while (sert) { 
                Console.WriteLine("calculatar");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("hansı emeliyyatı yerine yetirmek isteyirsininz :");
            Console.WriteLine("emeliyyatlar +  -  *  /");
            char emeliyyat = Convert.ToChar(Console.ReadLine());
            Console.Write("birinci ededi daxil edin :");
            int birinciEded = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil edin :");
            int ikinciEded = Convert.ToInt32(Console.ReadLine());


            if (emeliyyat == '+')
            {

                Console.WriteLine("cemi :" + (birinciEded + ikinciEded));
            }
            else if (emeliyyat == '-')
            {
                if (birinciEded > ikinciEded)
                {
                    Console.WriteLine("ferqi :" + (birinciEded - ikinciEded));
                }
                else { Console.WriteLine("cavabimiz menfi ededdir "); }
            }
            else if (emeliyyat == '*')
            {
                Console.WriteLine("hasili :" + (birinciEded * ikinciEded));
            }
            else if (emeliyyat == '/')
            {
                if (ikinciEded != 0)
                {
                    Console.WriteLine("nisbeti :" + (birinciEded / ikinciEded));
                }
                else
                {
                    Console.WriteLine(" bolen 0 ola bilmez");
                }
            }
            else
            {
                Console.WriteLine(" bu calculatorda bele bir emeliyyat yoxdur");
            }
        }
        }
    }
}
