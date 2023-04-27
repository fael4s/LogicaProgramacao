using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Ajuda nas compras--\n");
            Console.WriteLine("Informe o valor disponivel para compras: ");
            double saldo = double.Parse(Console.ReadLine());
            double compra = 0;
            double soma=0;
            bool compre = true;
            int contCompras = 0;
            do
            {
                Console.Write("\nValor da compra: ");
                compra = double.Parse(Console.ReadLine());

                if (compra>0)
                {
                    if (compra <= saldo)
                    {
                        saldo = saldo - compra;
                        soma = soma + contCompras;
                        contCompras++;
                        Console.WriteLine("\nPode comprar!\nSaldo disponivel: {0:c2}",saldo);
                    }
                    else
                    {
                        Console.WriteLine("\nNão pode comprar!\nSaldo insuficiente.");
                        compre = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nO valor informado deve ser positivo.");
                }

            } while ( compre==true );
            Console.Clear();
            Console.WriteLine("\t\t---Resultado de compras---");
            Console.WriteLine($"\nNúmero de compras: {contCompras}");
            Console.WriteLine("Total gasto: "+soma.ToString("c2"));
            Console.WriteLine("Saldo restante:{0:c2}",saldo);
        }
    }
}
