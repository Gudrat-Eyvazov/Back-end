using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_accaunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adiniz daxil edin");
            string name = Console.ReadLine();   
            Console.WriteLine("gmail adiniz daxil edin");
            string gmail = Console.ReadLine();
            Console.WriteLine("parolunuznu daxil edin:");
            string sifre = Console.ReadLine();
           
            User user  = new User(gmail,sifre);
            user.FullName = name;
            user.ShowInfo();
            Console.WriteLine(user.Password);
        }
    }
}
