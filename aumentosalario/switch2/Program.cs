using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Media de notas---\n");
            Console.Write("\t\t---Escreva o nome do aluno---\n");
            string nome = Console.ReadLine();
            Console.Write("\t\t---Escreva a nota do primeiro bimestre---\n");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("\t\t---Escreva a nota do segundo bimestre---\n");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("\t\t---Escreva a nota do terceiro bimestre---\n");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("\t\t---Escreva a nota do quarto bimestre---\n");
            int num4 = int.Parse(Console.ReadLine());
            double media = ((num1 + num2 + num3 + num4) / 4);
            char conceito = ' ';
            if (media >= 90)
            {
                conceito = 'A';
            }
            else if (media >= 80)
            {
                conceito = 'B';
            }
            else if (media >= 60)
            {
                conceito = 'C';
            }
            else if (media >= 40)
            {
                conceito = 'D';
            }
            else if (media >= 20)
            {
                conceito = 'E';

            }

            switch (conceito)
            {
                case 'A':
                case 'B':
                case 'c':
                    Console.WriteLine("Aprovado");
                    break;
                case 'D':
                    Console.WriteLine("Recuperação.");
                    break;
                case 'E':
                    Console.WriteLine("Exame."); 
                    break;
                default:
                    Console.WriteLine("Reprovado.");
                    break;
            }

            Console.ReadLine();
        }

    }
}
