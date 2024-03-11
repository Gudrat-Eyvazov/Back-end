using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "sinan";
            string surname = "eyvazov";
            string a = String.Concat(ad, surname);
            Console.WriteLine(a);


            string metn = "the best player in the world lionel messi";
            bool e = metn.Contains("be");
            Console.WriteLine(e);
            int j= String.Compare("sinan", "sinan");
            Console.WriteLine(j);
          string metn5= metn.Trim();
            Console.WriteLine(metn5);
            string metn1 = metn.ToLower();
            Console.WriteLine(metn1);

            string metn2 = metn1.ToUpper();
            Console.WriteLine(metn2);

            string metn3 = (string)metn1.Clone();
            Console.WriteLine(metn3);

            bool metn4 = metn1.EndsWith("i");
            Console.WriteLine(metn4);

            bool metn11 = metn1.StartsWith("m");
            Console.WriteLine(metn11);

            int metn6 = metn1.IndexOf("the");
            Console.WriteLine(metn6);

            string metn7 = metn1.Insert(19, "all time");
            Console.WriteLine(metn7);

            string metn8 = metn1.Substring(16);
            Console.WriteLine(metn8);

            string metn9 = metn1.Replace("world", "galaxy");
            Console.WriteLine(metn9);

            string metn10 = metn1.Remove(29, 7);
            Console.WriteLine(metn10);

        }
    }
}
