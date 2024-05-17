using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Servicos;
using CodersGrowth.Dominio;

namespace CodersGrowth.Testes
{
    public class ModuloDeInjecao
    {
        public void ColetaDeServico()
        {
            var servicos = new ColetorDeServicos();

            servicos.AddSingleton<IServicoPersonagem, ServicoPersonagem>();


        }
        
        
    }
}
