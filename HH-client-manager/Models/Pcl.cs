using System;
using System.Collections.Generic;

namespace HHclientmanager.Models
{
    public partial class Pcl
    {
        public int PclId { get; set; }
        public int ClientId { get; set; }
        public int SeverityScore { get; set; }

        public virtual Client Client { get; set; }
    }
}
