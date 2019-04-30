using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Collections;

namespace ZXingDemo.Controllers
{
    public class ZxingController : Controller
    {
        // GET: Zxing
        public ActionResult Index()
        {
            ZxingHelper.Generate1("http://192.168.124.8/Zxing/Upload");
            return View();
        }
        public ActionResult Upload()
        {
            return View();
        }
        
       
        //这个action是用来接收文件并保存在服务器上
        public ActionResult SaveAs(HttpPostedFileBase MyFile)
        {
            //文件在本地机器的绝对路径
            //var pathNamestr = MyFile.FileName;
            //文件名，不需要路径
            var StrFileName = Path.GetFileName(MyFile.FileName);
            //服务器文件夹，用来保存文件
            var ServerFile = Server.MapPath("/ServerFile/");
            //将接收到文件保存在服务器
            MyFile.SaveAs(Path.Combine(ServerFile, StrFileName));
            List<string> list = new List<string>();

            list.Add(StrFileName);


            ViewBag.List = list;

            //下面只是用来显示一些相关字符串做测试用
            //ViewBag.pathNamestr = pathNamestr;
            ViewBag.StrFileName = StrFileName;
            //ViewBag.ServerFile = ServerFile;

            return View();
        }
    }
}