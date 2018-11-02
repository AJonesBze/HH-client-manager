using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HH_client_manager.Models;

namespace HH_client_manager.Controllers
{
    public class PPSRController : Controller
    {

        public String Index()
        {
            return "This is in the PPSR Controller";
        }
        [HttpGet]
        public IActionResult PPSR()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Submit(PPSR model)

        {
            String confirmation = "";

            if (ModelState.IsValid)
            {
                confirmation = "The form for " + model.ClientNumber + "was successfully submitted.";
            }
            else
            {
                confirmation = "Try again";
            }
            return Content(confirmation);
        }

    }
}