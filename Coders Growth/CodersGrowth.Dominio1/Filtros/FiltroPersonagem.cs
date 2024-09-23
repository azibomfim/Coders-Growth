using CodersGrowth.Dominio.Enums;
using System;

namespace CodersGrowth.Dominio.Filtros
{
    public class FiltroPersonagem
    {
        public NomeEnum? NomePersonagem { get; set; }
        public string? DataDeAquisicao { get; set; }
        public string? NomeUsuario { get; set; }
    }
}
