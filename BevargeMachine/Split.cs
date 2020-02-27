using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevargeMachine
{
    class Split
    {
        public Drink[] machine1 = new Drink[5];
        public Drink[] machine2 = new Drink[5];
        public void SplitProducts(Drink[] drinks)
        {
            int temp = drinks.Length / 2;
            machine1 = drinks.Take(temp).ToArray();
            machine2 = drinks.Skip(temp).ToArray();
        }
    }
}
