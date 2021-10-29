using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class WildTiger : ITiger
    {
        public void About()
        {
            Console.WriteLine("Wild Tiger: Gao! Gao! Gao!");
        }
    }
}
