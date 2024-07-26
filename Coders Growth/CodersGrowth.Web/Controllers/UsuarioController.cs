using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace CodersGrowth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ServicoUsuario _servicoUsuario;

        public UsuarioController(ServicoUsuario servicoUsuario)
        {
            _servicoUsuario = servicoUsuario;
        }

        [HttpGet]
        public OkObjectResult ObterTodos([FromQuery] FiltroUsuario? filtroUsuario)
        {
            var usuarios = _servicoUsuario.ObterTodos(filtroUsuario);
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId([FromRoute]int id)
        {
            var usuario = _servicoUsuario.ObterPorId(id);
            return Ok(usuario);
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Usuario usuarioCriar)
        {
            _servicoUsuario.Criar(usuarioCriar);
            return Created($"novoUsuario/{usuarioCriar.Id}", usuarioCriar);
        }

        [HttpPatch]
        public NoContentResult Editar([FromBody]Usuario usuarioEditar)
        {
            usuarioEditar.Id = id;
            _servicoUsuario.Editar(usuarioEditar);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Remover([FromRoute]int id)
        {
            _servicoUsuario.Remover(id);
            return NoContent();
        }
    }
}
