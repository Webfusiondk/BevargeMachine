using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevargeMachine
{
    class Consume
    {
        bool consume = true;
        Program p = new Program();
        public string ConsumeProduct(Drink[] machine)
        {
            if (machine[1] == null)
            {
                string empty = "The machine is empty";
                return empty;
            }
            string consumedProducts = "";
            if (consume == true)
            {
                foreach (Drink drink in machine)
                    consumedProducts += "Customer just consumed product " + drink.Name + "\n";
                consume = false;
                for (int i = 0; i < machine.Length; i++)
                {
                    machine[i] = null;
                }
                return consumedProducts;
            }

            return "The machine is broken";
        }

        public bool IsConsumeEmpty()
        {
            if (consume == true)
            {
                consume = false;
            }
            if (consume == false)
            {
                consume = true;
            }
            return consume;
        }
    }
}
