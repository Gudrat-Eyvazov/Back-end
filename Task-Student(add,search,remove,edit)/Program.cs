using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentllists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                Console.WriteLine("select operation");
                Console.WriteLine("1-Add student\n2-Search student\n3-remove student \n 4-edit ");
                int secim= Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        student.Addstudent();
                        break;
                    case 2:
                        
                        student.Searchstudent();
                      
                        break;
                    case 3:
                        student.remove();
                        break;
                    case 4:
                        student.edit();
                        break;
                    default:
                        Console.WriteLine("yalniz gosterilen emeliyatlar movcudur ");
                        break;
                }
                 
               





            }

        }
    }
}
