using Abp.Application.Services;

namespace Huang.Company
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class CompanyAppServiceBase : ApplicationService
    {
        protected CompanyAppServiceBase()
        {
            LocalizationSourceName = CompanyConsts.LocalizationSourceName;
        }
    }
}