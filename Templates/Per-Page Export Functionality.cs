/*
Checklist for Export() to work in a given Controller:
O- _hostingEnvironment global(?) variable declared
O- _hostingEnvironment here in HomeController()
O- Task<IActionResult> Export() here
O- String GetDisplayName() here
O- using OfficeOpenXml;
*/


private readonly IHostingEnvironment _hostingEnvironment;


public HomeController(IHostingEnvironment environment)
{
    _hostingEnvironment = environment;
}


// creates an Excel file, returning it to the user without changing the page
// currently creates a predefined dummy file
public async Task<IActionResult> Export(string sFileName = @"Report.xlsx", object[] input)
{
    //string sFileName = @"demo.xlsx"; // ideal file name
    //TestingClass[] input = { new TestingClass("nameA", 42, "nameB"), new TestingClass("nameC",24,"NameD")};


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
    return displayAttribute != null ? displayAttribute.DisplayName : info.Name;
}

