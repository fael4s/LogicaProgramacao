using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {double semanas, meses, anos, dias;
            Console.Write("Informe a quantidade de dias: ");
            dias = double.Parse(Console.ReadLine());
            semanas = dias / 7;
            meses = dias / 30;
            anos = dias/ 365;
            Console.WriteLine("Resultado:" + semanas.ToString("n2"));
            Console.WriteLine("Resultado:" + meses.ToString("n2"));
            Console.WriteLine("Resultado:" + anos.ToString("n2"));
            Console.ReadKey();
        }
    }
}
