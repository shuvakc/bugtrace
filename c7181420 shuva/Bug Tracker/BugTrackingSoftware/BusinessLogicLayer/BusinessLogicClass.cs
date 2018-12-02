using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        MemberClass mc = new MemberClass();
        ProjectClass pc = new ProjectClass();
        ProjectMemberClass pmc = new ProjectMemberClass();
        BugEntryClass bec = new BugEntryClass();
        BugSolutionEntryClass bsec = new BugSolutionEntryClass();
        public bool ManageMembers(int MemberId,
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
                bool result = false;
                int rs = mc.ManageMembers(MemberId,
                    MemberName,
                    Address,
                    Contact,
                    Email,
                    Gender,
                    DateofBirth,
                    DateofJoin,
                    Designation,
                    Role,
                    UserName,
                    Password,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageProjects(int ProjectId,
          String ProjectName,
          String ProjectDescription,
          String StartDate,
          String EndDate,
          int Mode)
        {
            try
            {
                bool result = false;
                int rs = pc.ManageProjects(ProjectId, ProjectName, ProjectDescription, StartDate, EndDate, Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public bool ManageProjectMembers(int Id,
           int ProjectId,
           int MemberId,
           String MemberRole,
           String Responsibilities,
           int Mode)
        {
            try
            {
                int rs = pmc.ManageProjectMembers(Id, ProjectId, MemberId, MemberRole, Responsibilities, Mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageBugsEntry(int BugId,
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
                int rs = bec.ManageBugsEntry(BugId, EntryDate, ProjectId, MemberId,ClassName,MethodName,BlockName,LineNumber, BugDetails, Remarks, Mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageBugSolutions(int SolutionId,
            int BugId,
            int MemberId,
            string SolutionDetails,
            String SolutionDate,
            String Remarks,
            int Mode)
        {
            try
            {
                int rs = bsec.ManageBugSolutions(SolutionId, BugId, MemberId, SolutionDetails, SolutionDate, Remarks, Mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
