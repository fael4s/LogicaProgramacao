using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t--- Qual o maior nome---");
            Console.WriteLine("Qual o primeiro nome? ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Qual o segundo nome? ");
            string nome2 = Console.ReadLine();

            int a = nome1.Length;
            int b = nome2.Length;
            if (a != b);
            {
                if (a>b)
                {
                    Console.WriteLine("\n{0}caracteres, o maior nome é: {1}", a, nome1);
                }
            }
        }
    }
}
