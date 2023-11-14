namespace Cassio.Rodrigues.Usuarios.Domain.Entities
{
    public class Alerta : Entity
    {
        public string Titulo { get; private set; }
        public string Origem { get; private set; }
        public string Pedido  { get; private set; }

        public Alerta() { }
        public Alerta(string titulo, string origem, string pedido)
        {
            Titulo = titulo;
            Origem = origem;
            Pedido = pedido;
        }
    }
}
