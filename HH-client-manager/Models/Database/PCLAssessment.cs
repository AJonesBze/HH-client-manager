using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class PCLAssessment
{
        [DisplayName("PCL Sequence Number")]
        public int Sequence_number { get; set; }

        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        [DisplayName("Assessment Date")]
        public DateTime Date { get; set; }

        [DisplayName("Assessment Type")]
        public string Type { get; set; }

        [DisplayName("Event Description")]
        public string Event_description { get; set; }

        [DisplayName("Event Date")]
        public DateTime? Event_date { get; set; }

        [DisplayName("Edited By")]
        public string Edited_by { get; set; }

        [DisplayName("Edit Date")]
        public DateTime Edit_date { get; set; }





    }
}
