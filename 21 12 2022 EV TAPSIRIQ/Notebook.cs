using System;
using System.Collections.Generic;
using System.Text;

namespace _21_12_2022_EV_TAPSIRIQ
{
    internal class Notebook:Product
    {
        public Notebook(string name, int price) : base(name, price)
        {

        }

        public Notebook(string name, int price, double ram) : base(name, price)
        {
            this.RAM = ram;
        }
        public double RAM = 4;

        


    }
}
