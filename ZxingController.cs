using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZXingDemo.Controllers
{
    public class ZxingController : Controller
    {
        // GET: Zxing
        public ActionResult Index()
        {
            ZxingHelper.Generate1("http://baidu.com/");
            return View();
        }
    }
}