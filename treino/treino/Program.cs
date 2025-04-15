using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using treino.Features;
using treino.Services;

namespace treino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apresentacao = new Apresentacao();
            var calculoPeso = new CalculoPeso();         
            var userInteraction = new UserInteraction(calculoPeso, apresentacao);

            userInteraction.Execute();
        }
    }
}
