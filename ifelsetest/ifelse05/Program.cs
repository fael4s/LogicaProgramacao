using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t---Reajuste Salarial---");
            Console.Write("\n informe seu salário atual: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 1500) 
            {
                salario = (salario + (salario * 0.23));
                Console.WriteLine("Seu novo salário é: {0:c2}", salario);

            }
            else
            {
                salario = (salario + (salario * 0.18));
                Console.WriteLine("Seu novo salário é: {0:c2}", salario);
            }
            Console.ReadKey();

        }
    }
}





