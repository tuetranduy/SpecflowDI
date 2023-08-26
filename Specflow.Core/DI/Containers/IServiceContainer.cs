using Microsoft.Extensions.DependencyInjection;

namespace Specflow.Core.DI
{
    public interface IServiceContainer
    {
        void Register(IServiceCollection collection);
    }
}

