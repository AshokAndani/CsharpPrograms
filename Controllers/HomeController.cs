// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ChunkFileUploads.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using ChunkFileUploads.Models;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Http;
    using System.Net.Http;

    /// <summary>
    /// HomeController Class which has the Actions to Upload the File
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// default Action to Render the Index Page according to MVC
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// this method Can be Called by our MVC as Well as Works as Web API
        /// </summary>
        /// <param name="file">File part</param>
        /// <returns>Http Message</returns>
        [DisableRequestSizeLimit]
        [EnableCors("AllowOrigin")]
        public JsonResult UploadFile(IFormFile file)
        {
            try
            {
                //// this object has the methods for Uploads
                var manager = new FileUploadManager();
                //// this method copies the incoming IFormFile to Server Hard Disk etc.
                manager.Copy(file);
                //// this method checks wether all the chunk files are available if available then merge them into single file
                manager.MergeFiles(file.FileName);
            }
            catch(Exception e)
            {
                return Json("Failed to Upload");
            }
            return Json("Successfully Uploaded the  File");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
