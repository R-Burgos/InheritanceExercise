using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class - DONE
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class - DONE
             *  give values to your members using the object of your Reptile class - DONE
             *  
             * Creatively display the class member values 
             */

            
            var tucan = new Bird();
            tucan.Name = "Tucan";
            tucan.CanFly = true;
            tucan.HasFeathers = true;
            tucan.HasBeak = true;
            tucan.LaysEggs = true;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"These are the following characteristics of a {tucan.Name}");
            Console.WriteLine($"It is {tucan.CanFly} that {tucan.Name} can fly.");
            Console.WriteLine($"It is {tucan.HasFeathers} that {tucan.Name} has feathers.");
            Console.WriteLine($"It is {tucan.HasBeak} that {tucan.Name} has a beak.");
            Console.WriteLine($"It is {tucan.LaysEggs} that {tucan.Name} can lay eggs.");
            Console.WriteLine("\n");


            var gecko = new Reptile();
            gecko.Name = "Gecko";
            gecko.Sheds = true;
            gecko.HasScales = true;
            gecko.ColdBlooded = true;
            gecko.LaysEggs = true;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"These are the following characteristics of a {gecko.Name}");
            Console.WriteLine($"It is {gecko.Sheds} that {gecko.Name} can shed.");
            Console.WriteLine($"It is {gecko.HasScales} that {gecko.Name} has scales.");
            Console.WriteLine($"It is {gecko.ColdBlooded} that {gecko.Name} are cold blooded.");
            Console.WriteLine($"It is {gecko.LaysEggs} that {gecko.Name} can lay eggs.");
            Console.WriteLine("\n");

        }
    }
}
