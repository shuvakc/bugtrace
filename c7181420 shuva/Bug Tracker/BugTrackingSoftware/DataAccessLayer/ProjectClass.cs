using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public class ProjectClass
    {
       SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
       public int ManageProjects(int ProjectId,
           String ProjectName,
           String ProjectDescription,
           String StartDate,
           String EndDate,
           int Mode)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("SP_ManageProjects",conn);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
               cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
               cmd.Parameters.AddWithValue("@ProjectDescription", ProjectDescription);
               cmd.Parameters.AddWithValue("@StartDate", StartDate);
               cmd.Parameters.AddWithValue("@EndDate", EndDate);
               cmd.Parameters.AddWithValue("@Mode", Mode);
               conn.Open();
               int rs = cmd.ExecuteNonQuery();
               conn.Close();
               return rs;
           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally { conn.Close(); }
       }
       public DataTable GetAllProjects()
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select * from ProjectTable", conn);
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
       public int ProjectsCount()
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select count(*) from ProjectTable", conn);
               conn.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               dt.Load(dr);
               conn.Close();
               int projectCount = Convert.ToInt32(dt.Rows[0][0].ToString());
               return projectCount;
           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally { conn.Close(); }
       }

        public bool DeleteProjectByID(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Delete from ProjectTable where ProjectId=@id", conn);
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
