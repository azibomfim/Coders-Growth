using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Infra.Singleton
{
    public sealed class TabelaUsuario
    {
        public static TabelaUsuario instance;
        private TabelaUsuario() { }
        public static TabelaUsuario Instance
        {
            get
            {
                if (instance == null)
                    lock (typeof(TabelaUsuario))
                        if (instance == null) instance = new TabelaUsuario();

                return instance;
            }
        }
    }
}
