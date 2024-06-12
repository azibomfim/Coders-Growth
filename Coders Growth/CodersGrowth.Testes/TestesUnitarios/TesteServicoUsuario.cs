using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Validacoes;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.Results;
using FluentValidation;
using CodersGrowth.Testes.Singleton;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoUsuario : TesteBase
    {
        private IServicoUsuario servicoUsuario;
        public TesteServicoUsuario()
        {
            servicoUsuario = ServiceProvider.GetService<IServicoUsuario>();
        }

        [Fact]
        public void deve_retornar_todos_os_usuarios() 
        {
            var listaDeUsuarios = servicoUsuario.ObterTodos();

            Assert.NotNull(listaDeUsuarios);
            Assert.Equal(6, listaDeUsuarios.Count);
        }

        [Fact]
        public void deve_retornar_o_usuario_ratosmites_ao_passar_o_id_1()
        {
            int Uid = 1;
            var usuariosPorId = servicoUsuario.ObterPorId(Uid);

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
            var mensagemDeErroU = Assert.Throws<Exception>(() => servicoUsuario.ObterPorId(Uid));
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

            servicoUsuario.Criar(usuario);
            var usuarioCadastrado = TabelaUsuario.Instancia.Contains(usuario);

            Assert.True(usuarioCadastrado);
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

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um nome válido", mensagemDeErroU.Message);
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_nome_nulo()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = null,
                Senha = 12547896,
                Uid = 10,
                AdventureRank = 60,
            };

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um nome válido", mensagemDeErroU.Message);
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

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroU.Message);
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

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroU.Message);
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

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroU.Message);
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

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroU.Message);
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

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroU.Message);
        }

        [Fact]
        public void deve_rejeitar_um_usuario_com_adventurerank_nulo()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12345,
                Uid = 10,
                AdventureRank = null,
            };

            var mensagemDeErroU = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroU.Message);
        }
    }
}
