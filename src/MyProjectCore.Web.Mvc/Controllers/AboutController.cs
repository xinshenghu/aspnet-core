using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyProjectCore.Controllers;

namespace MyProjectCore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MyProjectCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
