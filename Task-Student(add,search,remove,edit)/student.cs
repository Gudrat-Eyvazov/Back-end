using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentllists
{
    internal class student
    {
       
        public static List<student> students = new List<student>();
        public int ID { get; set; }
        public string name { get; set; }
        public string surname{ get; set; }
        public int number { get; set; }

        public static int count;
        public student(string ad,string soyad,int id)
        {
            name = ad;
            surname = soyad;
            ID = id;
            count++;
            number = count;
        }
        public static void Addstudent()
        {
            Console.WriteLine("write the student name:");
            string sagirdadi = Console.ReadLine();

            Console.WriteLine("write the student surname :");
            string sagirdsoyadi = Console.ReadLine();

            Console.WriteLine("write the student ID ");
            int id = Convert.ToInt32(Console.ReadLine());

            student student1 = new student(sagirdadi, sagirdsoyadi, id);
            students.Add(student1);
            Console.WriteLine(student1.number);
            Console.WriteLine("student added");
            
        }
        public static void Searchstudent()
        {
            Console.WriteLine("write the student ID");
            int idd = Convert.ToInt32(Console.ReadLine());
            foreach (var item in students)
            {
                if (idd == item.ID)
                {
                    Console.WriteLine("student name :" + item.name + "  student surname: " + item.surname + " student id : " + item.ID);
                    break;
                }
            }
        }
        public static void remove()
        {
            Console.WriteLine("write student number");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (var item in students)
            {
                if(num == item.number)
                {
                    students.Remove(item);
                }
            }
        }
        public static void edit()
        {
            Console.WriteLine("write student number");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (var item in students)
            {
                if (num == item.number)
                {
                    Console.WriteLine("yeni adi daxil edin");
                    string yeniad=   Console.ReadLine();
                    item.name= yeniad;
                    Console.WriteLine("yeni soyadi daxil edin");
                    string soyad= Console.ReadLine();
                    item.surname= soyad;
                    Console.WriteLine("yeni id daxil edin");
                    int yeniid= Convert.ToInt32(Console.ReadLine());
                    item.ID= yeniid;

                }
            }

        }
    }
}
