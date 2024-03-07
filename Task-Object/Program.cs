using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace @object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var car = new { marka = "bmw", prize = 500, color = "black", model = 60 };
            //object car2 = new { marka = "mercedes", prize = 300, color = "white", model = 204 };
            //dynamic[] carlist = new[] { car, car2 };
            //Console.WriteLine(car.marka);
            //Console.WriteLine(carlist[1].marka);

            // object[] students = new object[3];
            // for (int i=0; i<students.Length; i++) { 
            //Console.WriteLine("telebe adini daxil edin :");
            //string name = Console.ReadLine();
            //Console.WriteLine("telebe soyadini daxil edin :");
            //string surname = Console.ReadLine();
            //Console.WriteLine("telebe yasini daxil edin :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //var studentlist = new { ad = name, soyad = surname, yas = age };
            //students[i] = studentlist;
            // }

            ArrayList students = new ArrayList();
           
            while (true)
            {

                Console.WriteLine("1-student add");
                Console.WriteLine("2-student search");
                Console.WriteLine("3-student remove");
                Console.WriteLine("4-exit");
                char emeliyyat = Convert.ToChar(Console.ReadLine());
                if (emeliyyat == '1')
                {


                    Console.WriteLine("telebe adini daxil edin");
                    string name = Console.ReadLine();
                    Console.WriteLine("telebe soyadini daxil edin");
                    string surname = Console.ReadLine();
                    Console.WriteLine("telebe yasini daxil edin");
                    byte age = Convert.ToByte(Console.ReadLine());
                    object student = new { ad = name, soyad = surname, yas = age };
                    students.Add(student);


                }
                else if (emeliyyat == '2')
                {
                    Console.WriteLine("axtardiqiniz telebenin adini qeyd edin");
                        string name = Console.ReadLine();
                    foreach (dynamic telebe in students)
                    {
                        if (name == telebe.ad)
                        {
                            Console.WriteLine(telebe.ad + " " + telebe.soyad +" " +telebe.yas);
                            break;
                        }
                    } 

                }
                else if (emeliyyat == '3')
                {
                    Console.WriteLine("silmek istediyniz telebenin adini daxil edin :");
                    string telebeadi = Console.ReadLine();
                    foreach (dynamic telebe in students)
                    {
                        if (telebeadi == telebe.ad)
                        {
                            students.Remove(telebe);
                            Console.WriteLine("silindi");
                            break;
                        }
                    }
                }
                else if (emeliyyat == '4')
                {
                    Console.WriteLine("sistemden ugurla cixildi");
                    break;
                }

            }




        }
    }
}
