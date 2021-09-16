using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procedural_vs_oop
{
    /*

         The main difference between object-oriented programming and procedural Programming is:


         In the OOP the properties and methods are contained within a single object, thus, maintaining data integrity

         In the Procedural Programming the properties and methods are separated, thefore, the properties can be global
         and modified by any rotine

         The consequence of this is that the data acess is uncontrolled and unpredictable, and as you don't have control
         over who has acess to the data, testing and debugging your code will be very difficult. 
         The OOP solves this problem by combining data and methods into a complete package.

         Procedural programming has no polymorphism, inheritance or encapsulation, and in the OOP is possible
         restrict access to certain attributes and/or methods. This is called data hiding

         The OOP is more organized, and you can do changes without intefer other objects.

         */

    // Example of OOP:

    //Object mold
    public class Person
    {
        //Properties
        private string name;
        private string address;

        //Constructor
        public Person(string _name, string _address)
        {
            name = _name;
            address = _address;
        }

        //methods
        public void getName()
        {
            Console.WriteLine(name);
        }

        public void getAddress()
        {
            Console.WriteLine(address);
        }


    }


    public class Program
    {


        //Example of procedural programming:

        //global methods:
        static void printName(string name)
        {
            Console.WriteLine(name);
        }

        static void printAddress(string address)
        {
            Console.WriteLine(address);
        }


        public static void Main(string[] args)
        {

            //instantiating the object
            Person p1 = new Person("Victor", "Street of orchids");

            p1.getName();
            p1.getAddress();


            //running the global methods
            printName("Lincon");
            printAddress("Street Augusta");

            Console.ReadKey();
        }
    }
}
