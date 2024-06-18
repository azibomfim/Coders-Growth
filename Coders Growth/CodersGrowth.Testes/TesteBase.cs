using Microsoft.Extensions.DependencyInjection;

namespace CodersGrowth.Testes
{
    public class TesteBase : IDisposable
    {
        protected ServiceProvider ServiceProvider;

        protected TesteBase()
        {
            var servicos = new ServiceCollection();
            ModuloDeInjecao.BindServices(servicos);

            ServiceProvider = servicos.BuildServiceProvider();
        }
        public void Dispose()
        {
            ServiceProvider.Dispose();
        }
    }
}