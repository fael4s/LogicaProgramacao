using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nvcand1 = 0, nvcand2 = 0, nvcand3 = 0, nvcand4 = 0, nvbrancos = 0, nvnulos = 0, op;
            string resposta = "SIM",
            msg = "\n";
            int neleitores=0;   

            do
            {
                Console.WriteLine("Data: "+DateTime.Now.ToString("dd-mm-aaaa"));
                Console.WriteLine("\n\t\t---Qual a melhor serie de todos os tempos?---");
                Console.Write("\n\t1-Greys Anatomy \n\t2-Anne With an \"E\"\n\t3-The Walking Dead\n\t4-Supernatural\n\t5-Outra\n\t6-Não sabe!\n\nA opção é: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        nvcand1++;
                        break;
                    case 2:
                        nvcand2++;
                        break;
                    case 3:
                        nvcand3++;
                        break;
                    case 4:
                        nvcand4++;
                        break;
                    case 5:
                        nvbrancos++;
                        break;
                    case 6:
                        nvnulos++;
                        break;
                        default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nVoto realizado com sucesso!");
                Console.WriteLine("\nDeseja depositar outro voto? \nDigite [S] ou [N]");
                resposta = Console.ReadLine().ToUpper();
                Console.Clear();


            } while (resposta == "SIM" || resposta == "S");
            neleitores = nvcand1 + nvcand2 + nvcand3 + nvcand4 + nvbrancos + nvnulos;
            msg += $"\n\t1-Greys Anatomy ={nvcand1} \n\t2-Anne With an \"E\" ={nvcand2}\n\t3-The Walking Dead ={nvcand3}\n\t4-Supernatural = {nvcand4}\n\t5-Outra ={nvbrancos}\n\t6-Não sabe! ={nvnulos}";

            Console.WriteLine("\n\t\t---Resultado da votação---");
            Console.WriteLine("\nNumero total de votos: "+neleitores);
            Console.WriteLine("Total de votos por opção: "+msg);
            Console.ReadLine();

        }
    }
}
