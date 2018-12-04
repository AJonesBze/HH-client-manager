using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HH_client_manager.Models.Database;

namespace HH_client_manager
{
    public class PCLAssessmentViewModel
    {
        public PCLAssessment pCLAssessment { get; set; }
        public List<PCLDetailDataEntry> pCLDetailDataEntry { get; set; }
        public List<PCLScale> pCLScale { get; set; }

        public PCLAssessmentViewModel()
        {
            pCLDetailDataEntry = new List<PCLDetailDataEntry>();
            pCLScale = new List<PCLScale>();
        }
    }//end of PCLAssessmentViewModel


}//end of namespace
