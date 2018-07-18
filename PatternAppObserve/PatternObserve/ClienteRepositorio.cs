using System;

namespace PatternAppObserve.PatternObserve
{
    public class ClienteRepositorio : IClienteAcoes
    {
        public void ExecutaAcao(Cliente cliente) => 
            Console.WriteLine("=> Teste de comunicação do respositório");
    }
}
