using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace HH_client_manager.Controllers
{
    public class TestingPageController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> OnPostExport()
        {
            string sWebRootFolder = _hostingEnvironment.WebRootPath;
            string sFileName = @"demo.xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                using (var package = new ExcelPackage())
                {
                    // add sheet
                    ExcelWorksheet ws = package.Workbook.Worksheets.Add("Test Sheet");

                    //add table headers
                    ws.Cells[1, 1].Value = "sample text";



                    //Autofit all
                    ws.Cells.AutoFitColumns(0);

                    // title file
                    package.Workbook.Properties.Title = "Test export file";

                    //finalize file
                    package.SaveAs(fs);
                }

                using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
                    
                memory.Position = 0;
                return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
            }
        }
    }
}