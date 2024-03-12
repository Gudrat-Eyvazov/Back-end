using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_supermarket_inventar_idareetme_sistemi
{
    internal class NonFoodProduct:Product
    {
        public string Quality { get; set; }
        public NonFoodProduct(string name,decimal price,string category,string quality) : base(name,price,category)
        {
            Quality = quality;
        }
    }
}
