using HaraNoHara.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Threading;
using Microsoft.Cognitive.CustomVision;
using System.Net.Http;

namespace HaraNoHara.Web.Controllers
{

    public class HomeController : Controller
    {
        public static MemoryStream HaraFinalImage;
        public static HttpPostedFileBase HaraFinal;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( HttpPostedFileBase file)
        {
            

            if (ModelState.IsValid)
            {
                string haraImageLocation = "~/UploadedFiles/" + file.FileName;
                file.SaveAs(Server.MapPath(haraImageLocation));
                HaraFinalImage = new MemoryStream(System.IO.File.ReadAllBytes(haraImageLocation));


                HaraNoHara.Web.Prediction.Prediction.MakePrediction();

                return RedirectToAction("Results");

            }

             return View();
        }
        public ActionResult Results()
        {
            return View();
        }
    }
}