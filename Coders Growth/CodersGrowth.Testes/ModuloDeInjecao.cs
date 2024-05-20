using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio;
using CodersGrowth.Servicos;
using System.Security.Authentication.ExtendedProtection;

namespace CodersGrowth.Testes
{
    public class ModuloDeInjecao
    {
        public static ServiceCollection Servicos { get; private set; }
        public ModuloDeInjecao()
        {
            var servicos = new ServiceCollection();

            servicos.AddSingleton<IServicoPersonagem, ServicoPersonagem>();


        }