using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Prime
    {
        public string res;

        public string Verif(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return res = "";
                }
            }
            return res = "(Prime)";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Prime isPrime = new Prime();

            for (int i = 1; i <= 100; i++)
            {
                isPrime.Verif(i);

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz" + isPrime.res);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz" + isPrime.res);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz" + isPrime.res);
                }
                else
                {
                    Console.WriteLine(i + isPrime.res);
                }
            }
            Console.ReadKey();
        }
    }
}
