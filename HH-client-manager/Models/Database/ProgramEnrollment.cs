using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class ProgramEnrollment
{
        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        [DisplayName("Program Name")]
        public string Name { get; set; }

        [DisplayName("Program Enrollment Date")]
        public DateTime Enrollment_date { get; set; }

        [DisplayName("Program Exit Date")]
        public DateTime? Exit_date { get; set; }

    }
}
