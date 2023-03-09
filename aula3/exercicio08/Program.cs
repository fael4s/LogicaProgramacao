using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, some, sub, mult, div;
            Console.Write("Informe qual o numero 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe qual o numero 2: ");
            n2 = double.Parse(Console.ReadLine());
            some= n1 + n2;
            sub= n1 - n2;
            mult= n1 * n2;
            div= n1 / n2;
            Console.WriteLine("Resultado:" + some.ToString("n2"));
            Console.WriteLine("Resultado:" + sub.ToString("n2"));
            Console.WriteLine("Resultado:" + mult.ToString("n2"));
            Console.WriteLine("Resultado:" + div.ToString("n2"));
            Console.ReadKey();
        }
    }
}
