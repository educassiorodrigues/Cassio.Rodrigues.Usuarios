using Cassio.Rodrigues.Usuarios.Domain.ValueObjects;

namespace Cassio.Rodrigues.Usuarios.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Endereco Endereco { get; private set; }

        public int Idade { get => CalculaIdade(); }

        public Usuario(string nome, DateTime dataNascimento, Endereco endereco)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }
        private Usuario(){ }

        public int CalculaIdade()
        {
            var dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual.Month < DataNascimento.Month || (dataAtual.Month == DataNascimento.Month && dataAtual.Day < DataNascimento.Day))
                idade--;

            return idade;
        }
    }
}
