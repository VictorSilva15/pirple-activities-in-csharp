using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{

    //abstract class that will be inherit for Cars class and Planes class
    public abstract class Vehicle
    {
        //properties
        public string Make;
        public string Model;
        public int Year;
        public int Weight;
        public int TripsSinceMaintenance = 0;
        public int LimitTrips = 100;
        public bool NeedsMaintenance = false;
        public bool isDriving = false;

        //Method Drive
        public bool Drive()
        {
            if (TripsSinceMaintenance > LimitTrips)
            {
                NeedsMaintenance = true;
                Console.WriteLine(Make + " needs Maintenance");
                return false;
            }
            else
            {
                return isDriving = true;
            }
        }

        //Method Stop
        public bool Stop()
        {
            if (isDriving == true)
            {
                TripsSinceMaintenance += 20;
                return isDriving = false;
            }
            else
            {
                Console.WriteLine(Make + " is already stopped");
                return false;
            }
        }

        //Method Repair
        public void Repair()
        {
            if (TripsSinceMaintenance > LimitTrips)
            {
                TripsSinceMaintenance = 0;
                NeedsMaintenance = false;
                Console.WriteLine(Make + " was repaired");
            }
            else
            {
                Console.WriteLine(Make + " doesn't need to repair");
            }
        }

        //Method extra to show all informations
        public void Print()
        {
            Console.WriteLine("\n" + "======================================" + "\n");
            Console.WriteLine("Informations of Vehicle: " + "\n");

            string Informations = ("Make: " + Make + "\n" +
                             "Model: " + Model + "\n" +
                             "Year: " + Year + "\n" +
                             "Weight: " + Weight + "Kg" + "\n" +
                             "Limit trips: " + LimitTrips + "\n" +
                             "Trips since Maintenance: " + TripsSinceMaintenance + "\n" +
                             "The vehicle needs maintenance: " + NeedsMaintenance);
            Console.WriteLine(Informations);

            Console.WriteLine("\n" + "======================================" + "\n");
        }

    }



    //Cars class that will inherit all Vehicle properties
    public class Cars : Vehicle
    {
        public Cars(string make, string model, int year, int weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }
    }

    //Planes class that will inherit all Vehicle properties 
    public class Planes : Vehicle
    {
        public Planes(string make, string model, int year, int weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Car 1 =>

            Cars Chevrolet = new Cars("Chevrolet", "4x4", 2017, 1400);
            Chevrolet.Drive();
            Chevrolet.Stop();//Trips = 20
            Chevrolet.Stop(); // return The vehicle is already stopped
            Chevrolet.Drive();
            Chevrolet.Stop(); //Trips = 40
            Chevrolet.Repair(); //return The vehicle doesn't need to repair

            Chevrolet.Print();

            // Car 2 =>

            Cars Audi = new Cars("I/AUDI", "RSQ3 SPB", 2020, 1100);
            Audi.Drive();
            Audi.Stop();//Trips = 20
            Audi.Drive();
            Audi.Stop(); //Trips = 40
            Audi.Drive();
            Audi.Stop(); //Trips = 60
            Audi.Drive();
            Audi.Stop(); //Trips = 80
            Audi.Drive();
            Audi.Stop(); //Trips = 100;
            Audi.Drive();
            Audi.Stop(); //Trips = 120;

            Audi.Drive(); // The vehicle needs Maintenance

            Audi.Print();

            // Car 3 =>

            Cars Tesla = new Cars("Tesla", "Model S", 2020, 1250);
            Tesla.Drive();
            Tesla.Stop();//Trips = 20
            Tesla.Drive();
            Tesla.Stop(); //Trips = 40
            Tesla.Drive();
            Tesla.Stop(); //Trips = 60
            Tesla.Drive();
            Tesla.Stop(); //Trips = 80
            Tesla.Drive();
            Tesla.Stop(); //Trips = 100;
            Tesla.Drive();
            Tesla.Stop(); //Trips = 120;
            Tesla.Drive();
            Tesla.Stop(); //Trips = 140;

            Tesla.Drive(); // The vehicle needs Maintenance

            Tesla.Print();

            Tesla.Repair(); //Tesla was repaired

            Tesla.Print();

            //Plane =>

            Planes EVAAir = new Planes("EVAAIR", "boeing787", 2007, 285000);
            EVAAir.Drive();
            EVAAir.Stop();//Trips = 20
            EVAAir.Drive();
            EVAAir.Stop(); //Trips = 40
            EVAAir.Drive();
            EVAAir.Stop(); //Trips = 60
            EVAAir.Drive();
            EVAAir.Stop(); //Trips = 80
            EVAAir.Drive();
            EVAAir.Stop(); //Trips = 100;

            EVAAir.Repair(); //return The vehicle doesn't need to repair

            EVAAir.Drive();
            EVAAir.Stop(); //Trips = 120;
            EVAAir.Drive(); //return EVAAIR needs maintenace

            EVAAir.Repair(); //Return EVAir was repaired

            EVAAir.Print();

            Console.ReadKey();
        }
    }
}
