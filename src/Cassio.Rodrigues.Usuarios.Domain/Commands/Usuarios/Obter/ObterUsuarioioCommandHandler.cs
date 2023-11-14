using Cassio.Rodrigues.Usuarios.Domain.Entities;
using Cassio.Rodrigues.Usuarios.Domain.ValueObjects;
using MediatR;

namespace Cassio.Rodrigues.Usuarios.Domain.Commands.Usuarios.Obter
{
    public class ObterUsuarioioCommandHandler : IRequestHandler<ObterUsuarioCommand, Usuario>
    {
        public Task<Usuario> Handle(ObterUsuarioCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(
                new Usuario(
                    "Cássio Rodrigues",
                    DateTime.Now.AddYears(-27),
                    new Endereco("Montenegro",
                                 "Coronel Apolinário de Moraes",
                                 "RS",
                                 "Brasil",
                                 "1115",
                                 "Residencial"))
               );
        }
    }
}
