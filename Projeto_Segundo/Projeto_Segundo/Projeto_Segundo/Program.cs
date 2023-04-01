using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Segundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pressione A para alugar um filme ou S para sair da locadora: ");
            char opcao = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if(opcao == 'A' || opcao == 'a')
            {
                Console.WriteLine("Pressione 1 para alugar Top Gun");
                Console.WriteLine("Pressione 2 para alugar A bela e a fera");
                Console.WriteLine("Pressione 3 para alugar O homem aranha");
                int opcaoFilme =  Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                Console.WriteLine();

                switch(opcaoFilme)
                {
                    case 1: 
                        Console.WriteLine("Você alugou Top Gun");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou A bela e a fera");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou O homem aranha");
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida");
                        break;
                }
            }
            else if(opcao == 'S' || opcao == 's')
            {
                Console.WriteLine("Muito obrigado. Volte sempre!!");
            }
            else
            {
                Console.WriteLine("Opção desconhecida...");
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
