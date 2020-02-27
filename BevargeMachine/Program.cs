using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BevargeMachine
{
    class Program
    {
        public static bool isMachineFull { get; set; }
        static void Main(string[] args)
        {

            Produce p = new Produce();
            Split s = new Split();
            Consume c = new Consume();
            Thread t1 = new Thread(s.SplitProducts);
            Thread t2 = new Thread();
            Thread t3 = new Thread();
            p.AddProductsToList();
            s.SplitProducts(p.ProduceProduct());
            Console.WriteLine(p.products);
            isMachineFull = p.IsProductonFull();
            s.SplitProducts(p.ProduceProduct());
            Console.WriteLine(p.products);
            Console.WriteLine(c.ConsumeProduct(s.machine1));
            isMachineFull = c.IsConsumeEmpty();
            Console.WriteLine(c.ConsumeProduct(s.machine2));
            
            Console.Read();
        }
    }
}
