using CodersGrowth.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Dominio.Models
{
    public class Personagem
    {
        public string charName { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int em { get; set; }
        public double taxaCrit { get; set; }
        public double danoCrit { get; set; }
        public double bonusCura { get; set; }
        double er { get; set; }
        public double shield { get; set; }
        double elementalDmgBonus { get; set; }
        public bool posse { get; set; }
        public byte[]? charImg { get; set; }
        public int conLv { get; set; }
        public DateTime? aqDate { get; set; }
        public ElementoEnum elemento { get; set; }
        public ArmaEnum arma { get; set; }
    }
}
