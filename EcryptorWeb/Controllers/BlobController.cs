using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Net.Http.Headers;
using EcryptorWeb.Models;

namespace EcryptorWeb.Controllers
{
    public class BlobController : Controller
    {

        private IHostingEnvironment hostingEnv;
        public BlobController(IHostingEnvironment env)
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
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult UploadFilesAjax()
        {
            Guid requestId = Guid.NewGuid();
            String str = "";
            EcryptorWeb.Helpers.EcryptorResponse rsp = new Helpers.EcryptorResponse(requestId);
            rsp.CreationDate = System.DateTime.Now.ToString("s");
            rsp.UserRequestorUpn = User.Identity.Name;

            rsp.UserCountry = "United States";
            rsp.UserRegion = "Texas";
            rsp.UserCity = "San Antonio";
            rsp.UserDpto = "Finance";
            rsp.UserJob = "Auditor";
            rsp.UserManager = "Ana@modernworkplacedemo.com";
            rsp.ResquestStatus = "Created";
            rsp.RequestorNotes = "Nome notes from the backend...";
            rsp.RequestIsActive = true;

            //string str = string.Empty;
            long size = 0;
            var files = Request.Form.Files;
            foreach (var file in files)
            {
                //var filename = System.Net.Http.Headers.ContentDispositionHeaderValue
                //                .Parse(file.ContentDisposition)
                //                .FileName
                //                .Trim('"');
                var filename = System.Net.Http.Headers.ContentDispositionHeaderValue
                           .Parse(file.ContentDisposition)
                           .Name
                           .Trim('"');
                filename = hostingEnv.WebRootPath + "\\temp" + $@"\{filename}";
                filename = filename.Replace('\\','/');
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                rsp.UploadedFiles.Add(filename);
                str += UploadFile2Ecryptor(rsp.UserRequestorUpn, filename, requestId) + "<br/>";
            }
            //string message = $"{files.Count} file(s) /{ size} bytes uploaded successfully!:<br/>{ str }";
            return Json(str);
        }

        private CloudBlobContainer GetEcryptorBlobContainer(string strContainerName = "ecryptor-inbox")
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfigurationRoot Configuration = builder.Build();

            // CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Configuration["evisorblobaccount_AzureStorageConnectionString"]);
            var evisorblobaccount_AzureStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=evisorblobaccount;AccountKey=pPDM2IEY2kbCyRnkzwR45Jk3EkRu5DPBxUqTuz//G2TmbVKOM+KjzECVnyIXTGt2Ehb5Oipg2Ln8BmZP6apSyw==;EndpointSuffix=core.windows.net";
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(evisorblobaccount_AzureStorageConnectionString);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(strContainerName);
            return container;
        }

        [HttpPost]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult DownloadMultipleFilesAsZip()
        {
            string toDownloadFileList = Request.Form["selectedFiles"];
            string[] files2Download = toDownloadFileList.Split('|');

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<div id=\"alert\" name=\"alert\" class=\"alert alert-success alert-dismissible\">");
            sb.Append("<a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>");
            sb.Append("<strong>Success!</strong>&nbsp;The following files will beging to download after a few moments:");
            sb.Append("<ul>");

            foreach (string f in files2Download)
            {
                if (f != string.Empty) { 
                    sb.Append("<li>");
                    sb.Append(f);
                    sb.Append("</li>");
                }
            }
            sb.Append("</ul>");
            sb.Append("</div>");
            string list = sb.ToString();
            return Json(list);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult RequestDownloadMultipleFilesAsZip2()
        {
            string responseMessage = string.Empty;
            if (Request.Form.ContainsKey("selectedFiles"))
            {
                string downloadRequestId = Guid.NewGuid().ToString();
                HttpContext.Session.SetString("downloadRequestID", downloadRequestId);

                HttpContext.Session.SetString("selectedFiles", Request.Form["selectedFiles"]);

                string defaultDownloadZipFileName = downloadRequestId + ".zip";
                if ((!Request.Form.ContainsKey("zipFileName")) || (Request.Form["zipFileName"] == string.Empty))
                    {
                        HttpContext.Session.SetString("zipFileName", defaultDownloadZipFileName); 
                    }
                else
                    {
                        HttpContext.Session.SetString("zipFileName", Request.Form["zipFileName"]);
                    }
                responseMessage = downloadRequestId;
            }
            else
            {
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //sb.Append("<div id=\"alert\" name=\"alert\" class=\"alert alert-danger alert-dismissible\">");
                //sb.Append("<a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>");
                //sb.Append("<strong>Error!</strong>&nbsp;No file has been selected. Please select the file(s) you want to download and try again.");
                //sb.Append("</div>");
                responseMessage = "ERR_NO_FILE_SELECTED";
            }
            return Json(responseMessage);
        }


        private static HttpClient Client { get; } = new HttpClient();

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult DownloadMultipleFilesAsZip2(Guid downloadRequestIDSubmmitted)
            {

           
            if (HttpContext.Session.Keys.Contains("downloadRequestID") &&
                HttpContext.Session.Keys.Contains("selectedFiles") &&
                HttpContext.Session.Keys.Contains("zipFileName") )
            {
                string downloadRequestId = HttpContext.Session.GetString("downloadRequestID");
                string selectedFiles = HttpContext.Session.GetString("selectedFiles");
                string zipFileName = HttpContext.Session.GetString("zipFileName");



                string[] files2Download = selectedFiles.Split('|');
                // create the download list
                CloudBlobContainer container = GetEcryptorBlobContainer("ecryptor-outbox");
                var blobCollection = new Dictionary<string, CloudBlockBlob>();
                foreach (string f in files2Download)
                {
                    if (f != string.Empty)
                    {
                        string[] fnparts = f.Split('_');
                        if (fnparts.Length == 3)
                        {
                            string originalFileName = fnparts[0].Replace("-", " ");
                            CloudBlockBlob blob = container.GetBlockBlobReference(f);
                            if (!blobCollection.ContainsKey(originalFileName))
                            {
                                blobCollection.Add(originalFileName, blob);
                            }
                        }
                    }
                }
                // Return the stream calback     
                return new FileCallbackResult(new Microsoft.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream"), async (outputStream, _) =>
                    {
                        using (var zipArchive = new ZipArchive(new WriteOnlyStreamWrapper(outputStream), ZipArchiveMode.Create))
                        {
                            foreach (var kvp in blobCollection)
                            {
                                MemoryStream mstr = new MemoryStream();
                                await kvp.Value.DownloadToStreamAsync(mstr);
                                var zipEntry = zipArchive.CreateEntry(kvp.Key);
                                using (var zipStream = zipEntry.Open())
                                await mstr.CopyToAsync(zipStream);
                            }
                        }
                    })
                    {
                        FileDownloadName = zipFileName
                    };
            }
            else
            {
                return Json("ERR_MALFORMED_DOWNLOAD_REQUEST");
            }
        }

        //public string DownloadAuthorizedfileFromEcryptor( )
        //{
        //    CloudBlobContainer container = GetEcryptorOutboxContainer();
        //    CloudBlockBlob blob = container.GetBlockBlobReference("myBlob");
        //    using (var fileStream = System.IO.File.OpenWrite(@"C:\temp\downloaded.xlsx"))
        //    {
        //        blob.DownloadToStreamAsync(fileStream).Wait();
        //    }
        //    return "success!";
        //}
        private string UploadFile2Ecryptor(string usr, string temporalFileName, Guid id)
        {
            string dt = DateTime.Now.ToString("s");
            // string[] bp = temporalFileName.Split("\\");
            string[] bp = temporalFileName.Split("/");
            string blobName = bp[bp.Length-1];
            blobName = blobName.Replace(" ", "-");
            blobName = blobName.ToLower();
            blobName = blobName + "_" + id.ToString() + "_" + usr;
            CloudBlobContainer ecryptorInBox = GetEcryptorBlobContainer("ecryptor-inbox");
            CloudBlockBlob blob = ecryptorInBox.GetBlockBlobReference(blobName);
            using (var fileStream = System.IO.File.OpenRead(temporalFileName))
            {
                blob.UploadFromStreamAsync(fileStream).Wait();
            }
            if (System.IO.File.Exists(temporalFileName))
            {
                System.IO.File.Delete(temporalFileName);
            }
            return blobName;
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult EcryptorRequest()
        {
            ViewData["Message"] = "";
            ViewData["RequestDate"] = "" ;
            
            return View();
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        public ActionResult ListMyFiles2(int? pageNumber)
        {
            CloudBlobContainer container = GetEcryptorBlobContainer("ecryptor-outbox");
            List<CAuthorizedFile> blobs = new List<CAuthorizedFile>();
            BlobResultSegment resultSegment = container.ListBlobsSegmentedAsync(null).Result;
            int idx = 0;
            foreach (IListBlobItem item in resultSegment.Results)
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    idx += 1;
                    CloudBlockBlob blob = (CloudBlockBlob)item;
                    CAuthorizedFile x = new CAuthorizedFile(blob,idx);
                    blobs.Add(x);
               
                }
                else if (item.GetType() == typeof(CloudPageBlob))
                {
                    idx += 1;
                    CloudBlockBlob blob = (CloudBlockBlob)item;
                    CAuthorizedFile x = new CAuthorizedFile(blob,idx);
                    blobs.Add(x);
                }
                else if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    // ignore folders for now...
                    //CloudBlobDirectory dir = (CloudBlobDirectory)item;
                    //blobs.Add(dir.Uri.ToString(), dir.Uri.ToString());
                }
            }

            return View(blobs);
        }

    }
   
}