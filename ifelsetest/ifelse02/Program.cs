using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse02
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("\t\t\t---Maior número---\n");
            Console.WriteLine("\t\t---Escreva um números inteiros---\n");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t---Escreva um números inteiros---\n");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t---Escreva um números inteiros---\n");
            int num3 = int.Parse(Console.ReadLine());
 
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write($"número {num1} é o maior");
                }

            }
            else if (num2 > num3)
            {
                Console.Write($"número {num2} é o maior");

            }
            else
            {
                Console.Write($"número {num3} é o maior");
            }

            Console.ReadKey();
        }
       
    }
}
