using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Armut.Controllers;

namespace Armut.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ArmutControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
