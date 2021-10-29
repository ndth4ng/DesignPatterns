using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class WildDog : IDog
    {
        public void About()
        {
            Console.WriteLine("Wild Dog: Gau! Gau! Gau!");
        }
    }
}
