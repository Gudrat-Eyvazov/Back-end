using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Encapsulation
{
    internal class Student:SchoolPerson
    {
        public Student(string schoolName, string name, string surname, int age,  int dateOfBirthday):base (schoolName,name,surname,age,dateOfBirthday)
        {
            
        }
        public override void GoToClasses()
        {
            Console.WriteLine("i am"+" "+Name+""+Surname+" "+"i am a student");
        }
        public void ShowAge()
        {
            Console.WriteLine("my age is "+(DateTime.Now.Year-DateOfBirthday));
        }

    }
}
