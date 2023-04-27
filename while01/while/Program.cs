using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {int op=1;
            while (op==1)
            {
                Console.WriteLine("\t\t---Tabuada com While---\n");
                Console.Write("Informe um número: ");
                int num = int.Parse(Console.ReadLine());
                int cont = 0;
                while (cont<=10)
                {
                    Console.WriteLine($"\n{num}x{cont}={num * cont}");
                    cont++;
                }
                Console.WriteLine("Deseja realizar outra operção? \n[0]Não\n[1]Sim");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            Console.ReadKey();
        }
    }
}
