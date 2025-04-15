using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treino.Features.Interface;

namespace treino.Features
{
    internal class Apresentacao : IApresentacao
    {
        public string Nome { get; private set; }
        public int Idade;

        public Apresentacao()
        {
            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite sua Idade: ");
            while (!int.TryParse(Console.ReadLine(), out Idade))
            {
                Console.Write("Idade inválida, digite novamente: ");
            }
        }

        public void Resultado()
        {
            if (Idade >= 18)
            {
                Console.WriteLine($"Olá {Nome} voce tem {Idade}, é maior de idade.");
            }
            else
            {
                Console.WriteLine("Voce é menor de idade.");
            }
        }

        
    }
}
