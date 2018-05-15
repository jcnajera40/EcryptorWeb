using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http.Headers;

namespace EcryptorWeb.Controllers
{
    public class TestController : Controller
    {

        private IHostingEnvironment hostingEnv;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test2()
        {
            ViewData["Message"] = "Test2 (from ontroller).";

            return View();
        }


        public TestController(IHostingEnvironment env)
        {
            hostingEnv = env;
        }

        [HttpPost]
        public IActionResult UploadFiles(IList<Microsoft.AspNetCore.Http.IFormFile> files)
        {
            //long size = 0;
            //foreach(var file in files)
            //{
            //    var filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            //    //filename = hostingEnv.WebRootPath + $@"\{filename}";
            //    filename = "~/temp/" + $@"\{filename}";
            //    size += file.Length;
            //    using (FileStream fs = System.IO.File.Create(filename))
            //    {
            //        file.CopyTo(fs);
            //        fs.Flush();
            //    }
            //}
            //ViewBag.Message = $"{files.Count} file(s) / {size} bytes uploaded successfully!";
            ViewBag.Message = "OK controller";
            return View();
        }

        [HttpPost]
        public IActionResult UploadFilesAjax()
        {
            long size = 0;
            var files = Request.Form.Files;
            foreach (var file in files)
            {
                var filename = ContentDispositionHeaderValue
                                .Parse(file.ContentDisposition)
                                .FileName
                                .Trim('"');
               // filename = hostingEnv.WebRootPath + $@"\{filename}";
                //filename = "~/temp/" + $@"\{filename}";
                filename = hostingEnv.WebRootPath + "\\temp" + $@"\{filename}";
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            string message = $"{files.Count} file(s) /{ size} bytes uploaded successfully!";
            return Json(message);
        }
    }
}