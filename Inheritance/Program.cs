using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird = new Birds();
            bird.Name = "Peregrine Falcon";
            bird.Legs = 2;
            bird.Noise = "kek-kek-kek";
            bird.Class = "Aves";
            bird.Beak = "sharp and hooked";
            bird.Wings = "long and pointed";
            bird.Eggs = "creamy or reddish-brown with darker markings";
            bird.Feathers = "sleek and aerodynamic feathers";

            bird.Presentation();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reptile = new Reptile();

            reptile.Name = "King Cobra";
            reptile.Legs = 0;
            reptile.Noise = "Hisss";
            reptile.Class = "Reptilia";
            reptile.Scales = "generally olive to brown, with lighter or darker markings";
            reptile.Eggs = "tough, with leathery shell";
            reptile.Venomous = "is venomous";
            reptile.Spectacle = "no spectacles";

            reptile.Presentation();
        }
    }
}
