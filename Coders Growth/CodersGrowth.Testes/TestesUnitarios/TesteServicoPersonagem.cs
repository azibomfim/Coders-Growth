using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Validacoes;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoPersonagem : TesteBase
    {
        private IServicoPersonagem servicoPersonagem;
        public TesteServicoPersonagem()
        {
            servicoPersonagem = ServiceProvider.GetService<IServicoPersonagem>();
        }   

        [Fact]
        public void deve_retornar_todos_os_personagens() 
        {
            var listaDePersonagens = servicoPersonagem.ObterTodos();

            Assert.NotNull(listaDePersonagens);
            Assert.Equal(5, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_o_personagem_xiao_ao_passar_o_id_1()
        {
            int Id = 1;
            var personagensPorId = servicoPersonagem.ObterPorId(Id);

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
            var mensagemDeErroP = Assert.Throws<Exception>(() => servicoPersonagem.ObterPorId(Id));

            Assert.Contains("Personagem não encontrado.", mensagemDeErroP.Message);
        }

        [Fact]
        public void deve_rejeitar_um_personagem_com_nome_vazio()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };

            var mensagemDeErroP =  Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um nome válido", mensagemDeErroP.Message);
        }

        [Fact]
        public void deve_rejeitar_um_personagem_com_nome_nulo()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = null,
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };

            var mensagemDeErroP = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um nome válido", mensagemDeErroP.Message);
        }

        [Fact]
        public void deve_rejeitar_um_personagem_com_arma_invalida()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = null,
                IdUsuario = 1,
            };

            var mensagemDeErroP = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira uma arma válida", mensagemDeErroP.Message);
        }

        [Fact]
        public void deve_rejeitar_um_personagem_com_elemento_invalido()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = null,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };

            var mensagemDeErroP = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um elemento válido", mensagemDeErroP.Message);
        }

        [Fact]
        public void deve_aceitar_um_personagem_valido()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };
            
            Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
        }

        [Fact]
        public void deve_rejeitar_idusuario_nulo_em_personagem_criado_por_usuario()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = null,
            };

            var mensagemDeErroP = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Assinale que o personagem foi criado por usuário", mensagemDeErroP.Message);
        }

        [Fact]
        public void deve_rejeitar_idusuario_em_personagem_nao_criado_por_usuario()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 0.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 0.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = false,
                ImgPersonagem = null,
                ConstelacaoLv = 0,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };

            var mensagemDeErroP = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Assinale que o personagem foi criado por usuário", mensagemDeErroP.Message);
        }
    }
}
