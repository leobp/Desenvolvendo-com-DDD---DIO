using Domain.Interfaces;
using Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceWorker, WorkerService>();
        }
    }
}
