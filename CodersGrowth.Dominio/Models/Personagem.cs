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
        public Elemento elemento {  get; set; }
        public Arma tipoDeArma { get; set; }
        public string charName { get; set;  }
        public int charLv { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int em { get; set; }
        public double taxaCrit { get; set; }
        public double danoCrit { get; set; }
        public double bonusCura { get; set; }
        public double er { get; set; }
        public double shield { get; set; }
        public double elementalDmgBonus { get; set; }
        public int conLv { get; set; }
        public bool posse { get; set; }
        public byte[]? charImg { get; set; }
        public  DateTime? aqDate { get; set; }

    }
}
