using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Task_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("add schoolname :");
            string Schoolname=Console.ReadLine();

            Console.WriteLine("add name :");
            string ad = Console.ReadLine();

            Console.WriteLine("add surname :");
             string surnname =Console.ReadLine();

            Console.WriteLine("yasi daxil edin");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("add datebirthyear");
            int il=Convert.ToInt32(Console.ReadLine());



            Student student = new Student(Schoolname, ad, surnname, yas, il); ;   
            student.GoToClasses();
            student.Salam();
            student.ShowAge();

            Teacher teacher = new Teacher(Schoolname, ad, surnname, yas, il,"backend");
            teacher.GoToClasses();
            teacher.Salam();
        }
    }
    
         

          
}
