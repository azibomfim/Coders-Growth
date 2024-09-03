using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio.Enums;
using CodersGrowth.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace CodersGrowth.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnumController : ControllerBase
    {
        private readonly TodosEnums servicoEnum;
        public EnumController()
        {
            servicoEnum = new TodosEnums();
        }

        [HttpGet("nomes")]
        public OkObjectResult ObterNomes()
        {
            var nomes = servicoEnum.ObterTodos<NomeEnum>().ToList<object>();
            return Ok(nomes);
        }

        [HttpGet]
        public OkObjectResult ObterArmas()
        {
            var armas = servicoEnum.ObterTodos<ArmaEnum>();
            return Ok(armas);
        }

        [HttpGet("hghsi")]
        public OkObjectResult ObterElementos()
        {
            var elementos = servicoEnum.ObterTodos<ElementoEnum>().ToList<object>();
            return Ok(elementos);
        }
    }
}