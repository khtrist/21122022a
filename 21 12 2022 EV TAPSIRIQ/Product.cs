using System;
using System.Collections.Generic;
using System.Text;

namespace _21_12_2022_EV_TAPSIRIQ
{
    internal class Product
    {
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name;
        public int Price;

        public string GetInfo()
        {
            return $"Name: {Name} - Price: {Price}";
        }


    }
}
