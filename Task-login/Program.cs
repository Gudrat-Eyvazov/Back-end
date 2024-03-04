using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "sinan";
            int password = 2002;
            int cehdSayisi = 3;
            Boolean sert = true;
            while (sert) {
                if (cehdSayisi>0) { 
                
                Console.WriteLine("isdifadeci adinizi daxil edin");
                string ad = Console.ReadLine();
                Console.WriteLine("sifrenizi daxil edin");
                int sifre = Convert.ToInt32(Console.ReadLine());
                if ((name == ad) && (password == sifre))
            {
                Console.WriteLine("succsess");
                    sert = false;

            }
                    else { Console.WriteLine("isdifadeci adiniz ve yaxud sifreniz yalnisdir  ---------- birdaha cehd edin" +cehdSayisi--); }


                }
                else { Console.WriteLine("cehd sayiniz doldu");
                    break;
                }

            }
        }
    }
}
