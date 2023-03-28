using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VW.Factory.CarParts;

namespace VW.Factory.Cars
{
    public class Beetle
    {
       
        private Bonnet _bonnet;
        private Engine _engine;

        public Beetle()
        {
            _engine = new Engine();
            _bonnet = new Bonnet();                    
        }
        public void Beetle(string NumberToPutOnBonnet, ElectricEngineParts engineParts)
        {
            _engine = new Engine(engineParts);
            _bonnet = new Bonnet(NumberToPutOnBonnet);
        }
        public Beetle(string NumberToPutOnBonnet, DieselEngineParts engineParts)
        {
            _engine = new Engine(engineParts);
            _bonnet = new Bonnet(NumberToPutOnBonnet);
        }



        //

    }
}
