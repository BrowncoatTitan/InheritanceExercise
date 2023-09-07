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
            Bird peregrine = new Bird()
            {   Locomotion = "fly",
                CanFly = true,
                Pollinator = false,
                Habitat = "cliffs",
                BeakType = "Tomial tooth",
                WingType = "high speed wings",
            };
            Console.WriteLine("Video opens on a peregrine falcon sitting on the edge of a skyscraper.");
            Console.WriteLine("In the voice of David Attenborough:"); 
            Console.WriteLine($"The peregrine falcon is one of the fastest {peregrine.Locomotion}ing birds.");
            Console.WriteLine($"The combination of its {peregrine.BeakType} and {peregrine.WingType}" +
                $" make it nature's greatest dive bomber.");
            Console.WriteLine("Video follows a peregrine going into a steep dive");
            Console.WriteLine();
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile boa = new Reptile()
            {
                IsVenomous = false,
                NumLegs = 0,
                Habitat = "jungle",
                HasShell = false,
                Diet = "small animals and birds"
            };
            Console.WriteLine("Shot transitions to a snake coiled on a tree branch.");
            Console.WriteLine($"Even though it has {boa.NumLegs} legs, " +
                $"the boa moves easily through the {boa.Habitat} canopy.");
            Console.WriteLine("Shot cuts to a snake moving from one branch to another");
            Console.WriteLine($"It would be {boa.IsVenomous} to credit this creature with venom.");
            Console.WriteLine($"It prefers to constrict its prey, {boa.Diet}.");
        }
    }
}
