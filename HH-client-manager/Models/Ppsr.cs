using System;
using System.Collections.Generic;

namespace HHclientmanager.Models
{
    public partial class Ppsr
    {
        public int PpsrId { get; set; }
        public int ClientId { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int G { get; set; }

        public virtual Client Client { get; set; }
    }
}
