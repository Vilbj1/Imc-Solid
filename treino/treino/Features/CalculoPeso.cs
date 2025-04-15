using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using treino.Features.Interface;

namespace treino.Features
{
    internal class CalculoPeso : ICalculoPeso
    {
        public double Altura;
        public double Peso;
        public double Imc2;

        public CalculoPeso() 
        {
            Console.Write("Informe a sua altura: ");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe seu peso: ");
            Peso = double.Parse(Console.ReadLine());

        }

        public void Imc()
        {      
            Imc2 = Peso / (Altura * Altura);

            Console.WriteLine("Seu IMC é de "+ Imc2);
        }
    }
}
