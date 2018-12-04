using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HH_client_manager.Models.Database;

namespace HH_client_manager
{
    public class PCLAssessmentDataAccessLayer
{

        string connectionString = "Server = tcp:hopehealing.database.windows.net,1433;Database = HopeandHealingDashboardSystem; Persist Security Info=False;User ID = ArianneKJones; Password=NetAssets2018; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
       

        public int CreatePCLAssessment (PCLAssessment PCLAssessment)
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

                var sequenceNumber = assessmentCommand.ExecuteScalar();

                con.Close();

                //SqlCommand detailCommand = new SqlCommand ("INSERT INTO PCL_Detail_Record (Scale_Number, PCL_Bothered_By_Order, PCL_Seqence_Number")
                return int.Parse(sequenceNumber.ToString());

            }//end using

        }//end CreateAssessment

        public List<PCLScale> GetPCLScale()
        {
            List<PCLScale> lstPCLScale = new List<PCLScale>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PCL_Scale;", con);
                
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    PCLScale scale = new PCLScale();
                    scale.Number = (short)rdr["PCL_Scale_Number"];
                    scale.Description = (string)rdr["PCL_Scale_Description"];
                    lstPCLScale.Add(scale);
                }
                con.Close();
            }
            return lstPCLScale;
        }//end of GetPCLScale

        public List<PCLDetailDataEntry> GetPCLDetailDataEntry()
        {
            List<PCLDetailDataEntry> lstPCLDetailDataEntry = new List<PCLDetailDataEntry>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PCL_Bothered_By;", con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PCLDetailDataEntry statement = new PCLDetailDataEntry();
                    statement.Bothered_by_order =(int)rdr["PCL_Bothered_By_Order"];
                    statement.Bothered_by_Description = (string)rdr["Bothered_By"];
                    lstPCLDetailDataEntry.Add(statement);
                  
                }
                con.Close();
            }
            return lstPCLDetailDataEntry;

        }//end GetPCLStatement

        public IEnumerable<PCLDetailRecord> GetPCLDetailRecords()
        {
            List<PCLDetailRecord> lstPCLDetailRecord = new List<PCLDetailRecord>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM PCL_Detail_Record;",con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PCLDetailRecord statement = new PCLDetailRecord();
                    statement.Scale_number = (int)rdr["Scale_Number"];
                    statement.Bothered_by_order = (int)rdr["PCL_Bothered_By_Order"];
                    statement.Sequence_number = (int)rdr["PCL_Sequence_Number"];



                }
                con.Close();
            }


            return lstPCLDetailRecord;
        }//end of GetPCLAssessmentData

        public void WritePCLDetailRecord(int SequenceNumber, PCLDetailDataEntry pCLDetailDataEntry )
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PCL_Detail_Record (Scale_Number, PCL_Bothered_By_Order, PCL_Sequence_Number) VALUES (@Scale_Number, @PCL_Bothered_By_Order, @PCL_Sequence_Number);", con);

                cmd.Parameters.AddWithValue("@Scale_Number", pCLDetailDataEntry.Scale_number);
                cmd.Parameters.AddWithValue("@PCL_Bothered_By_Order", pCLDetailDataEntry.Bothered_by_order);
                cmd.Parameters.AddWithValue("@PCL_Sequence_Number", SequenceNumber);

             

                con.Open();

                cmd.ExecuteScalar();

                con.Close();

              


            }//end of using 

            return;

        }//end WritePCLDetailRecord

    }//end of PCLAssessmentDataAccessLayer

}//end of namespace
