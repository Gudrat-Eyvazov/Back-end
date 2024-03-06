using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_accaunt
{
    internal abstract class Account
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Account(string email, string sifre)
        {
            if (PasswordChaker(sifre) && GmailCheacker(email))
            {
                Email = email;
                Password = sifre;

            }
            else
            {
                Console.WriteLine("try again--incorrect");
            }

        }

        public abstract bool GmailCheacker(string email);


        public abstract bool PasswordChaker(string password);
        public virtual void ShowInfo()
        {
            Console.WriteLine("Full Name:" + FullName);
            Console.WriteLine("Email :" + Email);
        }
    }
}
