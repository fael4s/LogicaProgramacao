using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nt, qpp, vp, totalpp, totalsd;
            Console.Write("Qual o numero total de prestações: ");
            nt = double.Parse(Console.ReadLine());
            Console.Write("Qual o numero total de prestações pagas: ");
            qpp = double.Parse(Console.ReadLine());
            Console.Write("Qual o valor da prestação");
            vp = double.Parse(Console.ReadLine());

            totalpp = qpp * vp;
            Console.WriteLine("Total pago: " + totalpp);
            totalsd = (vp*nt)- totalpp;
            Console.WriteLine("Total devendo: " + totalpp);
            Console.ReadKey();


        }
    }
}
