using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Huang.Company.EntityFramework;

namespace Huang.Company
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(CompanyCoreModule))]
    public class CompanyDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<CompanyDbContext>(null);
        }
    }
}
