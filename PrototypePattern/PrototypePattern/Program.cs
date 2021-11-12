using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 mConcretePrototype1 = new ConcretePrototype1();
            mConcretePrototype1.name = "Thang";

            ConcretePrototype1 cloneItem1 = (ConcretePrototype1)mConcretePrototype1.Clone();
            Console.Write("Name: " + cloneItem1.name);

            Console.WriteLine();

            ConcretePrototype2 mConcretePrototype2 = new ConcretePrototype2();
            mConcretePrototype2.age = 21;

            ConcretePrototype2 cloneItem2 = (ConcretePrototype2)mConcretePrototype2.Clone();
            Console.Write("Age: " + cloneItem2.age);

            Console.ReadKey();
        }
    }
}
