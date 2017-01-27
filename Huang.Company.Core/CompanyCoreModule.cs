using System.Reflection;
using Abp.Modules;

namespace Huang.Company
{
    public class CompanyCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
