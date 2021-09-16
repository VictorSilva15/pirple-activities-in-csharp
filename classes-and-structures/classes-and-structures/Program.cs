using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_structures
{

    /*One of the differences between a Class and a Struct is the level of access.  
     While the class is private, the structure is public. Another difference is that
     the Class is "Reference type", this means that your data is treated by reference
     Struct is "Value type", its variables are called directly, without any reference. 
     All of this has to do with the memory location, being Stack for Struct (primitive types) 
     and Heap for others.
     
     Stack is a more limited memory and with good performance, it stores values ​​such as:
     int, double, bool... and structs

     Heap is a much larger area and has the Garbage Collector that always checks
     whether an object is being used or not, and if not, that object is deleted
     freeing up more memory space.
     */

    /*One of the characteristics of the struct is that it must have a constructor with parameters
     if an error does not occur:   
    */

    public struct Person
    {
        public string name_;
        public int age_;
        public double size_;
        public bool isMan_;

        //There must be a constructor with parameters
        public Person(string name, int age, double size, bool isMan)
        {
            name_ = name;
            age_ = age;
            size_ = size;
            isMan_ = isMan;
        }

        public void Print()
        {
            Console.WriteLine(name_);
            Console.WriteLine(age_);
            Console.WriteLine(size_);
            Console.WriteLine(isMan_);
            Console.ReadKey();
        }
    }

    /*Class return an error for created variables that do not receive any value as a parameter,
      as they are not dealt with directly but by reference. (On the other hand, different from
        Structs, classes do not necessarily need an explicit constructor):*/

    public class Monster
    {
        public string name_;
        public int kills_;

        public Monster(string name, int kills)
        {
            name_ = name;
            kills_ = kills;
        }

        public void Print() {

            Console.WriteLine(name_);
            Console.WriteLine(kills_);
            Console.ReadKey();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Victor", 16, 1.70, true);
            person1.Print(); //returns the values ​​passed as parameters in the call above.

            Person person2 = new Person();
            person2.Print(); // returns the above variables, but empty (with values equal = '', 0, false);

            Monster dragon = new Monster("Dragon", 44);
            dragon.Print();// returns the values ​​passed as parameters in the call above.

            //Monster Zombie = new Monster(); => returns an error for not specifying parameters
            //Zombie.Print();

        }
    }
}
