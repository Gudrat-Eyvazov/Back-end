using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stringmetods
{
    internal class consructor
    {
        public consructor()
        {
            
        }
        public consructor(string ad, string soyad)
        {
         name = ad;
         surname= soyad;

        }
        public string name;
        public string surname;
        public int age;
    }
}
