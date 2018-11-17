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
        public DateTime Date_of_birth { get; set; }

        [DisplayName("Relationship Status")]
        public string Relationship_status { get; set; }

        [DisplayName("Advocate Name")]
        public string Advocate_name { get; set; }

        [DisplayName("Notes on Client")]
        public string Notes { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Ethnicity")]
        public string Ethnicity { get; set; }

        [DisplayName("Race")]
        public string Race { get; set; }

        [DisplayName("Partner Gender")]
        public string Partner_gender { get; set; }

    }

}
