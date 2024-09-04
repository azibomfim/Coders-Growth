using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Dominio.Enums
{
    public static class ExtensaoDosEnuns
    {
        public static T? ObterAtributoDoTipo<T>(this Enum valorEnum) where T : System.Attribute
        {
            var tipo = valorEnum.GetType();
            var informacaoDoMembro = tipo.GetMember(valorEnum.ToString());
            var atributos = informacaoDoMembro[0].GetCustomAttributes(typeof(T), false);
            return (atributos.Length > 0)
                ? (T)atributos[0]
                : null;
        }

        public static string ObterDescricao(this Enum valorEnum)
        {
            var descricao = valorEnum.ObterAtributoDoTipo<DescriptionAttribute>().Description;
            return descricao;
        }

        public static NomeEnum ConverterParaNomeEnum(BaseParaEnum<NomeEnum> baseEnum)
        {
            var nomes = Enum.GetValues(typeof(NomeEnum));
            foreach (var nome in nomes)
            {
                if (ExtensaoDosEnuns.ObterDescricao((Enum)nome) == baseEnum.Descricao)
                {
                    return (NomeEnum)(Enum)nome;
                }
            }
            throw new Exception("Nome não encontrado!");
        }

        public static ElementoEnum ConverterParaElementoEnum(BaseParaEnum<ElementoEnum> baseEnum)
        {
            var elementos = Enum.GetValues(typeof(ElementoEnum));
            foreach (var elemento in elementos)
            {
                if (ExtensaoDosEnuns.ObterDescricao((Enum)elemento) == baseEnum.Descricao)
                {
                    return (ElementoEnum)(Enum)elemento;
                }
            }
            throw new Exception("Elemento não encontrado!");
        }

        public static ArmaEnum ConverterParaArmaEnum(BaseParaEnum<ArmaEnum> baseEnum)
        {
            var armas = Enum.GetValues(typeof(ArmaEnum));
            foreach (var arma in armas)
            {
                if (ExtensaoDosEnuns.ObterDescricao((Enum)arma) == baseEnum.Descricao)
                {
                    return (ArmaEnum)(Enum)arma;
                }
            }
            throw new Exception("Arma não encontrada!");
        }
    }
}
