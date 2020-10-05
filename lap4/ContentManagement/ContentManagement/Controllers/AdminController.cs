using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ContentManagement.CustomFilter;

namespace ContentManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [AuthLogAttibute(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}