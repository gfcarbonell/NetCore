using Cencosud.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cencosud.CrossCutting.Registers
{
    public static class IOCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterRepositories(services);
            return services;
        }
        public static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            //services.AddTransient<IClientService, ClientService>();
            return services;
        }
        public static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IClientRepository, ClientRepository>();
            return services;
        }
    }
}
