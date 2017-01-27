using System.Web.Mvc;

namespace Huang.Company.Web.Controllers
{
    public class HomeController : CompanyControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}