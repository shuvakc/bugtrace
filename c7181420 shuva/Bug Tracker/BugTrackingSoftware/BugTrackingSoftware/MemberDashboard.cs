using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;
namespace BugTrackingSoftware
{
    public partial class MemberDashboard : Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString();

        }
        BusinessLogicClass blc = new BusinessLogicClass();
        BugEntryClass bec = new BugEntryClass();
        MemberClass mc = new MemberClass();
        ProjectClass pc = new ProjectClass();
        ProjectMemberClass pmc = new ProjectMemberClass();
        ReportingClass rc = new ReportingClass();
        private void btnBugsEntry_Click(object sender, EventArgs e)
        {
            BugByUserNameForm frm = new BugByUserNameForm();
            frm.UserName = lblUser.Text;
            frm.ShowDialog();
        }

        private void btnSolutionDetails_Click(object sender, EventArgs e)
        {
            SolutionsByUserNameForm frm = new SolutionsByUserNameForm();
            frm.UserName = lblUser.Text;
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void btnNewBugsEntry_Click(object sender, EventArgs e)
        {
            try
            {
                BugEntryForm frm = new BugEntryForm();
                frm.MemberId = mc.GetMemberIdByUserName(lblUser.Text);
                frm.UserName = lblUser.Text;
                frm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnBugSolution_Click(object sender, EventArgs e)
        {
            try
            {
                BugSolutionForm frm = new BugSolutionForm();
                frm.MemberId = mc.GetMemberIdByUserName(lblUser.Text);
                frm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mEMBERWISEPROJECTREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MemberWiseProjectReportForm frm = new MemberWiseProjectReportForm();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dATEWISEPROJECTREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatewiseProjectReportFrm frm = new DatewiseProjectReportFrm();
            frm.ShowDialog();
        }

        private void aLLMEMBERREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMemberReportForm frm = new AllMemberReportForm();
            frm.ShowDialog();
        }

        private void aLLPROJECTREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllMemberProjectReport frm = new AllMemberProjectReport();
            frm.ShowDialog();
        }

        private void btnMemberWiseBugReport_Click(object sender, EventArgs e)
        {
            BugByMemberForm frm = new BugByMemberForm();
            frm.ShowDialog();
        }

        private void btnProjectWiseBugReport_Click(object sender, EventArgs e)
        {
            GetBugsByProjectForm frm = new GetBugsByProjectForm();
            frm.ShowDialog();
        }

        private void btnAllBugReport_Click(object sender, EventArgs e)
        {
            BugDetailsForm frm = new BugDetailsForm();
            frm.ShowDialog();
        }

        private void btnMemberWiseSolutionReport_Click(object sender, EventArgs e)
        {
            GetSolutionsByMember frm = new GetSolutionsByMember();
            frm.ShowDialog();
        }

        private void btnProjectWiseSolutionReport_Click(object sender, EventArgs e)
        {
            GetSolutionsByProjectForm frm = new GetSolutionsByProjectForm();
            frm.ShowDialog();
        }

        private void btnProjectsDetails_Click(object sender, EventArgs e)
        {
            ProjectByMemberForm frm = new ProjectByMemberForm();
            frm.UserName = lblUser.Text;
            frm.ShowDialog();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            lblTotalProject.Text = rc.GetTotalProjectByUserName(lblUser.Text).ToString();
            lblTotalBugs.Text = rc.TotalBugsByUserName(lblUser.Text).ToString();
            lblTotalSolutions.Text = rc.GetTotalSolutions(lblUser.Text).ToString();
            lblTotalMembers.Text = pmc.totalProjectMember().ToString();
            BugReport();
        }

        private void btnMemberProjectDetails_Click(object sender, EventArgs e)
        {
            ProjectMembersDetails frm = new ProjectMembersDetails();
            frm.ShowDialog();
        }
        public void BugReport()
        {
            try
            {
                DataTable dt = pc.GetAllProjects();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String ProjectName = dt.Rows[i]["ProjectName"].ToString();
                    dgvDetails.Rows.Add(i + 1, ProjectName, "", "", "", "", "", "", "", "");
                    for (int j = 0; j < rc.GetMemberByProject(ProjectName).Rows.Count; j++)
                    {
                        String MemberName = rc.GetMemberByProject(ProjectName).Rows[j][1].ToString();
                        dgvDetails.Rows.Add("", "", MemberName, "", "", "", "", "", "", "");

                        for (int k = 0; k < rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows.Count; k++)
                        {
                            int BugId = Convert.ToInt32(rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][0].ToString());
                            String BugEntryDate = rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][1].ToString();
                            String BugDetails = rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][2].ToString();
                            String ClassName = rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][3].ToString();
                            String MethodName = rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][4].ToString();
                            String BlockName = rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][5].ToString();
                            int LineNumber = Convert.ToInt32(rc.GetBugsByProjectAndMember(MemberName, ProjectName).Rows[k][6].ToString());
                            dgvDetails.Rows.Add("", "", "", BugId, BugEntryDate, BugDetails, ClassName, MethodName, BlockName, LineNumber);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}

