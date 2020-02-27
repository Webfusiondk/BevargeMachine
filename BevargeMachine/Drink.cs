using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevargeMachine
{
    enum brand
    {
        Øl,
        Sodavand,
        Vand
    }
    abstract class Drink
    {
        private brand drinkBrand;

        public brand DrinkBrand
        {
            get { return drinkBrand; }
            set { drinkBrand = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Drink(string name, brand brand)
        {
            Name = name;
            DrinkBrand = brand;
        }
    }
}
