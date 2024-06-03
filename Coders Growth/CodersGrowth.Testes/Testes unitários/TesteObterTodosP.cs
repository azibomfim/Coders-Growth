using CodersGrowth.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;

namespace CodersGrowth.Testes.Testes_unitários
{
    
    public class TesteObterTodosP : TesteBase
    {
        protected IServicoPersonagem servicoP;
        public TesteObterTodosP()
        {
            servicoP = ServiceProvider.GetService<IServicoPersonagem>();
        }   
        [Fact]
        public void ObterTodos() 
        {
            
            Personagem p = new Personagem();

            var lista = 
        }
    }
}
