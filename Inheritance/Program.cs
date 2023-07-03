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

            //DONE


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            //DONE

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            //DONE



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird()
            {
                HasHeart = true,
                HasBrain = true,
                HasTeeth = false,
                HasLegs = 2,

            };


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile reptile1 = new Reptile()
            {
                HasHeart = true,
                HasBrain = false,
                HasTeeth = true,
                HasLegs = 4,


            };

            var myAnimals = new Animal[] { bird1, reptile1 };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Has heart: {animal.HasHeart}");
                Console.WriteLine($"Has brain: {animal.HasBrain}");
                Console.WriteLine($"Has teeth: {animal.HasTeeth}");
                Console.WriteLine($"Has legs: {animal.HasLegs}");
                Console.WriteLine("");

            }
            


        }
    }
}
