using ETicaretAPI.Apllication.Services;
using ETicaretAPI.Infrustructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrustructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrustructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFileService, FileService>();
        }
    }
}
