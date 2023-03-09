using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Dados do usuario---\n");
            String nome, endereco, telefone;

            Console.Write("Nome: ");
            nome= Console.ReadLine();

            Console.Write("Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\t\t---Dados do usuario---\n");
            Console.WriteLine($"Nome: {nome}\nEdenreço: {endereco}\nTelefone: {telefone}");
        }
    }
}
