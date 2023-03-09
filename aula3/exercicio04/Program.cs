using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alt, comp, larg, volume;
            Console.Write("informe a altura do retangulo: ");
            alt= int.Parse(Console.ReadLine());
            Console.Write("informe a comprimento do retangulo: ");
            comp = int.Parse(Console.ReadLine());
            Console.Write("informe a largura do retangulo: ");
            larg = int.Parse(Console.ReadLine());

            volume = alt *comp *larg;
            Console.WriteLine("Resultado:" + volume.ToString("n2"));
            Console.ReadKey();
        }
    }
}
