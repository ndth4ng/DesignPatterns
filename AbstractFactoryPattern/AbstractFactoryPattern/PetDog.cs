using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class PetDog : IDog
    {
        public void About()
        {
            Console.WriteLine("Pet Dog: Nom! Nom! Nom!");
        }
    }
}
