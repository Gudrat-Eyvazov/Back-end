using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Encapsulation
{
    internal class SchoolPerson
    {
        public string  SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
          set
            {
                
                
                    if ((value >= 6) && (value <= 50))
                    {
                        _age = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid number exception");
                    }

            } 
        }
        public int DateOfBirthday { get; set; }

        public SchoolPerson(string schoolName, string name, string surname,  int age, int dateOfBirthday)
        {
            SchoolName = schoolName;
            Name = name;
            Surname = surname;
            Age = age;
            DateOfBirthday = dateOfBirthday;
        }

        public void Salam()
        {
            Console.WriteLine("hello"+" "+Name+" "+Surname);
        }
        public virtual void GoToClasses()
        {
            Console.WriteLine("Inside Base GoToClasses method");
        }
    }
}
