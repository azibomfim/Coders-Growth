using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Testes.Singleton;
using System.Security.Cryptography;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoPersonagem : TesteBase
    {
        protected IServicoPersonagem servicoP;
        public TesteServicoPersonagem()
        {
            servicoP = ServiceProvider.GetService<IServicoPersonagem>();
        }   

        [Fact]
        public void deve_retornar_todos_os_personagens() 
        {
            var listaDePersonagens = servicoP.ObterTodos();

            Assert.NotNull(listaDePersonagens);
            Assert.Equal(5, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_o_personagem_xiao_ao_passar_o_id_1()
        {
            int Id = 1;
            var personagensPorId = servicoP.ObterPorId(Id);

            Assert.NotNull(personagensPorId);
            Assert.Equal(1, personagensPorId.Id);
            Assert.Equal("Xiao", personagensPorId.NomePersonagem);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(6786876)]
        [InlineData(28518)]
        public void deve_retornar_um_erro_ao_passar_id_inexistente(int Id)
        {
            var mensagemDeErroP = Assert.Throws<Exception>(() => servicoP.ObterPorId(Id));

            Assert.Contains("Personagem não encontrado.", mensagemDeErroP.Message);
        }
    }
}
