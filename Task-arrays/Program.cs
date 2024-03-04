using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int sum = 0, count = 0;
            foreach (int nums in arr)
            {

                if (nums == 5)
                {
                    count++;

                }

                sum += nums;

            }
            Console.WriteLine("5 ededinin tekrarlanma Sayi :" + count);
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("butun ededlerin cemi :" + sum);
            Console.WriteLine("---------------------------------------------");


            int index = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;

                }
            }
            Console.WriteLine("arraydaki en boyuk ededin indexi :" + index);
            Console.WriteLine("-------------------------------------------------");
            int tekrarlanmasayi = 0;
            int enboyuk = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (enboyuk < arr[i])
                {
                    enboyuk = arr[i];
                    tekrarlanmasayi++;

                }

            }
            Console.WriteLine("en boyuk ededin tekrarlanma sayi :" + tekrarlanmasayi);
            Console.WriteLine("------------------------------------------------------");
            bool varmi = false;
            string name = "gudrat";
            int a = name.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (a == arr[i])
                {
                    varmi = true;
                    // Console.WriteLine("adinizdaki herflerin sayi arrayda var : " + varmi);
                    break;
                }
                else
                {
                    varmi = false;
                }
            }
            Console.WriteLine("adinizdaki herflerin sayi arrayda yoxdur : " + varmi);
            Console.WriteLine("------------------------------------------------------");

        }

    }
}

