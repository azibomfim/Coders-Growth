using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoUsuario : TesteBase
    {
        private IServicoUsuario servicoU;
        public TesteServicoUsuario()
        {
            servicoU = ServiceProvider.GetService<IServicoUsuario>();
        }

        [Fact]
        public void deve_retornar_todos_os_usuarios() 
        {
            var listaDeUsuarios = servicoU.ObterTodos();

            Assert.NotNull(listaDeUsuarios);
            Assert.Equal(5, listaDeUsuarios.Count);
        }

        [Fact]
        public void deve_retornar_o_usuario_ratosmites_ao_passar_o_id_1()
        {
            int Uid = 1;
            var usuariosPorId = servicoU.ObterPorId(Uid);

            Assert.NotNull(usuariosPorId);
            Assert.Equal(1, usuariosPorId.Uid);
            Assert.Equal("rato smites", usuariosPorId.NomeDeUsuario);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(638879)]
        [InlineData(285128)]
        public void deve_retornar_um_erro_ao_passar_id_inexistente(int Uid)
        {
            var mensagemDeErroU = Assert.Throws<Exception>(() => servicoU.ObterPorId(Uid));

            Assert.Contains("Usuário não encontrado.", mensagemDeErroU.Message);

        }
    }
}
