using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    /*
      This program shows some informations about my favortie animal, as:
      weight, height, speed, life estimate among other information...
      This information is divided into numerical attributes, strings and boolean values 
    */

    public enum Food
    {
        deer,
        moose,
        squirrels,
        mice
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Value String :
            string name = "Wolf";
            string habitat = "deserts, mountains, tundras, taigas, fields";

            //Values numerical:
            float weightInKilos = (float)(30.0 + 80.0) / 2;
            double heightInFeet = (2.16535 + 2.65748) / 2;
            int numberOfLegs = 4;
            byte numberOfWings = 0;
            decimal speedInKM = (decimal)(50.0 + 60.0) / 2;
            short numberOfEyes = 2;
            uint lifeEstimateInYears = 14;

            //values boolean:

            bool HasFur = true;
            bool HasFeathers = false;
            bool HasTail = true;

            

            //Adding more types => 

            //Habitat array:

            string[] habitat = new string[5];

            habitat[0] = "deserts";
            habitat[1] = "mountains";
            habitat[2] = "tundras";
            habitat[3] = "taigas";
            habitat[4] = "fields";

            //Checking if the wolf eats certain foods:

            food meal = new Food();
            meal = food.deer;

            string food = "apple";

            string result_;


                if(food == food.deer)
                {
                    result_ = "Yeah, the wolf eat deer";
                }
                else if(food == food.mice)
                {
                    result_ = "Yeah, the wolf eat mice";
                }
                else if(food == food.moose)
                {
                    result_ = "Yeah, the wolf eat moose";
                }
                else if(food == food.squirrels)
                {
                    result_ = "Yeah, the wolf eat squirrels";
                }
                else
                {
                    result_ = "No, the wolf don't eat " + foods[i];
                }

            //Showing the variables

            Console.WriteLine("Name: " + name);
            Console.WriteLine("One of habitats is: " + habitat[3]);
            Console.WriteLine("Weight: " + weightInKilos + "Kg");
            Console.WriteLine("Height: " + heightInFeet + " feet");
            Console.WriteLine("Number of legs: " + numberOfLegs + " legs");
            Console.WriteLine("Number of wings: " + numberOfWings + " wings");
            Console.WriteLine("Speed: " + speedInKM + " KM/H");
            Console.WriteLine("Number of eyes: " + numberOfEyes + " eyes");
            Console.WriteLine("Life estimate: " + lifeEstimateInYears + " years");
            Console.WriteLine("it has fur ? " + HasFur);
            Console.WriteLine("it has feathers ? " + HasFeathers);
            Console.WriteLine("it has tail ? " + HasTail);
            Console.WriteLine(result_);

            Console.ReadKey();

            //Finished program

        }
    }
}
