using System;

namespace Projeto_Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Digite o número do seu documento: ");
            string Documento = Console.ReadLine();
            Console.Write("Digite o nome da sua rua: ");
            string NomeDaRua = Console.ReadLine();
            Console.Write("Digite o número da sua casa: ");
            UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Digite seu gênero. Pressione F para feminino e M para masculino: ");
            string Genero = Console.ReadKey().KeyChar.ToString().ToUpper();


            DadosUsuario dados = new DadosUsuario(Nome, Idade, Documento, NomeDaRua, NumeroDaCasa, Genero);
            dados.ExibirInformações();
            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
