using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TaawonMVC.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TaawonMVCControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}