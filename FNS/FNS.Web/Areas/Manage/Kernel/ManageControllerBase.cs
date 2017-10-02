using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FNS.Web.Areas.Manage.Kernel
{
    public class ManageControllerBase : Controller
    {
        // GET: Manage/ManageControllerBase
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}