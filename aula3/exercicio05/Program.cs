using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lt, km, qdq;
            Console.Write("Informe a quantidade de litos: ");
            lt = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de quilômetros percorridos: ");
            qdq = int.Parse(Console.ReadLine());
            km = qdq / lt;
            Console.WriteLine("Resultado:" + km.ToString("n2"));
            Console.ReadKey();
        }
    }
}
