using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HH_client_manager.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HH_client_manager.Controllers
{
    public class PCLController : Controller
    {
        // GET: /<controller>/
        public String Index()
        {
            return "This is in the PCL Controller";
        }

        [HttpGet]
        public IActionResult PCL()
        {
            return View();
        }


        
        [HttpPost]
        public IActionResult Submit(PCL model)

        {
            String confirmation = "";

            if (ModelState.IsValid)
            {
                confirmation = "The form for " + model.PatientName + "was successfully submitted.";
            }
            else
            {
                confirmation = "Try again";
            }
            return Content(confirmation);
        }
        
    }
}
