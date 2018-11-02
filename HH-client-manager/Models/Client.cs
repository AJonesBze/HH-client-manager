using System;
using System.Collections.Generic;

namespace HHclientmanager.Models
{
    public partial class Client
    {
        public Client()
        {
            Cfar = new HashSet<Cfar>();
            Pcl = new HashSet<Pcl>();
            Ppsr = new HashSet<Ppsr>();
        }

        public int ClientId { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public string Race { get; set; }
        public string PartnerGender { get; set; }
        public string RelationshipStatus { get; set; }
        public string AdvocateName { get; set; }
        public string Notes { get; set; }
        public DateTime? DateEnrolled { get; set; }
        public DateTime? ExitDate { get; set; }

        public virtual ICollection<Cfar> Cfar { get; set; }
        public virtual ICollection<Pcl> Pcl { get; set; }
        public virtual ICollection<Ppsr> Ppsr { get; set; }
    }
}
