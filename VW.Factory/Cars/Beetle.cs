using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.Factory.Cars
{
    public class Beetle
    {

        //constructor overloading
        public Beetle(string licencePlate)
        {
            Console.WriteLine($"Beetle {licencePlate}");
        }
        public Beetle(string licencePlate, string stickerOnBonnet)
        {
            Console.WriteLine($"Beetle {licencePlate} with custom bonnet sticker {stickerOnBonnet}");
        }


        //method overloading
        public void SelfDriveMode(int averageSpeed, string cityDestination)
        {
            //sets an average speed and destination city for the car
        }
        public void SelfDriveMode(int averageSpeed)
        {
            //sets an average speed for the self drive mode but car could go anywhere
        }
        public void SelfDriveMode()
        {
            //auto drive mode where anything could happen
        }                       
        public void SelfDriveMode(bool disableFeature)
        {

        }

    }
}
