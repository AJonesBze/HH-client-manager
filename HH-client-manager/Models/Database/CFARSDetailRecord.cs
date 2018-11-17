using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class CFARSDetailRecord
{
        [DisplayName("CFARS Detail Record Number")]
        public int Number { get; set; }

        [DisplayName("CFARS Scale Number")]
        public int Scale_number { get; set; }

        [DisplayName("CFARS Assessment Number")]
        public int Assessment_number { get; set; }

        [DisplayName("Keyword")]
        public string Keyword { get; set; }





    }
}
