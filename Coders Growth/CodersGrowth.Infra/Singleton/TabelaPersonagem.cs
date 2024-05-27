using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth.Infra.Singleton
{
    public sealed class TabelaPersonagem
    {
        public static TabelaPersonagem instance;
        private TabelaPersonagem() { }
        public static TabelaPersonagem Instance
        {
            get
            {
                if (instance == null)
                    lock (typeof(TabelaPersonagem))
                        if (instance == null) instance = new TabelaPersonagem();

                return instance;
            }
        }
    }
}
