using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animal
    {
        public string Beak {  get; set; }
        public string Wings { get; set; }
        public string Eggs { get; set; }
        public string Feathers { get; set; }


        public void Presentation()
        {
            Console.WriteLine($"\t\t\t\t{Name}\n");
            Console.WriteLine($"The {Name} is from the Animale Class {Class} like all the birds it has {Legs} legs,");
            Console.WriteLine($"the noise it makes resembles {Noise}, with a beak {Beak},");
            Console.WriteLine($"the wing of this animal are {Wings} with feathers {Feathers},");
            Console.WriteLine($"the eggs it lays are {Eggs}.");
            Console.WriteLine("If you wish to know more about this species please go to your local library.\n");
        }
    }
}
