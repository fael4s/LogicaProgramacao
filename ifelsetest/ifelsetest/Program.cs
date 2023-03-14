using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsetest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica se o número é par ou ímpar---\n");
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("\n Este número par!");
            }
            else

            {
                Console.WriteLine("este número é impar");
            }
        }
    }
}




