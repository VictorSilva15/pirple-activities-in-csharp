using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicOperators
{
    class Program
    {
  
         static void Main(string[] args)
        {
            //Declaring the flavor of cake
            string cake = "vanilla";

            //Testing if the flavor is Chocolate or not
            bool test_flavor = (cake == "chocolate") ? true : false;

            //Showing the values
            if (test_flavor)
            {
                Console.WriteLine("Yeah, the cake is: chocolate");
            }
            else
            {
                Console.WriteLine("The Cake isn't chocolate. The Cake is: " + cake);
            }

            // Other Case:

            string Socrates = "Man";

            string test_mortal = (Socrates == "Man") ? "Socrates is a " + Socrates + ", therefore he's a mortal" :
            "Socrates is a " + Socrates + ", therefore he is not a mortal";

            Console.WriteLine(test_mortal);
            Console.ReadKey();
        }
    }
}
