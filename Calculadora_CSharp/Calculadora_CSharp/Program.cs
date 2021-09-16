using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CSharp
{
    class Program
    {
        static string sair = "n";
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t CALCULADORA SIMPLES");
                Console.WriteLine("================================================================ \n ");

                Console.Write("Insira um valor: ");
                string x = Console.ReadLine();
                Console.Write("Insira outro valor: ");
                string y = Console.ReadLine();

                string alph = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                bool makeIt = true;
                for (int i = 0; i < alph.Length; i++)
                {
                    if (x.Contains(alph[i]) || y.Contains(alph[i]))
                    {
                        Console.Beep();
                        makeIt = false;
                        break;
                    }
                }
                if (makeIt)
                {
                    int n1 = Convert.ToInt32(x);
                    int n2 = Convert.ToInt32(y);

                    Console.WriteLine("\nInsira uma operação");
                    Console.Write("soma (+) subtração (-) multiplicação (*) divisão (/) : ");
                    string op = Console.ReadLine();

                    int res;

                    switch (op)
                    {
                        case "+":
                            res = n1 + n2;
                            Console.Write("\n");
                            Console.WriteLine("O valor da soma é de: " + res);
                            break;
                        case "-":
                            res = n1 - n2;
                            Console.Write("\n");
                            Console.WriteLine("O valor da subtração é de: " + res);
                            break;
                        case "*":
                            res = n1 * n2;
                            Console.Write("\n");
                            Console.WriteLine("O valor da multiplicação é de: " + res);
                            break;
                        case "/":
                            res = n1 / n2;
                            Console.Write("\n");
                            Console.WriteLine("O valor da divisão é de: " + res);
                            break;
                        default:
                            Console.Write("\n");
                            Console.WriteLine("[Erro] Impossível calcular - digite o operador sem espaços");
                            break;
                    }
                    Console.Write("\n");
                    Console.WriteLine("Encerrar programa ? [s/n]");
                    sair = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("[ERRO] Tente Novamente!");
                }
            } while (sair != "s");
        }
    }
}
