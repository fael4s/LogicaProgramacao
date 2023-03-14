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
                    Console.WriteLine($"numero {num1} é maior");
                }

            }
            else if (num2 > num3)
            {
                Console.Write($"numero {num2} é maior");

            }
            else
            {
                Console.Write($"numero {num3} é maior");
            }

            Console.ReadKey();
        }
       
    }
}
