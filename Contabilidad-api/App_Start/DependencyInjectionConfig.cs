using Bussiness.Implementations;
using Bussiness.Interfaces;
using Common.Utilities;
using Data;
using Data.Common;
using Data.Implementations;
using Data.Interfaces;
using Data.ModelData;

namespace Contabilidad_api.App_Start
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterDependecyInjectionConfig(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            HelperConfiguration.Configuration = Configuration;

            services.AddScoped<SpDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ILoggerSp<>), typeof(LoggerSp<>));
            services.AddScoped(typeof(IExceptionHandle), typeof(ExceptionHandle));



            //Business
            services.AddScoped(typeof(IProductoBusiness), typeof(ProductoBusiness));
            services.AddScoped(typeof(IClienteBusiness), typeof(ClienteBusiness));
            //Data
            services.AddScoped(typeof(IClienteData), typeof(ClienteData));
            services.AddScoped(typeof(IProductoData), typeof(ProductoData));

        }
    }
}
