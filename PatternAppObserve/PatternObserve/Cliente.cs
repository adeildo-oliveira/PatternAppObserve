namespace PatternAppObserve.PatternObserve
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }

        public Cliente(string nome, string sobreNome, string email, string telefone,
            string endereco, int numero, string complemento)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
