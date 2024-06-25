using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Testes.Singleton;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoUsuario : TesteBase
    {
        private ServicoUsuario _servicoUsuario;
        public TesteServicoUsuario()
        {
            _servicoUsuario = ServiceProvider.GetService<ServicoUsuario>();
        }

        [Fact]
        public void deve_retornar_todos_os_usuarios()
        {
            FiltroUsuario? filtro = null;
            var listaDeUsuarios = _servicoUsuario.ObterTodos(filtro);

            Assert.NotNull(listaDeUsuarios);
            Assert.Equal(6, listaDeUsuarios.Count);
        }

        [Fact]
        public void deve_retornar_usuarios_filtrando_por_AdventureRank()
        {
            FiltroUsuario? filtro = new FiltroUsuario {AdventureRank = 55};
            var listaDeUsuarios = _servicoUsuario.ObterTodos(filtro);

            Assert.NotNull(listaDeUsuarios);
            Assert.Equal(1, listaDeUsuarios.Count);
        }

        [Fact]
        public void deve_retornar_usuarios_filtrando_por_NomeDeUsuario()
        {
            FiltroUsuario? filtro = new FiltroUsuario {NomeDeUsuario = "abe"};
            var listaDeUsuarios = _servicoUsuario.ObterTodos(filtro);

            Assert.NotNull(listaDeUsuarios);
            Assert.Single(listaDeUsuarios);
        }

        [Fact]
        public void deve_retornar_o_usuario_ratosmites_ao_passar_o_id_1()
        {
            int Id = 1;
            var usuariosPorId = _servicoUsuario.ObterPorId(Id);

            Assert.NotNull(usuariosPorId);
            Assert.Equal(1, usuariosPorId.Id);
            Assert.Equal("rato smites", usuariosPorId.NomeDeUsuario);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(638879)]
        [InlineData(285128)]
        public void deve_retornar_um_erro_ao_passar_id_inexistente(int Id)
        {
            var mensagemDeErroUsuario = Assert.Throws<Exception>(() => _servicoUsuario.ObterPorId(Id));
            Assert.Contains("Usuário não encontrado.", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_aceitar_criacao_de_um_usuario_valido()
        {
            var usuario = new Usuario()
            {
                NomeDeUsuario = "aziazi",
                Senha = 12547896,
                Id = 10,
                AdventureRank = 60,
            };

            var usuarioCriado = usuario;
            _servicoUsuario.Criar(usuarioCriado);
            Assert.Equal(usuarioCriado, _servicoUsuario.ObterPorId(usuario.Id));
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
                Id = 10,
                AdventureRank = 60,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => _servicoUsuario.Criar(usuario));
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
                Id = 10,
                AdventureRank = 60,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => _servicoUsuario.Criar(usuario));
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
                Id = 10,
                AdventureRank = AdventureRank,
            };

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => _servicoUsuario.Criar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_aceitar_edicao_de_um_usuario_valido()
        {
            int idUsuario = 2;
            Usuario usuario = _servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "aziazi";
            usuario.Senha = 12547896;
            usuario.Id = 2;
            usuario.AdventureRank = 60;


            var usuarioEditado = usuario;
            _servicoUsuario.Editar(usuarioEditado);
            Assert.Equal(usuarioEditado, _servicoUsuario.ObterPorId(usuario.Id));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void deve_rejeitar_edicao_de_usuario_com_nome_invalido(string NomeDeUsuario)
        {
            int idUsuario = 4;
            Usuario usuario = _servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = NomeDeUsuario;
            usuario.Senha = 12547896;
            usuario.Id = 4;
            usuario.AdventureRank = 60;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => _servicoUsuario.Editar(usuario));
            Assert.Contains("Insira um nome válido", mensagemDeErroUsuario.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(61)]
        public void deve_rejeitar_edicao_de_usuario_com_adventurerank_invalido(int AdventureRank)
        {
            int idUsuario = 5;
            Usuario usuario = _servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "abelhinha triste";
            usuario.Senha = 12547896;
            usuario.Id = 5;
            usuario.AdventureRank = AdventureRank;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => _servicoUsuario.Editar(usuario));
            Assert.Contains("Insira um Adventure Rank entre 1 e 60", mensagemDeErroUsuario.Message);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(1234567890)]
        public void deve_rejeitar_edicao_de_usuario_com_senha_invalida(int Senha)
        {
            int idUsuario = 4;
            Usuario usuario = _servicoUsuario.ObterPorId(idUsuario);

            usuario.NomeDeUsuario = "foca fofocas";
            usuario.Senha = Senha;
            usuario.Id = 4;
            usuario.AdventureRank = 10;

            var mensagemDeErroUsuario = Assert.Throws<ValidationException>(() => _servicoUsuario.Editar(usuario));
            Assert.Contains("Sua senha precisa ter de 4 a 9 caracteres", mensagemDeErroUsuario.Message);
        }

        [Fact]
        public void deve_remover_usuario_com_sucesso()
        {
            var idDoUsuario = 3;
            _servicoUsuario.Remover(idDoUsuario);

            var usuario = TabelaSingletonUsuario.Instancia.Find(usuario => usuario.Id == idDoUsuario);
            Assert.Null(usuario);
        }
    }
}
