using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* DEMO AbstractFactoryPattern******************");
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("pet");
            IDog dog = animalFactory.GetDog();
            dog.About();
            ITiger tiger = animalFactory.GetTiger();
            tiger.About();

            Console.ReadKey();
        }
    }
}
