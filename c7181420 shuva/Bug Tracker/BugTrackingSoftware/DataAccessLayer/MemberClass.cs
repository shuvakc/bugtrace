using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class MemberClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageMembers(int MemberId,
            String MemberName,
            String Address,
            String Contact,
            String Email,
            String Gender,
            String DateofBirth,
            String DateofJoin,
            String Designation,
            String Role,
            String UserName,
            String Password,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageMembers",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MemberId",MemberId);
                cmd.Parameters.AddWithValue("@MemberName", MemberName);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@DateofBirth", DateofBirth);
                cmd.Parameters.AddWithValue("@DateofJoin", DateofJoin);
                cmd.Parameters.AddWithValue("@Designation", Designation);
                cmd.Parameters.AddWithValue("@Role", Role);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetAllMembers()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from MemberTable",conn);
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
        public String GetRole(String UserName, String Password)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select Role from MemberTable where UserName=@UserName and Password=@Password", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                String Role = dt.Rows[0]["Role"].ToString();
                return Role;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public String GetRoleById(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select Role from MemberTable where MemberId=@MemberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                String Role = dt.Rows[0]["Role"].ToString();
                return Role;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public int TotalMember()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from MemberTable",conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int TotalMember = Convert.ToInt32(dt.Rows[0][0].ToString());
                return TotalMember;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public int GetMemberIdByUserName(String UserName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select MemberId from MemberTable where UserName=@UserName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName",UserName);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int MemberId = Convert.ToInt32(dt.Rows[0][0].ToString());
                return MemberId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public bool DeleteMemberByID(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Delete from MemberTable where MemberId=@id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id",id);
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
