using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Encapsulation
{
    internal class Teacher:SchoolPerson
    {
        private string Subject { get; set; }
        public Teacher(string schoolName, string name, string surname, int age, int dateOfBirthday,string subject) : base(schoolName, name, surname, age, dateOfBirthday)
        {
            Subject = subject;
        }
        
        public void Explain ()
        {
            Console.WriteLine("explanation Begin on subject Subject: ");
        }
        public override void GoToClasses()
        {
            Console.WriteLine("i am "+Name+" "+Surname+" "+"i am a teacher");
        }
    }
}
