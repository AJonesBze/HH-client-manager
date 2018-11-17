using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class PPSRSubscales
{
        [DisplayName("Letter Identifier")]
        public string Letter_identifier { get; set; }

        [DisplayName("Subscale Description")]
        public string Description { get; set; }
    }
}
