using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Validacoes;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.Results;
using FluentValidation;
using CodersGrowth.Testes.Singleton;
using CodersGrowth.Servicos.Servicos;

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
            Assert.Equal(5, listaDeUsuarios.Count);
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
            var mensagemDeErroUsuario = Assert.Throws<Exception>(() => servicoUsuario.ObterPorId(Uid));
            Assert.Contains("Usuário não encontrado.", mensagemDeErroUsuario.Message);
        }

        //testes de criação

        [Fact]
        public void deve_aceitar_criacao_de_um_usuario_valido()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12547896,
                Uid = 10,
                AdventureRank = 60,
            };

            var usuarioCadastrado = servicoUsuario.Criar(usuario);
            Assert.Equal(usuarioCadastrado, usuario);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void deve_rejeitar_criacao_de_um_usuario_com_nome_nulo_ou_vazio(string NomeDeUsuario)
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = NomeDeUsuario,
                Senha = 12547896,
                Uid = 10,
                AdventureRank = 60,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um nome válido", mensagemDeErroUsuario.Message);
        }

        [Theory]
        [InlineData(16)]
        [InlineData(1234567890)]
        public void deve_rejeitar_criacao_de_um_usuario_com_senha_ivalida(int Senha)
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = Senha,
                Uid = 10,
                AdventureRank = 60,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_usuario_com_senha_nula()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = null,
                Uid = 10,
                AdventureRank = 60,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroUsuario.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(61)]
        public void deve_rejeitar_criacao_de_um_usuario_com_adventurerank_invalido(int AdventureRank)
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12345,
                Uid = 10,
                AdventureRank = AdventureRank,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_usuario_com_adventurerank_nulo()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12345,
                Uid = 10,
                AdventureRank = null,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroUsuario.Message);
        }

        //testes de edição

        [Fact]
        public void deve_aceitar_edicao_de_um_usuario_valido()
        {
            int idUsuario = 2;
            Usuario usuario = servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "aziazi";
            usuario.Senha = 12547896;
            usuario.Uid = 2;
            usuario.AdventureRank = 60;

            var usuarioAlterado = servicoUsuario.Editar(usuario);
            Assert.Equal(usuarioAlterado, usuario);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void deve_rejeitar_edicao_de_usuario_com_nome_invalido(string NomeDeUsuario)
        {
            int idUsuario = 4;
            Usuario usuario = servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = NomeDeUsuario;
            usuario.Senha = 12547896;
            usuario.Uid = 4;
            usuario.AdventureRank = 60;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Editar(usuario));
            Assert.Contains("Insira um nome válido", mensagemDeErroUsuario.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(61)]
        public void deve_rejeitar_edicao_de_usuario_com_adventurerank_invalido(int AdventureRank)
        {
            int idUsuario = 5;
            Usuario usuario = servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "abelhinha triste";
            usuario.Senha = 12547896;
            usuario.Uid = 5;
            usuario.AdventureRank = AdventureRank;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Editar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_usuario_com_adventurerank_nulo()
        {
            int idUsuario = 5;
            Usuario usuario = servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "abelhinha triste";
            usuario.Senha = 12547896;
            usuario.Uid = 5;
            usuario.AdventureRank = null;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Editar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroUsuario.Message);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(1234567890)]
        public void deve_rejeitar_edicao_de_usuario_com_senha_invalida(int Senha)
        {
            int idUsuario = 4;
            Usuario usuario = servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "foca fofocas";
            usuario.Senha = Senha;
            usuario.Uid = 4;
            usuario.AdventureRank = 10;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Editar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_usuario_com_senha_nula()
        {
            int idUsuario = 4;
            Usuario usuario = servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "foca fofocas";
            usuario.Senha = null;
            usuario.Uid = 4;
            usuario.AdventureRank = 10;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => servicoUsuario.Editar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_remover_usuario_com_sucesso()
        {
            var idDoUsuario = 3;
            servicoUsuario.Remover(idDoUsuario);

            var usuario = TabelaUsuario.Instancia.Find(usuario => usuario.Uid == idDoUsuario);
            Assert.Null(usuario);
        }
    }
}
