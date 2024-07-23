using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Testes.Singleton;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes.TestesUnitarios
{
    public class TesteServicoPersonagem : TesteBase
    {
        private ServicoPersonagem _servicoPersonagem;
        public TesteServicoPersonagem()
        {
            _servicoPersonagem = ServiceProvider.GetService<ServicoPersonagem>();
        }

        [Fact]
        public void deve_retornar_todos_os_personagens()
        {
            var quantidadeRetornada = 5;
            FiltroPersonagem? filtro = null;
            var listaDePersonagens = _servicoPersonagem.ObterTodos(filtro);
            Assert.NotNull(listaDePersonagens);
            Assert.Equal(quantidadeRetornada, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_personagens_filtrando_por_NomePersonagem()
        {
            var quantidadeRetornada = 1;
            var filtro = new FiltroPersonagem { NomePersonagem = NomeEnum.HuTao };
            var listaDePersonagens = _servicoPersonagem.ObterTodos(filtro);
            Assert.NotNull(listaDePersonagens);
            Assert.Equal(quantidadeRetornada, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_personagens_filtrando_por_Arma()
        {
            var quantidadeRetornada = 4;
            var filtro = new FiltroPersonagem { Arma = ArmaEnum.Lanca };
            var listaDePersonagens = _servicoPersonagem.ObterTodos(filtro);
            Assert.NotNull(listaDePersonagens);
            Assert.Equal(quantidadeRetornada, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_personagens_filtrando_por_Elemento()
        {
            var quantidadeRetornada = 1;
            var filtro = new FiltroPersonagem { Elemento = ElementoEnum.Geo };
            var listaDePersonagens = _servicoPersonagem.ObterTodos(filtro);
            Assert.NotNull(listaDePersonagens);
            Assert.Equal(quantidadeRetornada, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_personagens_filtrando_por_DataDeAquisicao()
        {
            var quantidadeRetornada = 1;
            var filtro = new FiltroPersonagem { DataDeAquisicao = new DateTime(2021, 02, 17) };
            var listaDePersonagens = _servicoPersonagem.ObterTodos(filtro);
            Assert.NotNull(listaDePersonagens);
            Assert.Equal(quantidadeRetornada, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_personagens_filtrando_por_CriadoPorUsuario()
        {
            var quantidadeRetornada = 3;
            var filtro = new FiltroPersonagem { CriadoPorUsuario = true };
            var listaDePersonagens = _servicoPersonagem.ObterTodos(filtro);
            Assert.NotNull(listaDePersonagens);
            Assert.Equal(quantidadeRetornada, listaDePersonagens.Count);
        }

        [Fact]
        public void deve_retornar_o_personagem_xiao_ao_passar_o_id_1()
        {
            int Id = 1;
            var personagensPorId = _servicoPersonagem.ObterPorId(Id);

            Assert.NotNull(personagensPorId);
            Assert.Equal(1, personagensPorId.Id);
            Assert.Equal(NomeEnum.Xiao, personagensPorId.NomePersonagem);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(6786876)]
        [InlineData(28518)]
        public void deve_retornar_um_erro_ao_passar_id_inexistente(int Id)
        {
            var mensagemDeErroPersonagem = Assert.Throws<Exception>(() => _servicoPersonagem.ObterPorId(Id));
            Assert.Contains("Personagem não encontrado.", mensagemDeErroPersonagem.Message);
        }


        [Fact]
        public void deve_aceitar_criacao_de_um_personagem_valido()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomeEnum.Eula,
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 1.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 1.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var personagemCriado = personagem;
            _servicoPersonagem.Criar(personagemCriado);
            Assert.Equal(personagemCriado, _servicoPersonagem.ObterPorId(personagem.Id));
        }

        [Fact]
        public void deve_retornar_erro_caso_personagem_nao_criado_por_usuario_apesar_de_ter_id()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomeEnum.Eula,
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 1.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 1.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = false,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Criar(personagem));
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
                NomePersonagem = NomeEnum.Eula,
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 1.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 1.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ConstelacaoLv = ConstelacaoLv,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Criar(personagem));
            Assert.Contains("Insira um nível de constelação de 0 a 6", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_proficiencia_negativa()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomeEnum.Eula,
                Vida = 17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = -68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 10.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 1.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Criar(personagem));
            Assert.Contains("Proficiência deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_vida_negativa()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomeEnum.Eula,
                Vida = -17355,
                Ataque = 1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 10.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 1.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Criar(personagem));
            Assert.Contains("Vida deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_defesa_negativa()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomeEnum.Eula,
                Vida = 17355,
                Ataque = 1585,
                Defesa = -767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 10.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 10.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = false,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Criar(personagem));
            Assert.Contains("Defesa deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_criacao_de_um_personagem_com_ataque_negativo()
        {
            var personagem = new Personagem()
            {
                Id = 6,
                NomePersonagem = NomeEnum.Eula,
                Vida = 17355,
                Ataque = -1585,
                Defesa = 767,
                ProficienciaElemental = 68,
                TaxaCrit = 48.9m,
                DanoCrit = 151.1m,
                BonusCura = 10.0m,
                RecargaDeEnergia = 155.5m,
                Escudo = 10.0m,
                BonusElemental = 61.6m,
                CriadoPorUsuario = true,
                ConstelacaoLv = 1,
                DataDeAquisicao = DateTime.Now,
                Elemento = ElementoEnum.Cryo,
                Arma = ArmaEnum.Espadao,
                IdUsuario = 1,
                NomeUsuario = "rato smites"
            };

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Criar(personagem));
            Assert.Contains("Ataque deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_aceitar_edicao_de_personagem_valido()
        {
            var idDoPersonagem = 5;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 10.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 10.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 71;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;
            personagem.NomeUsuario = "rato smites";
            personagem.IdUsuario = 1;

            var personagemEditado = personagem;
            _servicoPersonagem.Editar(personagemEditado);
            Assert.Equal(personagemEditado, _servicoPersonagem.ObterPorId(personagem.Id));

        }

        [Theory]
        [InlineData(-1)]
        [InlineData(7)]
        public void deve_rejeitar_edicao_de_personagem_com_constelacao_invalida(int ConstelacaoLv)
        {
            var idDoPersonagem = 2;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 10.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 1.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = ConstelacaoLv;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 89;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;
            personagem.NomeUsuario = "rato smites";
            personagem.IdUsuario = 1;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Insira um nível de constelação de 0 a 6", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_proficiencia_negativa()
        {
            var idDoPersonagem = 4;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 1.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 1.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = -1;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32752;
            personagem.CriadoPorUsuario = true;
            personagem.NomeUsuario = "rato smites";
            personagem.IdUsuario = 1;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Proficiência deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_vida_negativa()
        {
            var idDoPersonagem = 4;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 1.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 1.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = -1;
            personagem.CriadoPorUsuario = true;
            personagem.NomeUsuario = "rato smites";
            personagem.IdUsuario = 1;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Vida deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_defesa_negativa()
        {
            var idDoPersonagem = 4;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 1.00m;
            personagem.Ataque = 1879;
            personagem.Escudo = 1.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = -1;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 29810;
            personagem.CriadoPorUsuario = true;
            personagem.NomeUsuario = "rato smites";
            personagem.IdUsuario = 1;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Defesa deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_ataque_negativo()
        {
            var idDoPersonagem = 4;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 10.00m;
            personagem.Ataque = -1;
            personagem.Escudo = 10.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;
            personagem.CriadoPorUsuario = true;
            personagem.NomeUsuario = "rato smites";
            personagem.IdUsuario = 1;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Ataque deve ter um valor positivo", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_nulo()
        {
            Personagem personagem = null;
            var mensagemDeErroPersonagem = Assert.Throws<NullReferenceException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Ocorreu um erro na aplicação: Personagem não retornado", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_rejeitar_edicao_de_personagem_com_idusuario_nao_criado_por_usuario()
        {
            var idDoPersonagem = 4;
            Personagem personagem = _servicoPersonagem.ObterPorId(idDoPersonagem);

            personagem.IdUsuario = 1;
            personagem.CriadoPorUsuario = false;
            personagem.TaxaCrit = 81.7m;
            personagem.DanoCrit = 207.5m;
            personagem.BonusCura = 10.00m;
            personagem.Ataque = 1234;
            personagem.Escudo = 10.0m;
            personagem.DataDeAquisicao = DateTime.Now;
            personagem.BonusElemental = 67.3m;
            personagem.ConstelacaoLv = 2;
            personagem.Defesa = 350;
            personagem.ProficienciaElemental = 79;
            personagem.RecargaDeEnergia = 136.7m;
            personagem.Vida = 32984;

            var mensagemDeErroPersonagem = Assert.Throws<ValidationException>(() => _servicoPersonagem.Editar(personagem));
            Assert.Contains("Assinale que o personagem foi criado por usuário", mensagemDeErroPersonagem.Message);
        }

        [Fact]
        public void deve_remover_personagem_com_sucesso()
        {
            var idDoPersonagem = 3;
            _servicoPersonagem.Remover(idDoPersonagem);

            var personagem = TabelaSingletonPersonagem.Instancia.Find(personagem => personagem.Id == idDoPersonagem);
            Assert.Null(personagem);
        }
    }
}
