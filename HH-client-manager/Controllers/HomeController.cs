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
using Microsoft.AspNetCore.Hosting;
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

        // creates an Excel file, returning it to the user without changing the page
        // currently creates a predefined dummy file
        public async Task<IActionResult> Export(/*object[] input,*/ string sFileName = @"Report.xlsx")
        {
            Models.Database.Client[] input = { new Models.Database.Client("S0000-1", new DateTime(1970,10,10), "Single","Andrew W.","No notes at this time.","Female","Other","White / Caucasian","N/A"), new Models.Database.Client("S1234-5", new DateTime(1990, 10, 10), "Single", "Barbara E.", "No notes at this time.", "Male", "Other", "Other", "N/A") };


            string sWebRootFolder = _hostingEnvironment.WebRootPath; // the "wwwroot" folder location on server
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName)); // create Excel file, place in wwwroot folder
            var memory = new MemoryStream(); // necessary in order to be able to delete file before giving file to user


            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                using (var package = new ExcelPackage())
                {
                    // add sheet
                    ExcelWorksheet ws = package.Workbook.Worksheets.Add(input[0].GetType().Name); // name of worksheet is name of class


                    //Excel file indices start on 1, not 0
                    int row = 1;
                    int col = 1;
                    //\\


                    // table header values
                    foreach (PropertyInfo property in input[0].GetType().GetProperties())
                    {
                        ws.Cells[row, col].Value = GetDisplayName(input[0].GetType(), property, true);
                        col++;
                    }


                    // reset position in excel file to next row
                    row = 2;
                    col = 1;




                    // contents of each passed in instance
                    foreach (var v in input)
                    {
                        foreach (PropertyInfo property in input[0].GetType().GetProperties())
                        {
                            ws.Cells[row, col].Value = property.GetValue(v);
                            col++;
                        }
                        col = 1;
                        row++;
                    }

                    //// table values
                    //ws.Cells[3, 3].Value = "sample text";


                    //Autofit all
                    ws.Cells.AutoFitColumns(0);

                    // title file
                    package.Workbook.Properties.Title = input[0].GetType().Name + " Test export file";

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
            return displayAttribute != null ? displayAttribute.DisplayName : info.Name;
        }
    }
}
