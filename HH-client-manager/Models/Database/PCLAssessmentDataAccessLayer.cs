using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HH_client_manager.Models.Database
{
    public class PCLAssessmentDataAccessLayer
{

        string connectionString = "Server = tcp:hopehealing.database.windows.net,1433;Database = HopeandHealingDashboardSystem; Persist Security Info=False;User ID = ArianneKJones; Password=NetAssets2018; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        public void CreatePCLAssessment (PCLAssessment PCLAssessment)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand assessmentCommand = new SqlCommand("INSERT INTO PCL_Assessment(Client_ID, PCL_Assessment_Date, Assessment_Type, Event_Description, Event_Date, Edited_By, Edit_Date) VALUES (@Client_ID, @PCL_Assessment_Date, @Assessment_Type, @Event_Description, @Event_Date, @Edited_By, @Edit_Date); SELECT @@IDENTITY AS 'Identity'", con);

                assessmentCommand.Parameters.AddWithValue("@Client_ID", PCLAssessment.ClientID);
                assessmentCommand.Parameters.AddWithValue("@PCL_Assessment_Date", PCLAssessment.Date);
                assessmentCommand.Parameters.AddWithValue("@Assessment_Type", PCLAssessment.Assessment_Type);
                assessmentCommand.Parameters.AddWithValue("@Event_Description", PCLAssessment.Event_description);
                assessmentCommand.Parameters.AddWithValue("@Event_Date", PCLAssessment.Event_date);
                assessmentCommand.Parameters.AddWithValue("@Edited_By", PCLAssessment.Edited_by);
                assessmentCommand.Parameters.AddWithValue("@Edit_Date", PCLAssessment.Edit_date);

                con.Open();

                var AssessmentID = assessmentCommand.ExecuteScalar();

                con.Close();

                //SqlCommand detailCommand = new SqlCommand ("INSERT INTO PCL_Detail_Record (Scale_Number, PCL_Bothered_By_Order, PCL_Seqence_Number")


            }//end using

        }//end CreateAssessment




}//end of PCLAssessmentDataAccessLayer

}//end of namespace
