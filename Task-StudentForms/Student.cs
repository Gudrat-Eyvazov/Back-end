using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_StudentForms
{
    internal class Student
    {
     public static   List<Student> students = new List<Student>();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Student(string ad ,string soyad,int yas)
        { 
            Name = ad;
            Surname = soyad;
            Age = yas;
            
        }
    }
}
