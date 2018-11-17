using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class PPSRStatements
{
        [DisplayName("Order Number")]
        public int Order_number { get; set; }

        [DisplayName("PPSR Statements")]
        public string Statements { get; set; }

        [DisplayName("Letter Identifier")]
        public string Letter_identifier { get; set; }
    }
}
