using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Servicos.Validacoes;
using CodersGrowth.Testes.Singleton;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.ConstrainedExecution;

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
            var mensagemDeErroPersonagem = Assert.Throws<Exception>(() => servicoPersonagem.ObterPorId(Id));
            Assert.Contains("Personagem não encontrado.", mensagemDeErroPersonagem.Message);
        }

        //testes de criação

        [Fact]
        public void deve_aceitar_criacao_de_um_personagem_valido()
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

            var personagemCadastrado = servicoPersonagem.Criar(personagem);
            Assert.Equal(personagemCadastrado, personagem);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void deve_rejeitar_criacao_de_um_personagem_com_nome_nulo_ou_vazio(string NomePersonagem)
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomePersonagem,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um nome válido", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_arma_invalida()
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira uma arma válida", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_elemento_invalido()
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um elemento válido", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_personagem_criado_por_usuario_caso_id_nulo()
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Personagem não foi criado por usuário", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_retornar_erro_caso_personagem_nao_criado_por_usuario_apesar_de_ter_id()
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Assinale que o personagem foi criado por usuário", mensagemDeErroPersonagem.Message);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(7)]
        public void deve_rejeitar_criacao_de_um_personagem_com_constelacao_invalida(int ConstelacaoLv)
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
                ConstelacaoLv = ConstelacaoLv,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um nível de constelação de 0 a 6", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_constelacao_nula()
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
                ConstelacaoLv = null,
                DataDeAquisicao = null,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um nível de constelação de 0 a 6", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_proficiencia_nula()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = null,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Proficiência deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_proficiencia_negativa()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = -68,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Proficiência deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_vida_negativa()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = -17355,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Vida deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_vida_nula()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = null,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Vida deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_defesa_nula()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = null,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Defesa deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_defesa_negativa()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = 1585,
                Defesa = -767,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Defesa deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_ataque_nulo()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = null,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Ataque deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_ataque_negativo()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = "Eula",
                Vida = 17355,
                Ataque = -1585,
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

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Criar(personagem));
            Assert.Contains("Ataque deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        //testes de edição

        [Fact]
        public void deve_aceitar_edicao_de_personagem_valido()
        {
            var idDoPersonagem = 5;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 71;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;

            var personagemAlterado = servicoPersonagem.Editar(personagem);
            Assert.Equal(personagemAlterado, personagem);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(7)]
        public void deve_rejeitar_edicao_de_personagem_com_constelacao_invalida(int ConstelacaoLv)
        {
            var idDoPersonagem = 2;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = ConstelacaoLv;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 89;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Insira um nível de constelação de 0 a 6", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_constelacao_nula()
        {
            var idDoPersonagem = 2;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = null;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 89;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Insira um nível de constelação de 0 a 6", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_proficiencia_negativa()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = -1;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Proficiência deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_proficiencia_nula()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = null;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Proficiência deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_vida_negativa()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = -1;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Vida deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_vida_nula()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = null;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Vida deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_defesa_negativa()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = -1;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 29810;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Defesa deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_defesa_nula()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = null;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 29810;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Defesa deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_ataque_negativo()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = -1;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Ataque deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_ataque_nulo()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = null;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Ataque deve ser maior que 0", mensagemDeErroPersonagem.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void deve_rejeitar_edicao_de_personagem_com_nome_invalido(string NomePersonagem)
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.NomePersonagem = NomePersonagem;
            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1645;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Insira um nome válido", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_arma_invalida()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.Arma = null;
            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1234;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Insira uma arma válida", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_elemento_invalido()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.Elemento = null;
            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1234;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;
            personagem.CriadoPorUsuario = true;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Insira um elemento válido", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_nulo()
        {
            Personagem personagem = null;
            var mensagemDeErroPersonagem = Assert.Throws<Exception>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Ocorreu um erro na aplicação: Personagem não retornado", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_sem_idusuario_criado_por_usuario()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.IdUsuario = null;
            personagem.CriadoPorUsuario = true;
            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1234;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Personagem não foi criado por usuário", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_idusuario_nao_criado_por_usuario()
        {
            var idDoPersonagem = 4;
            Personagem personagem = servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.IdUsuario = 1;
            personagem.CriadoPorUsuario = false;
            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 0.00m;
            personagem.Ataque = 1234;
            personagem.Escudo = 0.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => servicoPersonagem.Editar(personagem));
            Assert.Contains("Assinale que o personagem foi criado por usuário", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_remover_personagem_com_sucesso()
        {
            var idDoPersonagem = 3;
            servicoPersonagem.Remover(idDoPersonagem);

            var personagem = TabelaPersonagem.Instancia.Find(personagem => personagem.Id == idDoPersonagem);
            Assert.Null(personagem);
        }
    }
}
