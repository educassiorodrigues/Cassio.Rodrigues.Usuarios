using Cassio.Rodrigues.Usuarios.Domain.Entities;
using MediatR;

namespace Cassio.Rodrigues.Usuarios.Domain.Commands.Usuarios.Obter
{
    public class ObterUsuarioCommand : IRequest<Usuario>
    {
    }
}
