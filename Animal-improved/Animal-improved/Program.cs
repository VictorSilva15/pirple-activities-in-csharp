using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_improved
{
    public enum Food
    {
        deer,
        moose,
        squirrels,
        mice
    }

    public struct WolfAlpha
    {
        public bool haveConfidence;
        public bool stronger;
        public bool KnowWhatIsBetterToWolfPack;

        public WolfAlpha(bool HC, bool S, bool KWIBTWP)
        {
            haveConfidence = HC;
            stronger = S;
            KnowWhatIsBetterToWolfPack = KWIBTWP;
        }

        public void isAlpha()
        {
            if (haveConfidence == true
            && stronger == true
            && KnowWhatIsBetterToWolfPack == true)
            {
                Console.WriteLine("It's the alpha wolf");
            }
            else
            {
                Console.WriteLine("No, it isn't the alpha wolf");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value String :
            string name = "Wolf";

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

            Food meal = new Food();
            meal = Food.deer;

            string result_;


            if (meal == Food.deer)
            {
                result_ = "Yeah, the wolf eat deer";
            }
            else if (meal == Food.mice)
            {
                result_ = "Yeah, the wolf eat mice";
            }
            else if (meal == Food.moose)
            {
                result_ = "Yeah, the wolf eat moose";
            }
            else if (meal == Food.squirrels)
            {
                result_ = "Yeah, the wolf eat squirrels";
            }
            else
            {
                result_ = "No, the wolf don't eat " + meal;
            }

            //calling struct from outside this class =>

            //test 1:
            WolfAlpha alpha = new WolfAlpha(true, true, true);
            alpha.isAlpha();// return "It's the alpha wolf".

            //test 2:
            WolfAlpha non_alpha = new WolfAlpha(true, false, false);
            non_alpha.isAlpha(); // return "No it isn't the alpha wolf".

            Console.WriteLine("");

            //Showing the variables

            Console.WriteLine("Name: " + name);
            Console.WriteLine("One of habitats is: " + habitat[3]); //return Taigas
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
            Console.WriteLine(result_); // return if the wolf eat the food specified

            Console.ReadKey();
            //Finished program
        }
    }
}
