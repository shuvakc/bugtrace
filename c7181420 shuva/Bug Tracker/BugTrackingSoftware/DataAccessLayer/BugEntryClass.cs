using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class BugEntryClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageBugsEntry(int BugId,
            String EntryDate,
            int ProjectId,
            int MemberId,
            String ClassName,
            String MethodName,
            String BlockName,
            int LineNumber,
            String BugDetails,
            String Remarks,
            int Mode)
        {
            try
            {
                int res = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageBugs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BugId", BugId);
                cmd.Parameters.AddWithValue("@EntryDate", EntryDate);
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@ClassName", ClassName);
                cmd.Parameters.AddWithValue("@MethodName", MethodName);
                cmd.Parameters.AddWithValue("@BlockName", BlockName);
                cmd.Parameters.AddWithValue("@LineNumber", LineNumber);
                cmd.Parameters.AddWithValue("@BugDetails", BugDetails);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetAllBugs()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from BugTable", conn);
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
            finally { conn.Close();  }
        }
        public int BugsCount()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from BugTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalBugs = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalBugs;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetBugsByMemberId(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from BugTable where MemberId=@MemberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
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
        public DataTable GetBugsByMemberAndProject(int MemberId, int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select BugId,BugDetails from BugTable where MemberId=@MemberId and ProjectId=@ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
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

        public DataTable GetBugsByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select BugId,BugDetails from BugTable where ProjectId=@ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
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

        public bool DeleteBugsById(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Delete from BugTable where BugId=@id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
