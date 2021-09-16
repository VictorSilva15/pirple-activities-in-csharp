using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            //main function that receives the values
            bool timeAdder(int value1, string label1, int value2, string label2)
            {
                label1 = label1.ToLower();
                label2 = label2.ToLower();

                string[] validStrings = new string[] { "second", "minute", "hour", "day", "seconds", "minutes", "hours", "days" };

                if (validStrings.Contains(label1) && validStrings.Contains(label2) || label1 == "" || label2 == "")
                {
                    if (((label1[label1.Length - 1] == 's' && value1 > 1)
                      || (label1[label1.Length - 1] != 's' && value1 <= 1))
                      && ((label2[label2.Length - 1] == 's' && value2 > 1)
                      || (label2[label2.Length - 1] != 's' && value2 <= 1)))
                    {
                        int result = formatData(value1, label1) + formatData(value2, label2);
                        List<string> myList = new List<string>();



                        int days = (result >= 86400) ? result / 86400 : 0;
                        int hours = (days > 0) ? (result % 86400) / 3600 : (result >= 3600) ? result / 3600 : 0;
                        int minutes = (hours > 0) ? ((result % 86400) % 3600) / 60 : (days > 0) ? ((result % 86400) / 60) : (result >= 60) ? result / 60 : 0;
                        int seconds = (minutes > 0) ? ((result % 3600) % 3600) % 60 : (hours > 0) ? ((result % 86400) % 3600) : (days > 0) ? result % 86400 : (result > 0) ? result : 0;



                        if (days > 0)
                        {
                            Console.WriteLine((days > 1) ? days + " days" : days + " day");
                        }
                        else if (hours > 0)
                        {
                            Console.WriteLine((hours > 1) ? hours + " hours" : hours + " hour");
                        }
                        else if (minutes > 0)
                        {
                            Console.WriteLine((minutes > 1) ? minutes + " minutes" : minutes + " minute");
                        }
                        else if (seconds > 0)
                        {
                            Console.WriteLine((seconds > 1) ? seconds + " seconds" : seconds + " second");
                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong syntax");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("labels are invalid");
                    return false;
                }
            }


            //In this method go the rules to format the numbers of timeAdder

            int formatData(int Value, string label)
            {

                if (label.Contains("day"))
                {
                    Value *= 86400;
                }
                if (label.Contains("hour"))
                {
                    Value *= 3600;
                }
                if (label.Contains("minute"))
                {
                    Value *= 60;
                }
                return Value;
            }

            /* ================= Executing the main function ====================*/

            //need of two params

            //examples:
            Console.WriteLine("================= Testing =================\n");

            timeAdder(1, "day", 0, "hour"); // return 1 day
            timeAdder(2, "days", 12, "hours"); // return 2 days
            timeAdder(2, "days", 48, "hours"); // return 4 days
            timeAdder(0, "day", 9, "hours"); // return 9 hours 
            timeAdder(23, "hours", 60, "minutes"); // return 1 day
            timeAdder(1, "minute", 10, "seconds"); // return 1 minute
            timeAdder(240, "seconds", 60, "seconds"); // return 5 minutes

            timeAdder(1, "hours", 60, "minute"); // return Wrong syntax because the labels don't match the values.
            //In this example, the values should to be 1 hourS with S, but, the label is without s in singular.
            //The same happend with the second label
            Console.ReadKey();
        }
    }
}
