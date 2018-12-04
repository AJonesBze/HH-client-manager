using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HH_client_manager.Models;
using System.IO;
using OfficeOpenXml;
using System.Data;


namespace HH_client_manager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        // via https://docs.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-2.1
        // handles any and all uploaded files from a particular upload action
        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();
            string output = "";

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream); // POST's file stuffed into stream
                        ExcelPackage package = new ExcelPackage(stream); // call the stream data an Excel file
                        DataTable dt = new DataTable(); // DataTable
                        dt = package.ToDataTable(); // stuff Excel file into DataTable (skips header row)
                        //List<DataRow> listOfRows = new List<DataRow>(); // Bunch of DataRows
                        //listOfRows = dt.AsEnumerable().ToList(); // DataTable (which consists of rows) is now a List of DataRows, which is great for enumerating through them
                        output += ExcelPackageExtensions.ConvertDataTableToHTML(dt);
                        
                    }
                }
            }



            return new ContentResult()
            {
                Content = output
            };
        }

    }
}
