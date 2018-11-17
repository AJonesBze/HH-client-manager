using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class Client
    {
        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime date_of_birth { get; set; }

        [DisplayName("Relationship Status")]
        public string relationship_status { get; set; }

        [DisplayName("Advocate Name")]
        public string advocate_name { get; set; }

        [DisplayName("Notes on Client")]
        public string notes { get; set; }

        [DisplayName("Gender")]
        public string gender { get; set; }

        [DisplayName("Ethnicity")]
        public string ethnicity { get; set; }

        [DisplayName("Race")]
        public string race { get; set; }

        [DisplayName("Partner Gender")]
        public string partner_gender { get; set; }

    }

}
