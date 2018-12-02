using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class BugSolutionEntryClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageBugSolutions(int SolutionId,
            int BugId,
            int MemberId,
            string SolutionDetails,
            String SolutionDate,
            String Remarks,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageSolutions",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SolutionId", SolutionId);
                cmd.Parameters.AddWithValue("@BugId", BugId);
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@SolutionDetails", SolutionDetails);
                cmd.Parameters.AddWithValue("@SolutionDate", SolutionDate);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int rs =cmd.ExecuteNonQuery();
                conn.Close();
                return rs;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }


        public DataTable GetSolutionsByMemberId(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from SolutionTable where MemberId=@MemberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MemberId", id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
