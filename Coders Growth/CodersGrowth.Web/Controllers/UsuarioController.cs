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
        public IActionResult ObterTodos([FromQuery] FiltroUsuario? filtroUsuario)
        {
            var usuarios = _servicoUsuario.ObterTodos(filtroUsuario);
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var usuario = _servicoUsuario.ObterPorId(id);
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Usuario usuarioCriar)
        {
            _servicoUsuario.Criar(usuarioCriar);
            return CreatedAtAction(nameof(ObterPorId), new { id = usuarioCriar.Id }, usuarioCriar);
        }

        [HttpPut]
        public IActionResult Editar([FromBody] Usuario usuarioEditar)
        {
            _servicoUsuario.Editar(usuarioEditar);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _servicoUsuario.Remover(id);
            return NoContent();
        }
    }
}
