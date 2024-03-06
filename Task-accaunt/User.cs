using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_accaunt
{
    internal class User:Account
    {
        public User(string email,string paswword):base(email, paswword)
        {

        }

        public override bool GmailCheacker(string email)
        {
            bool netice=email.Contains('@');
            return netice;
        }

        public  override bool PasswordChaker(string password)
        {
            bool islower=false;
            bool isUpper=false;
            if(password.Length>=8)
            {
              for(int i = 0; i < password.Length; i++)
                {
                    if (password[i] > 'A' && password[i]<'Z')
                    {
                        isUpper =true;
                    }
                    else if (password[i] > 'a'&& password[i]<'z') {
                        islower = true;
                    }
                }

            }
            if(isUpper==true&& islower==true)
            {
                return true;
            }
            return false;

        }
    }
}
