using System.Reflection;
using Abp.Modules;

namespace Huang.Company
{
    [DependsOn(typeof(CompanyCoreModule))]
    public class CompanyApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
