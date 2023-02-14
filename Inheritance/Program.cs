using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common /Done


            // Create a class Bird Done
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile Done
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var eagle = new Bird();
            eagle.canFly = true;
            eagle.wingSpan = 10;
            eagle.height = 5;
            eagle.legs = 2;
            eagle.color = "Golden";
            eagle.type = "Raptor";
            eagle.name = "Eagle";
            eagle.birdCall = "Screech";

            var birdList = new List<Bird>();
            birdList.Add(eagle);

            foreach (var bird in birdList)
            {
                Console.WriteLine("Can you name this animal?");
                Console.WriteLine($"Can it fly? {eagle.canFly}");
                Console.WriteLine($"That's and impressive wing span {eagle.wingSpan}ft");
                Console.WriteLine($"Are you taller then it? {eagle.height}ft");
                Console.WriteLine($"it has {eagle.legs} legs");
                Console.WriteLine($"Its color is {eagle.color}");
                Console.WriteLine($"It is considered a {eagle.type}");
                Console.WriteLine($"{eagle.birdCall} is it's call");
                Console.WriteLine($"if you guessed {eagle.name} then you are correct");
                Console.WriteLine("--------------------------------------------------");
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var chameleon = new Reptile();

            chameleon.canFly = false;
            chameleon.canWalk = true;
            chameleon.color = "depends";
            chameleon.length = 17;
            chameleon.scales = true;
            chameleon.canSwim= false;
            chameleon.legs = 4;
            chameleon.name = "Chameleon";

            var reptileList = new List<Reptile>();
            reptileList.Add(chameleon);

            foreach(var reptile in reptileList)
            {
                Console.WriteLine("Can you guess which reptile this is?");
                Console.WriteLine($"Can it fly {chameleon.canFly}");
                Console.WriteLine($"Does it walk?  {chameleon.canWalk}");
                Console.WriteLine($"What color is it?  {chameleon.color}");
                Console.WriteLine($"It is {chameleon.length} inches");
                Console.WriteLine($"Does it have scales? {chameleon.scales}");
                Console.WriteLine($"Can it swim? {chameleon.canSwim}");
                Console.WriteLine($"It has {chameleon.legs} legs");
                Console.WriteLine($"If you guessed {chameleon.name} then you were correct"); 
            }


        }
    }
}
