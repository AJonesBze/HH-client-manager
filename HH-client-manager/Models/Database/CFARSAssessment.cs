using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class CFARSAssessment
{
        [DisplayName("CFARS Serial Number")]
        public int Serial_number { get; set; }

        [DisplayName("Assessment Date")]
        public DateTime Date { get; set; }

        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        [DisplayName("Pre-Assessment Date")]
        public DateTime Preassessment_date { get; set; }

        [DisplayName("Assessment Type")]
        public string Type { get; set; }

        [DisplayName("Program Name")]
        public string Program_name { get; set; }

        [DisplayName("Conducted By")]
        public string Conducted_by { get; set; }

        [DisplayName("Number of Group Sessions")]
        public int Number_of_group_sessions { get; set; }

        [DisplayName("Number of Advocacy Meetings")]
        public int Number_of_advocacy_meetings { get; set; }

        [DisplayName("Number of Counseling Meetings")]
        public int Number_of_counseling_sessions { get; set; }

        [DisplayName("Edited By")]
        public string Edited_by { get; set; }

        [DisplayName("Edit Date")]
        public DateTime? Edit_date { get; set; }





    }
}
