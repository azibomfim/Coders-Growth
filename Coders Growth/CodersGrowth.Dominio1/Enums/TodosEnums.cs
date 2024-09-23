using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodersGrowth.Dominio.Enums;
using System.Threading.Tasks;

namespace CodersGrowth.Dominio.Enums
{
    public class TodosEnums
    {
        public List<BaseParaEnum<T>> ObterTodos<T>() where T : new()
        {
            var valores = new List<BaseParaEnum<T>>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                var enumerador = new BaseParaEnum<T>
                {
                    Key = (T)item,
                    Descricao = ((Enum)item).ObterDescricao()
                };

                valores.Add(enumerador);
            }
            return valores;
        }
    }
}
