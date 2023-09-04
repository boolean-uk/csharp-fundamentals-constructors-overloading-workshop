using VW.Factory.Cars;

namespace VW.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //car production line

            Console.WriteLine("Standard Beetle");
            Beetle standard = new Beetle();

            Console.WriteLine();

            Console.WriteLine("Herby");
            Beetle herby = new Beetle("53");

            Console.WriteLine();

            Console.WriteLine("Diesel Golf");
            Golf dieselGolf = new Golf("MYG01F", 1.4);

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}