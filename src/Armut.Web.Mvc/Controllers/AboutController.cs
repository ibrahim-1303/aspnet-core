using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Armut.Controllers;

namespace Armut.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ArmutControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
