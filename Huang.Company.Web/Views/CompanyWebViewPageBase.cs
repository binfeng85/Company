using Abp.Web.Mvc.Views;

namespace Huang.Company.Web.Views
{
    public abstract class CompanyWebViewPageBase : CompanyWebViewPageBase<dynamic>
    {

    }

    public abstract class CompanyWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CompanyWebViewPageBase()
        {
            LocalizationSourceName = CompanyConsts.LocalizationSourceName;
        }
    }
}