using DorukProje.Business.Concrete;
using DorukProje.Business.Interface;
using DorukProje.DataAccess.Concrete;
using DorukProje.DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtantion
    {
        public static void AddDependencies(this IServiceCollection services )
        {
            services.AddScoped<IEmirDal, EmirRepository>();
            services.AddScoped<IEmirService, EmirManager>();
        }
    }
}
