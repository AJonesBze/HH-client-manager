﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class PCLBotheredBy
{
        [DisplayName("PCL Bothered By Order")]
        public int Order { get; set; }
        public String Description { get; set; }
    }
}
