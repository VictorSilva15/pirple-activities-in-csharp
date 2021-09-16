using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading; //library import that will do the delay simulation

namespace ElevatorBrain
{
    //This class is the elevators brain. Call it to elevator work correctly
    public class Brain
    {
        public string tenant_origin_floor = "10"; //origin request
        public int tenant_destination_floor; // destination request
        public int elevator_floor_A = 0; //elevator default floor
        public int elevator_floor_B = 0; //elevator default floor
        public int time = 0;
        int[] verif = new int[11] { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string alphVerif = "abcdefghijklmnopqrstuvwxyz '`~[]{})(*&¨%$#@!-_+=/.,<>:;?°ºªç₢|\"";

        public Brain()
        {
            StartElevator(); //this method initialize the brain
        }

        public void StartElevator()
        {
            string elevator; 
            string valid;
            do {
                Clear();
                Write("\nDo you want to take a elevator ? [Y/N]:\a ");
                valid = ReadLine();

                if(valid.ToLower() == "y")
                {
                    if(tenant_origin_floor == "10")
                    {
                        Write("\nWhat is your floor? -> [-1,0,1,2,3,4,5,6,7,8,9]: ");
                        tenant_origin_floor = ReadLine();
                    }
                    if (!(alphVerif.Contains(tenant_origin_floor)) && verif.Contains(int.Parse(tenant_origin_floor)))
                    {
                        if (int.Parse(tenant_origin_floor) == -1)
                        {
                            Write("\nYou can only call elevator A\n");
                            elevator = "A";
                            Thread.Sleep(2000);
                        }
                        else if (Int32.Parse(tenant_origin_floor) == 9)
                        {
                            Write("\nYou can only call elevator B\n");
                            elevator = "B";
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Write("\nwhich elevator do you want to take? [A or B]: ");
                            elevator = ReadLine();
                        }

                        //Elevator arriveing
                        if (elevator.ToLower() == "a")
                        {
                            if (int.Parse(tenant_origin_floor) > elevator_floor_A)
                            {
                                for (int i = elevator_floor_A; i < int.Parse(tenant_origin_floor); i++)
                                {
                                    Write(i + "...");
                                    Thread.Sleep(1000);
                                    elevator_floor_A += 1;
                                    time++;
                                }
                            }
                            else if (elevator_floor_A > int.Parse(tenant_origin_floor))
                            {
                                for (int i = elevator_floor_A; i > int.Parse(tenant_origin_floor); i--)
                                {
                                    Write(i + "...");
                                    Thread.Sleep(1000);
                                    elevator_floor_A -= 1;
                                    time++;
                                }
                            }

                            Write("  Your elevator has arrived!\n");
                            Thread.Sleep(2000);
                            Elevator_A();
                        }
                        else if (elevator.ToLower() == "b")
                        {
                            if (int.Parse(tenant_origin_floor) > elevator_floor_B)
                            {
                                for (int i = elevator_floor_B; i < int.Parse(tenant_origin_floor); i++)
                                {
                                    Write(i + "...");
                                    Thread.Sleep(1000);
                                    elevator_floor_B += 1;
                                    time++;
                                }
                            }
                            else if (elevator_floor_B > int.Parse(tenant_origin_floor))
                            {
                                for (int i = elevator_floor_B; i > int.Parse(tenant_origin_floor); i--)
                                {
                                    Write(i + "...");
                                    Thread.Sleep(1000);
                                    elevator_floor_B -= 1;
                                    time++;
                                }
                            }

                            Write("  Your elevator has arrived!\n");
                            Thread.Sleep(2000);
                            Elevator_B();

                        }
                        else
                        {
                            Write("\n--> [ERROR] Just exist elevator A and B\n" +
                            "Choose a elevator and try again");
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        tenant_origin_floor = "10";
                        Write("\n--> [ERROR] Just exist floors [-1,0,1,2,3,4,5,6,7,8,9]\n" +
                                " Inform your floor and try again");
                        Thread.Sleep(3000);
                    }
                    
                }
                else
                {
                    Write("\nPress any button to close the program");
                    ReadKey();
                }
                time = 0;

            } while (valid.ToLower() == "y") ;
        }

        bool stop = true;

        //Methods that must be active when the floor button is pressed:

        //Elevator A Features
        public void Elevator_A()
        {
            do {
                Clear();
                WriteLine("\n============ Elevator A ============\n");
                string[] ElevatorArr = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    if (i - 1 != elevator_floor_A)
                    {
                        ElevatorArr[i] = (i - 1).ToString();
                    }
                    else
                    {
                        ElevatorArr[i] = "-";
                    }
                }
                Write("\nYou are here: [" + elevator_floor_A + "]");
                Write("\navailable floors: " + "["+String.Join(",",ElevatorArr)+"]");
                tenant_destination_floor = int.Parse(ReadLine());
                if (ElevatorArr.Contains(tenant_destination_floor.ToString()))
                {
                    if (elevator_floor_A > tenant_destination_floor)
                    {
                        for (int i = elevator_floor_A; i > tenant_destination_floor; i--)
                        {
                            Write("[" + i + "] -> ");
                            Thread.Sleep(1000);
                            elevator_floor_A -= 1;
                            time++;
                        }
                    }
                    else if (tenant_destination_floor > elevator_floor_A)
                    {
                        for (int i = elevator_floor_A; i < tenant_destination_floor; i++)
                        {
                            Write("[" + i + "] -> ");
                            Thread.Sleep(1000);
                            elevator_floor_A += 1;
                            time++;
                        }
                    }
                    tenant_origin_floor = elevator_floor_A.ToString();
                    Write("  You arrived at your destination");
                    stop = false;
 
                }
                else
                {
                    Write("\n[ERROR] This elevator can't arrive this floor. Try again, please");
                    Thread.Sleep(3000);
                }
            } while (stop);

            Thread.Sleep(2000);
            Clear();
            WriteLine("============= Informations =============\n");
            Write("Elevator used: Elevator A\n");
            Write("Total time: " + time + " seconds\n");

            Thread.Sleep(3000);

            Write("\nPress any button!");
            ReadKey();
        }


        //Elevator B Features
        public void Elevator_B()
        {
            do
            {
                Clear();
                WriteLine("\n============ Elevator B ============\n");
                string[] ElevatorArr = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    if (i != elevator_floor_B)
                    {
                        ElevatorArr[i] = i.ToString();
                    }
                    else
                    {
                        ElevatorArr[i] = "-";
                    }
                }
                Write("\nYou are here: [" + elevator_floor_B + "]");
                Write("\navailable floors: " + "[" + String.Join(",", ElevatorArr) + "]");
                tenant_destination_floor = int.Parse(ReadLine());
                if (ElevatorArr.Contains(tenant_destination_floor.ToString()))
                {
                    if (elevator_floor_B > tenant_destination_floor)
                    {
                        for (int i = elevator_floor_B; i > tenant_destination_floor; i--)
                        {
                            Write("[" + i + "] -> ");
                            Thread.Sleep(1000);
                            elevator_floor_B -= 1;
                            time++;
                        }
                    }
                    else if (tenant_destination_floor > elevator_floor_B)
                    {
                        for (int i = elevator_floor_B; i < tenant_destination_floor; i++)
                        {
                            Write("[" + i + "] -> ");
                            Thread.Sleep(1000);
                            elevator_floor_B += 1;
                            time++;
                        }
                    }
                    tenant_origin_floor = elevator_floor_B.ToString();
                    Write("  You arrived at your destination");
                    stop = false;
                }
                else
                {
                    Write("\n[ERROR] This elevator can't arrive this floor. Try again, please");
                    Thread.Sleep(3000);
                }
            } while (stop);

            Thread.Sleep(2000);
            Clear();
            WriteLine("============= Informations =============\n");
            Write("Elevator used: Elevator B\n");
            Write("Total time: " + time + " seconds\n");

            Thread.Sleep(3000);

            Write("\nPress any button!");
            ReadKey();
        }
    }

    //calling the Elevator Brain
    class Program
    {
        static void Main(string[] args)
        {
            Brain elevator = new Brain();
        }
    }
}
