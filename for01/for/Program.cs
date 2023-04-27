using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\t\t---Calculo de salário---\t\n");
            double salario, reajuste, newpay;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nInforme o salário do {0}° funcionário: ",i+1);
                salario = double.Parse(Console.ReadLine());
                if (salario > 0)
                {


                    if (salario < 1000)
                    {
                        reajuste = salario * 0.55;
                        newpay = salario + reajuste;
                        Console.WriteLine("\t\t---Reajuste---");
                        Console.WriteLine("Salário atual: {o:c2}", salario);
                        Console.WriteLine("Rewajuste: {0:c2}", reajuste);
                        Console.WriteLine("Novo salário: {0:c2}", newpay);
                    }
                    else if (salario <= 2500)
                    {
                        reajuste = salario * 0.30;
                        newpay = salario + reajuste;
                        Console.WriteLine("\t\t---Reajuste---");
                        Console.WriteLine("Salário atual: {o:c2}", salario);
                        Console.WriteLine("Rewajuste: {0:c2}", reajuste);
                        Console.WriteLine("Novo salário: {0:c2}", newpay);
                    }
                    else
                    {
                        reajuste = salario * 0.20;
                        newpay = salario + reajuste;
                        Console.WriteLine("\t\t---Reajuste---");
                        Console.WriteLine("Salário atual: {o:c2}", salario);
                        Console.WriteLine("Rewajuste: {0:c2}", reajuste);
                        Console.WriteLine("Novo salário: {0:c2}", newpay);
                    }
                }
                else
                {
                    Console.WriteLine("Digite um salário válido.");
                }
            }
            Console.ReadKey();
        }
    }
}

