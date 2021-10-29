using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class PetTiger : ITiger
    {
        public void About()
        {
            Console.WriteLine("Pet Tiger: Meo! Meo! Meo!");
        }
    }
}
