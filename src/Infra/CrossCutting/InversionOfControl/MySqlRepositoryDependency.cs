using Domain.Interfaces;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.InversionOfControl
{
    public static class MySqlRepositoryDependency
    {
        public static void AddMySqlRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWorker, WorkerRepository>();
        }
    }
}
