using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Validacoes;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.Results;
using FluentValidation;

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

        [Fact]
        public void deve_aceitar_um_usuario_valido()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12547896,
                Uid = 10,
                AdventureRank = 60,
            };

            ValidacaoUsuario validacao = new ValidacaoUsuario();
            ValidationResult result = validacao.Validate(usuario);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_nome_vazio()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "",
                Senha = 12547896,
                Uid = 10,
                AdventureRank = 60,
            };

            Assert.Throws<ValidationException>(() => servicoU.Criar(usuario));
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_senha_menor_que_4_digitos()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 16,
                Uid = 10,
                AdventureRank = 60,
            };

            Assert.Throws<ValidationException>(() => servicoU.Criar(usuario));
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_senha_maior_que_9_digitos()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 1234567890,
                Uid = 10,
                AdventureRank = 60,
            };

            Assert.Throws<ValidationException>(() => servicoU.Criar(usuario));
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_senha_nula()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = null,
                Uid = 10,
                AdventureRank = 60,
            };

            Assert.Throws<ValidationException>(() => servicoU.Criar(usuario));
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_adventurerank_maior_que_60()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12345,
                Uid = 10,
                AdventureRank = 61,
            };

            Assert.Throws<ValidationException>(() => servicoU.Criar(usuario));
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_adventurerank_menor_que_0()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12345,
                Uid = 10,
                AdventureRank = -1,
            };

            Assert.Throws<ValidationException>(() => servicoU.Criar(usuario));
        }
    }
}
