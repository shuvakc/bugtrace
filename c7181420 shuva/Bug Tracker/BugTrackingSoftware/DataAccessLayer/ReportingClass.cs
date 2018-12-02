    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class ReportingClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public DataTable GetMemberByProject(String ProjectName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,MemberName from ProjectTable p,MemberTable m,ProjectMemberTable pmt where pmt.ProjectId=p.ProjectId and pmt.MemberId=m.MemberId and ProjectName=@ProjectName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
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
        public DataTable GetBugsByProjectAndMember(String MemberName, String ProjectName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select BugId,BugDetails,EntryDate,ClassName,MethodName,BlockName,LineNumber from BugTable,ProjectTable,MemberTable where ProjectTable.ProjectId=BugTable.ProjectId and MemberTable.MemberId=BugTable.MemberId and MemberName=@MemberName and ProjectName=@ProjectName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
                cmd.Parameters.AddWithValue("@MemberName", MemberName);
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
        public DataTable ProjectReportByMember(int MemberId)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,ProjectDescription,StartDate,EndDate,MemberName,UserName,MemberRole,Responsibilities from ProjectMemberTable,MemberTable,ProjectTable where ProjectMemberTable.MemberId=MemberTable.MemberId and ProjectTable.ProjectId=ProjectMemberTable.ProjectId and MemberTable.MemberId=@MemberId", conn);
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
        public DataTable AllProjectReport()
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,ProjectDescription,StartDate,EndDate,MemberName,UserName,MemberRole,Responsibilities from ProjectMemberTable,MemberTable,ProjectTable where ProjectMemberTable.MemberId=MemberTable.MemberId and ProjectTable.ProjectId=ProjectMemberTable.ProjectId ", conn);
                cmd.CommandType = CommandType.Text;
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
        public DataTable AllProjectsByDates(String StartDate, String EndDate)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from ProjectTable where StartDate>=@StartDate and  EndDate<=@EndDate", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
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
        public DataTable GetBugByMember(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select m.MemberName,ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber from BugTable b,MemberTable m,ProjectTable p where m.MemberId=b.MemberId and b.ProjectId=p.ProjectId  and m.MemberId=@MemberId", conn);
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
        public DataTable GetBugByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select m.MemberName,ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber from BugTable b,MemberTable m,ProjectTable p where m.MemberId=b.MemberId and b.ProjectId=p.ProjectId  and p.ProjectId=@ProjectId", conn);
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
        public DataTable GetSolutionsByProject(int ProjectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select p.ProjectName,b.BugId,b.BugDetails,b.ClassName,b.MethodName,b.BlockName,b.LineNumber,s.SolutionDate,s.SolutionDetails from SolutionTable s,BugTable b,ProjectTable p where b.BugId=s.BugId and p.ProjectId=b.ProjectId and p.ProjectId=@ProjectId", conn);
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
        }
        public DataTable GetSolutionsByMember(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select p.ProjectName,b.BugId,b.BugDetails,b.ClassName,b.MethodName,b.BlockName,b.LineNumber,s.SolutionDate,s.SolutionDetails from SolutionTable s,BugTable b,ProjectTable p,MemberTable m where b.BugId=s.BugId and p.ProjectId=b.ProjectId and  b.MemberId=m.MemberId and m.MemberId=@MemberId", conn);
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
        }
        public DataTable GetProjectByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectName,MemberRole,ProjectDescription,Responsibilities from ProjectMemberTable pmt,MemberTable m,ProjectTable p where pmt.MemberId=m.MemberId and p.ProjectId=pmt.ProjectId and m.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
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
        }
        public int GetTotalProjectByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select count(*) from ProjectMemberTable pmt,MemberTable m where m.MemberId=pmt.MemberId and m.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalProject = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalProject;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetBugByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select ProjectTable.ProjectName,BugId,BugDetails,ClassName,MethodName,BlockName,LineNumber,EntryDate from BugTable,MemberTable,ProjectTable  where BugTable.MemberId=MemberTable.MemberId and ProjectTable.ProjectId=BugTable.ProjectId and MemberTable.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
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
        }
        public int TotalBugsByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select count(*) from BugTable b,MemberTable m where b.MemberId=m.MemberId and m.UserName=@UserName ", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
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
        }
        public DataTable GetSolutionsByUserName(string UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select SolutionId,SolutionTable.BugId,BugTable.BugDetails,SolutionDetails,SolutionDate from SolutionTable,BugTable,MemberTable where BugTable.BugId=SolutionTable.BugId and BugTable.MemberId=MemberTable.MemberId and MemberTable.UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
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
        }
        public int GetTotalSolutions(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from SolutionTable,MemberTable,BugTable where SolutionTable.BugId=BugTable.BugId and BugTable.MemberId=MemberTable.MemberId and UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalSolutions = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalSolutions;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
