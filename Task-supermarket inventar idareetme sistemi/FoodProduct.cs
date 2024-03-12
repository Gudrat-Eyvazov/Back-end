using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_supermarket_inventar_idareetme_sistemi
{
    internal class FoodProduct:Product
    {
        public string ExpirationDate { get; set; }
        public FoodProduct(string name,decimal price,string category,string exprationdate):base(name,price,category)
        {
            ExpirationDate = exprationdate;
        }
        
    }
}
