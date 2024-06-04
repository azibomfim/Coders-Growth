﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.InterfaceServico;
using CodersGrowth.Servicos.Servicos;

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
        public void ObterTodos() 
        {
            var listaDePersonagens = servicoP.ObterTodos();

            Assert.NotNull(listaDePersonagens);
            Assert.Equal(5, listaDePersonagens.Count);
        }
    }
}
