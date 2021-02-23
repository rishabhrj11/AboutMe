using AboutMe.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AboutMe.Controllers
{
    public class AboutController : Controller
    {
        private IAboutMe _AboutMe;
        public AboutController(IAboutMe AboutMe)
        {
            _AboutMe = AboutMe;
        }

        [HttpGet]
        public JsonResult GetDetails()
        {
            return Json(_AboutMe.getMyDetails(), JsonRequestBehavior.AllowGet);
        }

    }
}