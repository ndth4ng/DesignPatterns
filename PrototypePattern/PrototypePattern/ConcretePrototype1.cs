using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class ConcretePrototype1 : Prototype
    {
        public string name { get; set; }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone(); // Clones the concrete class.
        }
    }
}
