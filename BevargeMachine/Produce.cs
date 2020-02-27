using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevargeMachine
{
    class Produce
    {
        bool production = false;
        Program p = new Program();
        Drink[] DrinkArray = new Drink[10];
        List<Drink> DrinkList = new List<Drink>();
        Drink Cola = new Soda("Cola", brand.Sodavand);
        Drink Vand = new Water("Super Water", brand.Vand);
        Drink Carlsberg = new Beer("Carlsberg", brand.Øl);
        Random r = new Random();
        public string products = "";

        public Drink[] ProduceProduct()
        {
            if (production == true)
            {
                products = "The production is on standby";
            }

            if (production == false)
            {
                for (int i = 0; i < DrinkArray.Length; i++)
                {
                    DrinkArray[i] = DrinkList[r.Next(0, 3)];
                    products += "This Drink " + DrinkArray[i].Name + " got produced" + "\n";
                }
                production= true;
            }

            return DrinkArray;
        }

        public bool IsProductonFull()
        {
            
            if (DrinkArray[9] != null)
            {
                production = true;
            }
            if (DrinkArray[9] == null)
            {
                production = false;
            }
            return production;
        }

        public void AddProductsToList()
        {
            DrinkList.Add(Cola);
            DrinkList.Add(Vand);
            DrinkList.Add(Carlsberg);
        }
    }
}
