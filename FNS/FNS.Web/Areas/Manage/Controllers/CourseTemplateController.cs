using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FNS.Web.Areas.Manage.Controllers
{
    public class CourseTemplateController : Controller
    {
        // GET: Manage/CourseTemplate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}