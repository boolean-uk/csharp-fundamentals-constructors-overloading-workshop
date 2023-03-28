using VW.Factory.CarParts;
using VW.Factory.Cars;

namespace VW.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Standard Beetle");
            Beetle standard = new Beetle();

            Console.WriteLine("Herby");
            Beetle herby = new Beetle("53", new ElectricEngineParts());

            
            Console.ReadLine();

        }
    }
}