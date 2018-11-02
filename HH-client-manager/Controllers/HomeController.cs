using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HH_client_manager.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using OfficeOpenXml;
using System.Reflection;
using System.ComponentModel;

namespace HH_client_manager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }

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

        public IActionResult ExportGroup()
        {
            return View();
        }
        public IActionResult ExportPerson()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // creates an Excel file, returning it to the user without changing the page
        // currently creates a predefined dummy file
        public async Task<IActionResult> Export(/*object[] input,*/ string sFileName = @"demo.xlsx")
        {
            //// inputs
            //string sFileName = @"demo.xlsx"; // ideal file name
            TestingClass[] input = { new TestingClass("nameA", 42, "nameB"), new TestingClass("nameC", 24, "NameD") };
            ////


            string sWebRootFolder = _hostingEnvironment.WebRootPath; // the "wwwroot" folder location on server
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName)); // create Excel file, place in wwwroot folder
            var memory = new MemoryStream(); // necessary in order to be able to delete file before giving file to user
            


            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                using (var package = new ExcelPackage())
                {
                    // add sheet
                    ExcelWorksheet ws = package.Workbook.Worksheets.Add("Test Sheet");


                    //Excel file indices start on 1, not 0
                    int row = 1;
                    int col = 1;
                    //\\


                    // table header values
                    foreach (PropertyInfo property in input[0].GetType().GetProperties())
                    {
                        if (GetDisplayName(input[0].GetType(), property, true) != "")
                        {
                            ws.Cells[row, col].Value = GetDisplayName(input[0].GetType(), property, true);
                            col++;
                        }
                    }


                    // reset position in excel file to next row
                    row = 2;
                    col = 1;




                    // contents of each passed in instance
                    foreach (var v in input)
                    {
                        foreach (PropertyInfo property in input[0].GetType().GetProperties())
                        {
                            if (GetDisplayName(input[0].GetType(), property, true) != "")
                            {
                                ws.Cells[row, col].Value = property.GetValue(v);
                                col++;
                            }
                        }
                        col = 1;
                        row++;
                    }

                    //// table values
                    //ws.Cells[3, 3].Value = "sample text";


                    //Autofit all
                    ws.Cells.AutoFitColumns(0);

                    // title file
                    package.Workbook.Properties.Title = "Test export file";

                    //finalize file
                    package.SaveAs(fs);
                }
            }

            // move file from saved-on-server to server-memory
            // TODO: cost/benefit analysis of current method vs finding way to delete file after returning it to browser
            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }

            //delete file on server after it's been placed in memory
            System.IO.File.Delete(Path.Combine(sWebRootFolder, sFileName));

            //send file in memory to user
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
            
        }

        // this fxn from https://forums.asp.net/t/1698787.aspx?How+do+I+access+the+DisplayName+attribute+of+a+property+in+code+
        private static String GetDisplayName(Type type, PropertyInfo info, bool hasMetaDataAttribute)
        {
            if (!hasMetaDataAttribute)
            {
                object[] attributes = info.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    var displayName = (DisplayNameAttribute)attributes[0];
                    return displayName.DisplayName;
                }
                return info.Name;
            }
            PropertyDescriptor propDesc = TypeDescriptor.GetProperties(type).Find(info.Name, true);
            DisplayNameAttribute displayAttribute =
                propDesc.Attributes.OfType<DisplayNameAttribute>().FirstOrDefault();
            return displayAttribute != null ? displayAttribute.DisplayName : "";
        }
    }
}
