using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("\t\t---Escreva o nome do aluno---\n");
            string nome = Console.ReadLine();
            Console.Write("\t\t---Escreva a nota do primeiro bimestre---\n");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("\t\t---Escreva a nota do segundo bimestre---\n");
            double num2 = Double.Parse(Console.ReadLine());
            Console.Write("\t\t---Escreva a nota do terceiro bimestre---\n");
            double num3 = Double.Parse(Console.ReadLine());
            Console.Write("\t\t---Escreva a nota do quarto bimestre---\n");
            double num4 = Double.Parse(Console.ReadLine());
            double media = ((num1+num2+num3+num4)/4);
            if (media >= 60)
            {
                Console.Write("Você foi aprovado!");
            }
            else
            {
                Console.Write("Você foi reprovado");
            }
               Console.ReadKey();
        }
    }
}
