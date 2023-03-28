using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.Factory.CarParts
{
    public class Engine
    {
        public Engine()
        {
            Console.WriteLine("Constructed engine with no parts?!");
        }
        public Engine(DieselEngineParts dieselEngineParts)
        {
            Console.WriteLine("Constructed engine with diesel parts");
        }
        public Engine(ElectricEngineParts electricEngineParts)
        {
            Console.WriteLine("Constructed engine with electric parts");
        }

    }
}
