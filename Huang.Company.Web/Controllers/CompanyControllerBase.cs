using Abp.Web.Mvc.Controllers;

namespace Huang.Company.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class CompanyControllerBase : AbpController
    {
        protected CompanyControllerBase()
        {
            LocalizationSourceName = CompanyConsts.LocalizationSourceName;
        }
    }
}