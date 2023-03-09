using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, total;
            Console.WriteLine("\t\t---Multiplica dois valores---\n");
            Console.Write("Informe o valor de \'x\': ");
            x = int.Parse(Console.ReadLine()); 
            Console.Write("Informe o valor de \'y\': ");
            y = int.Parse(Console.ReadLine());
            total = x * y;
            Console.WriteLine("Resultado:" +total.ToString("n2"));
            Console.ReadKey();
        }
    }
}
