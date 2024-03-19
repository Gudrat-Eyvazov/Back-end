using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_interface3
{
    internal class Book:ILibaryManager
    {
       static List<Book> books=new List<Book>();
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string genre { get; set; }
        public Book(string ad,string muellif,int sehifesayi,string janr)
        {
            Name = ad;
            Author = muellif;
            PageCount = sehifesayi;
            genre = janr;
        }

         public  void Add()
        {
            Console.WriteLine("kitab adini daxil edin ");
            string kitabadi= Console.ReadLine();
            Console.WriteLine("mellif adini daxil edin ");
            string muellifadi=Console.ReadLine();
            Console.WriteLine("sehife sayini daxil edin ");
            int sehifesayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hansi janirda oldugunu qeyd edin");
            string janr= Console.ReadLine();
            Book book1 = new Book(kitabadi, muellifadi, sehifesayi, janr);
           
            foreach(Book book in books)
            {
                try
                {
                    if (kitabadi != book.Name)
                    {
                        books.Add(book1);
                    }
                }
                catch (Exception xeta )
                {
                    Console.WriteLine(" samebook already added exception");

                }
            }

            
        }

        public void Filter()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            Console.WriteLine("axtardiqniz kitab adni daxil edin ");
            string kitabadi = Console.ReadLine();
            foreach (Book book in books)
            {
                if (kitabadi == book.Name)
                {
                    Console.WriteLine(book.Name+book.Author+book.PageCount+book.genre);
                }
              
            }


        }

        public void ShowInfo()
        {
            Console.WriteLine("axtardiqniz kitab adni daxil edin ");
            string kitabadi=Console.ReadLine();
            foreach (Book book in books)
            {
                if(kitabadi==book.Name)
                {
                    Console.WriteLine(book.Name);
                }
                else 
                {
                    Console.WriteLine("booknotfound exception");
                }
            }
            
            
        }
    }
}
