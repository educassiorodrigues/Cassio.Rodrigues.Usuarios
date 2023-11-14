using Cassio.Rodrigues.Usuarios.Domain.Commands.Usuarios.Obter;
using Cassio.Rodrigues.Usuarios.Domain.Entities;
using Cassio.Rodrigues.Usuarios.Domain.ValueObjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cassio.Rodrigues.Usuarios.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuariosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<Usuario> Listar()
        {
            return new List<Usuario> { 
                new Usuario("Cássio Rodrigues", DateTime.Now.AddYears(-27), new Endereco("Montenegro", "Coronel Apolinário de Moraes", "RS", "Brasil", "1115", "Residencial")),
                new Usuario("Jorge Rodrigues", DateTime.Now.AddYears(-33), new Endereco("Porto Alegre", "Coronel Moacir de Moraes", "RS", "Brasil", "5465", "Residencial")),
                new Usuario("Moacir Rodrigues", DateTime.Now.AddYears(-45), new Endereco("Rio Grande", "Coronel Jorge de Moraes", "RS", "Uruguai", "1212", "Residencial"))
            };
        }

        [HttpGet("Obter")]
        public async Task<Usuario> Obter()
        {
            return await _mediator.Send(new ObterUsuarioCommand());
        }
    }
}