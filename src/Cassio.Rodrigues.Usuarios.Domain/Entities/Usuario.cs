using Cassio.Rodrigues.Usuarios.Domain.ValueObjects;
using static System.Net.Mime.MediaTypeNames;

namespace Cassio.Rodrigues.Usuarios.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Endereco Endereco { get; private set; }

        public List<Alerta> Alertas { get; private set; } = new List<Alerta>();

        public int Idade { get => CalculaIdade(); }

        public Usuario(string nome, DateTime dataNascimento, Endereco endereco)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;


            GerarAlertas();
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

        private void GerarAlertaNome(string nome)
        {
            Alertas.Add(new Alerta(titulo: "Alerta Nome", origem: Nome, pedido: nome));
        }

        private void GerarAlertaIdade(int idade)
        {
            Alertas.Add(new Alerta(titulo: "Alerta Idade", origem: Idade.ToString(), pedido: idade.ToString()));
        }

        private void GerarAlertaDataNascimento(DateTime dataNascimento)
        {
            Alertas.Add(new Alerta(titulo: "Alerta Data de Nascimento", origem: DataNascimento.ToString("dd/MM/yyyy"), pedido: dataNascimento.ToString("dd/MM/yyyy")));
        }

        private void GerarAlertas()
        {
            GerarAlertaDataNascimento(DateTime.Now);
            GerarAlertaIdade(66);
            GerarAlertaNome("Juanito");
        }
    }
}
