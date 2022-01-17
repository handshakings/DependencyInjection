using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary
{
    public static class ServiceForDI
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAddition, Addition>();
        }
    }
}
