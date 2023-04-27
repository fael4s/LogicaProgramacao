using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Média do alumo---\n");
            Console.WriteLine("Quantos alunos a turma tem? ");
            int numalu= int.Parse(Console.ReadLine());
            double b1, b2, b3, b4, mediaab = 0;
            int cont = 1;
            double mediaturma=0;
            while (cont <= numalu)
            {
                Console.WriteLine("Qual a nota do primeiro bimestre");
                b1= double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a nota do segundo bimestre");
                b2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a nota do terceiro bimestre");
                b3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a nota do quarto bimestre");
                b4 = double.Parse(Console.ReadLine());

                mediaab = (b1 + b2 + b3 + b4) / 4;
                cont++;
                Console.WriteLine("Sua média é" + mediaab);
                mediaturma += mediaab;
            }
            Console.ReadKey();
        }
    }
}
