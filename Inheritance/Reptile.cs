using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Scales { get; set; }
        public string Venomous { get; set; }
        public string Eggs { get; set; }
        public string Spectacle {  get; set; }

        public void Presentation()
        {
                Console.WriteLine($"\t\t\t\t{Name}\n");
                Console.WriteLine($"The {Name} is from the Animale Class {Class} it has {Legs} legs,");
                Console.WriteLine($"the noise it makes resembles {Noise}, with scales {Scales},");
                Console.WriteLine($"this reptile {Venomous} with {Spectacle},");
                Console.WriteLine($"the eggs it lays are {Eggs}.");
                Console.WriteLine("If you wish to know more about this species please go to your local library.\n");
        }
    }

}
