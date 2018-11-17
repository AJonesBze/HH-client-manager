using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class ShelterStay

    {
        [DisplayName("Shelter Location")]
        public string location { get; set; }

        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        [DisplayName("Shelter Enrollment Date")]
        public DateTime enrollment_date { get; set; }

        [DisplayName("Shelter Exit Date")]
        public DateTime? exit_date { get; set; }





    }
}
