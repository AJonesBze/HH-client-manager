﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class PPSRDetailRecord
{
        [DisplayName("PPSR Detail Record Number")]
        public int Number { get; set; }

        [DisplayName("PPSR Serial Number")]
        public int Serial_number { get; set; }

        [DisplayName("PPSR Statements")]
        public string Statements { get; set; }

        [DisplayName("Order Number")]
        public int Order_number { get; set; }

        [DisplayName("Letter Identifier")]
        public string Letter_identifier { get; set; }

        [DisplayName("Scale Number")]
        public int Scale_number { get; set; }


    }
}
