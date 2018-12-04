using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HH_client_manager.Models.Database;
using System.Data.SqlClient;
using HH_client_manager.Controllers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HH_client_manager
{
    public class PCLAssessmentController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {



            return View();
        }//end of Index

        [HttpGet]
        public IActionResult createPCLAssessment()
        {
            PCLAssessmentDataAccessLayer accessLayer = new PCLAssessmentDataAccessLayer();

            PCLAssessmentViewModel PCLData = new PCLAssessmentViewModel();
            PCLData.pCLDetailDataEntry = accessLayer.GetPCLDetailDataEntry();
            PCLData.pCLScale = accessLayer.GetPCLScale();

            PCLData.pCLAssessment = new Models.Database.PCLAssessment();

            return View(PCLData);

        }//end CreateAssessment GET


        [HttpPost]
        public IActionResult CreatePCLAssessment(PCLAssessmentViewModel pCLData)
        {
            if (ModelState.IsValid)
            {
                PCLAssessmentDataAccessLayer accessLayer = new PCLAssessmentDataAccessLayer();

                PCLAssessment pCLAssessment = pCLData.pCLAssessment;

                int sequenceNumber = accessLayer.CreatePCLAssessment(pCLAssessment);

                foreach (PCLDetailDataEntry detail in pCLData.pCLDetailDataEntry)
                {
                    accessLayer.WritePCLDetailRecord(sequenceNumber, detail);
                }//end foreach
            }//end if

            return View(pCLData);
        }//end CreateAssessment Post


    }//end of PCLAssessmentController
}//end of namespace
