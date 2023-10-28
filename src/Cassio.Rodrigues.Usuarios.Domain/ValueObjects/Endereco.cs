namespace Cassio.Rodrigues.Usuarios.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public string Cidade { get; private set; }
        public string Logradouro { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }

        protected Endereco() { }

        public Endereco(string cidade, string logradouro, string estado, string pais, string numero, string complemento)
        {
            Cidade = cidade;
            Logradouro = logradouro;
            Estado = estado;
            Pais = pais;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
