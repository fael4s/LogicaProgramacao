using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {int al1, al2, al3, al4, al5, media;
            Console.Write("informe a idade do aluno 1: ");
            al1= int.Parse(Console.ReadLine());
            Console.Write("informe a idade do aluno 2: ");
            al2 = int.Parse(Console.ReadLine());
            Console.Write("informe a idade do aluno 3: ");
            al3 = int.Parse(Console.ReadLine());
            Console.Write("informe a idade do aluno 4: ");
            al4 = int.Parse(Console.ReadLine());
            Console.Write("informe a idade do aluno 5: ");
            al5 = int.Parse(Console.ReadLine());

            media=(al1+al2 + al3 + al4 + al5)/5;
            Console.WriteLine("Resultado:" + media.ToString("n2"));
            Console.ReadKey();
        }
    }
}
