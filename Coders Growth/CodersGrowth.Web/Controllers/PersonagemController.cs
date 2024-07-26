using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace CodersGrowth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private readonly ServicoPersonagem _servicoPersonagem;

        public PersonagemController (ServicoPersonagem servicoPersonagem)
        {
            _servicoPersonagem = servicoPersonagem;
        }

        [HttpGet]
        public OkObjectResult ObterTodos([FromQuery]FiltroPersonagem? filtroPersonagem)
        {
            var personagens = _servicoPersonagem.ObterTodos(filtroPersonagem);
            return Ok(personagens);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId([FromRoute]int id)
        {
            var personagem = _servicoPersonagem.ObterPorId(id);
            return Ok(personagem);
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Personagem personagemCriar)
        {
            _servicoPersonagem.Criar(personagemCriar);
            return Created($"novoPersonagem/{personagemCriar.Id}", personagemCriar);
        }

        [HttpPatch]
        public NoContentResult Editar([FromBody] Personagem personagemEditar)
        {
            _servicoPersonagem.Editar(personagemEditar);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Remover([FromRoute]int id)
        {
            _servicoPersonagem.Remover(id);
            return NoContent();
        }
    }
}


