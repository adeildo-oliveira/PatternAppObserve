using PatternAppObserve.PatternObserve;
using System;

namespace PatternAppObserve
{
    class Program
    {
        static void Main(string[] args)
        {
            var clienteBuilder = new ClienteBuilder()
                .ComNome("João")
                .ComSobreNome("Silva")
                .ComEmail("teste@noemail.com")
                .AdicionaAcoes(new EnviaEmail())
                .AdicionaAcoes(new ClienteRepositorio())
                .AdicionaAcoes(new ExibeDadosCliente())
                .ConstroiCliente();

            Console.ReadKey();
        }
    }
}
