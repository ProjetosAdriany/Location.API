using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            // Transient: Cada vez que chama o service do user, ele inica uma nova estância 
            // Scoped: Depois que chama 10x, e le cria uma nova instância (Por ciclo de vida)
            // AddSingleton: Só cria uma única estância.

            // Quando chamar o IUserService é para usar com o UserService
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
