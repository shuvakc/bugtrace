using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class ProjectMemberClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageProjectMembers(int Id,
            int ProjectId,
            int MemberId,
            String MemberRole,
            String Responsibilities,
            int Mode)
        {
            try
            {
                int rs = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageProjectMemberTable", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@MemberRole", MemberRole);
                cmd.Parameters.AddWithValue("@Responsibilities", Responsibilities);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                rs = cmd.ExecuteNonQuery();
                conn.Close();
                return rs;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetAllProjectMembers()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from ProjectMemberTable",conn);
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
        public DataTable GetProjectByMemberId(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select p.ProjectName,p.ProjectId from ProjectMemberTable pm,ProjectTable p where MemberId=@MemberId and p.ProjectId=pm.ProjectId", conn);
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
        public DataTable GetProjectByBugId(int BugId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select p.ProjectName,p.ProjectId from BugTable bt,ProjectTable p where BugId=@BugId and p.ProjectId=bt.ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@BugId", BugId);
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
        public DataTable GetProjectMemberByProjectId(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from ProjectMemberTable where ProjectId=@ProjectId", conn);
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
    
        public int  totalProjectMember()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from ProjectMemberTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int x = Convert.ToInt32(dt.Rows[0][0].ToString());
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public bool DeleteProjectMemberById(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Delete from ProjectMemberTable where Id=@ProjectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectId", id);
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
