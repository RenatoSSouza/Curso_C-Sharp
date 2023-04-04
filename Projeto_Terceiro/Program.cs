﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Terceiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite S para sair ou um número para calcular o fatorial: ");
                string opcao = Console.ReadLine().ToUpper();

                if(opcao == "S")
                {
                    break;
                }
                else
                {
                    int valor = Convert.ToInt32(opcao);
                    if(valor == 0)
                    {
                        Console.WriteLine("0! = 1");
                    }
                    else if (valor < 0) 
                    {
                        Console.WriteLine("Impossivel calcular o fatorial de número negativo!");
                    }
                    else
                    {
                        int resultado = 1;
                        for(int i = valor; i > 0; i--)
                        {
                            resultado *= i;
                        }
                        Console.WriteLine($"O resultado de {valor}! = {resultado} ");
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            Console.WriteLine("Pressione qualquer tecla pra sair...");
            Console.ReadKey();
        }
    }
}
