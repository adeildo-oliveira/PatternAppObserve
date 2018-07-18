using System;

namespace PatternAppObserve.PatternObserve
{
    public class ExibeDadosCliente : IClienteAcoes
    {
        public void ExecutaAcao(Cliente cliente) => 
            Console.WriteLine($"=> {cliente.Nome}\n=> {cliente.SobreNome}");
    }
}
