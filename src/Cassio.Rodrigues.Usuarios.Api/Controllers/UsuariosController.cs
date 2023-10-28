using Microsoft.AspNetCore.Mvc;

namespace Cassio.Rodrigues.Usuarios.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Obter()
        {
            return new List<string> { "Cássio", "Ronaldo", "Moacir" };
        }
    }
}