using System;

namespace Projeto_Primeiro
{
    internal class DadosUsuario
    {
        public string Nome { get; set; }
        public UInt16 Idade { get; set; }
        public string Documento { get; set; }
        public string NomeDaRua { get; set; }
        public UInt32 NumeroDaCasa { get; set; }
        public string Genero { get; set; }

        public DadosUsuario(string nome, ushort idade, string documento, string nomeDaRua, uint numeroDaCasa, string genero)
        {
            Nome = nome;
            Idade = idade;
            Documento = documento;
            NomeDaRua = nomeDaRua;
            NumeroDaCasa = numeroDaCasa;
            Genero = genero;
        }

        public void ExibirInformações()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine($"Olá {Nome}");
            if (Idade <= 1 && Idade > 0)
            {
                Console.WriteLine($"Você tem {Idade} ano de idade");
            }
            else if (Idade == 0)
            {
                Console.WriteLine($"Você não tem idade suficiente para escrever aqui");
            }
            else
            {
                Console.WriteLine($"Você tem {Idade} anos de idade");
            }
            Console.WriteLine($"O número do documento informado é: {Documento}");
            Console.WriteLine($"O nome da sua rua é: {NomeDaRua}");
            Console.WriteLine($"O número da sua casa é: {NumeroDaCasa}");
            if (Genero == "F")
            {
                Genero = "Feminino";
            }
            else if (Genero == "M")
            {
                Genero = "Masculino";
            }
            Console.WriteLine($"O seu genero é: {Genero}");
            Console.WriteLine(" ");
        }
    }
}
