using System;
using System.Collections.Generic;

namespace HHclientmanager.Models
{
    public partial class Cfar
    {
        public int CfarId { get; set; }
        public int ClientId { get; set; }
        public int Anxiety { get; set; }
        public int TraumaticStress { get; set; }
        public int Depression { get; set; }
        public int EmotionalityIndex { get; set; }

        public virtual Client Client { get; set; }
    }
}
