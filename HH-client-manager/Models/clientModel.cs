using System;

namespace HH_client_manager.Models 
{
    public class Client {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
        public int Age { get; set; }
        public string PartnerGender { get; set; }
        public string RelationshipStatus { get; set; }
        public DateTime DateEnrolled { get; set; }
	    public string CounselorName{ get; set; }
        public int GroupsAttended { get; set; }
        public int CouncelingSessionsAttended { get; set; }
        public int MeetingsWithAdvocates { get; set; }
        public DateTime ExitDate { get; set; }
        public int HasHarkAssessmentPRE { get; set; }
        public int HasHarkAssessmentPOST { get; set; }
        public int HasPCLAssessmentPRE { get; set; }
        public int HasPCLAssessmentPOST { get; set; }
        public int HasShelterAssessmentPRE { get; set; }
        public int HasShelterAssessmentPOST { get; set; }
    }
}
