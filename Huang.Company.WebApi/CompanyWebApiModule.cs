using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Huang.Company
{
    [DependsOn(typeof(AbpWebApiModule), typeof(CompanyApplicationModule))]
    public class CompanyWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(CompanyApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
