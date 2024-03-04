using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Films> filmler = new List<Films>();
            
            
          

            while(true)
            {
                Console.WriteLine("selection :");
                Console.WriteLine("1-add film");
                Console.WriteLine("2-search film");
                Console.WriteLine("3-delete film");
                Console.WriteLine("4-rename film");
                Console.WriteLine("5-exit");
                
                int selection=Convert.ToInt32(Console.ReadLine());  
                switch(selection)
                {
                    case 1:
                        Console.WriteLine("hasni filmi elave elemek isteyirsiz?");
                        string filmAdi=Console.ReadLine();
                        Console.WriteLine("bas qehramani daxil edin");
                        string basqehraman=Console.ReadLine();
                        Console.WriteLine("qehraman isini daxil edin");
                        string qehramanisi=Console.ReadLine();
                        Console.WriteLine("qehraman yasini daxil edin");
                        byte yas = Convert.ToByte(Console.ReadLine());  
                        Films film1 = new Films(); 
                        film1.filmName = filmAdi;
                        film1.mainCharacter = basqehraman;
                        film1.characterWork = qehramanisi;
                        film1.characterAge = yas;
                        filmler.Add(film1);
                        Console.WriteLine("film elave olundu");
                        break;
                        case 2:
                        Console.WriteLine("axtardiqiniz film adini daxil edin");
                        string filmadi=  Console.ReadLine();
                        foreach (Films item in filmler)
                        {
                            if(filmadi==item.filmName)
                            {
                                Console.WriteLine(item.filmName+" "+item.mainCharacter+" "+item.characterWork+" "+item.characterAge);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("hasni filmin adini deyismek isteyirsiniz");
                        string ad = Console.ReadLine();
                        foreach (Films item in filmler)
                        {
                            if (ad == item.filmName)
                            {
                                Console.WriteLine("yeni adi daxil edin");
                                string yeniad= Console.ReadLine();
                                item.filmName =yeniad;
                                Console.WriteLine("ad deyisdi yeni ad-"+item.filmName);
                            }
                        }
                        break;
                }

            }
        }
    }
}
