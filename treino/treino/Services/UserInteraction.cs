using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treino.Features;
using treino.Features.Interface;

namespace treino.Services
{
    internal class UserInteraction
    {
        private readonly ICalculoPeso _calculoPeso;
        private readonly IApresentacao _apresentacao;

        public UserInteraction(ICalculoPeso calculoPeso, IApresentacao apresentacao)
        {
            _calculoPeso = calculoPeso;
            _apresentacao = apresentacao;
        }

        public void Execute()
        {
            _apresentacao.Resultado();
            _calculoPeso.Imc();
        }
    }
}
