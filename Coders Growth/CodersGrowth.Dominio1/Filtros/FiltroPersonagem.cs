using CodersGrowth.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodersGrowth.Dominio.Filtros
{
    public class FiltroPersonagem
    {
        public NomeEnum NomePersonagem { get; set; }
        public bool CriadoPorUsuario { get; set; }
        public ElementoEnum Elemento { get; set; }
        public ArmaEnum Arma { get; set; }
    }
}
