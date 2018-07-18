using System;

namespace PatternAppObserve.PatternObserve
{
    public class EnviaEmail : IClienteAcoes
    {
        public void ExecutaAcao(Cliente cliente) => 
            Console.WriteLine("=> Teste de envio de e-mail");
    }
}
