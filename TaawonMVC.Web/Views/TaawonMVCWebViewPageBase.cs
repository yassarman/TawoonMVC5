using Abp.Web.Mvc.Views;

namespace TaawonMVC.Web.Views
{
    public abstract class TaawonMVCWebViewPageBase : TaawonMVCWebViewPageBase<dynamic>
    {

    }

    public abstract class TaawonMVCWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TaawonMVCWebViewPageBase()
        {
            LocalizationSourceName = TaawonMVCConsts.LocalizationSourceName;
        }
    }
}