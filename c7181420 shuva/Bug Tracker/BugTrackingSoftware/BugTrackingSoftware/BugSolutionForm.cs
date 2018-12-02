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
    public partial class BugSolutionForm : Form
    {
        public BugSolutionForm()
        {
            InitializeComponent();
        }
        public int ProjectId;
        public int MemberId;
        int selectedId;
        int bugId;
        ProjectMemberClass pmc = new ProjectMemberClass();
        BugEntryClass bec = new BugEntryClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        BugSolutionEntryClass bsec = new BugSolutionEntryClass();
        MemberClass mc = new MemberClass();
        private void BugSolutionForm_Load(object sender, EventArgs e)
        {
            txtSolutionDetails.Language = FastColoredTextBoxNS.Language.CSharp;
            try
            {
                dgvSolutionDetails.DataSource = bsec.GetSolutionsByMemberId(MemberId);
                cmbProject.DataSource = pmc.GetProjectByMemberId(MemberId);
                cmbProject.DisplayMember = "ProjectName";
                cmbProject.ValueMember = "ProjectId";
                cmbProject.SelectedIndex = -1;
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
              
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt=bec.GetBugsByProject(Convert.ToInt32(cmbProject.SelectedValue.ToString()));
                foreach(DataRow row in dt.Rows)
                {

                    ListViewItem lst = new ListViewItem(row["BugId"].ToString());
                    lst.SubItems.Add(row["BugDetails"].ToString());
                    lstBugDetails.Items.Add(lst);
                }
                cmbBugDetails.DataSource = bec.GetBugsByProject(Convert.ToInt32(cmbProject.SelectedValue.ToString()));
                cmbBugDetails.DisplayMember = "BugDetails";
                cmbBugDetails.ValueMember = "BugId";
                cmbBugDetails.SelectedIndex = -1;
            }
            catch (Exception)
            {
                
            
            }
        }

        private void btnAddSolutionDetails_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageBugSolutions(0,
                    Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()),
                    MemberId,
                    txtSolutionDetails.Text,
                    dtpSolutionDate.Text,
                    txtRemarks.Text,
                    1);
                if (result == true)
                {
                    dgvSolutionDetails.DataSource = bsec.GetSolutionsByMemberId(MemberId);
                    MessageBox.Show("The solution for the bug has been recorded");
                }
                else
                {
                    MessageBox.Show("Error in saving the bug information");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Here");
            }
        }

        private void dgvSolutionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgvSolutionDetails.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgvSolutionDetails.Rows[selectedrowindex];

            string a = Convert.ToString(selectedRow.Cells["SolutionId"].Value);
            string b = Convert.ToString(selectedRow.Cells["BugId"].Value);

            selectedId = Convert.ToInt32(a);
            bugId = Convert.ToInt32(b);
            cmbProject.DataSource = pmc.GetProjectByBugId(bugId);
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "ProjectId";
            lstBugDetails.Clear();
            cmbProject.SelectedIndex = 0;
            cmbBugDetails.SelectedValue = Convert.ToString(selectedRow.Cells["BugId"].Value);
            txtSolutionDetails.Text = Convert.ToString(selectedRow.Cells["SolutionDetails"].Value);
            txtRemarks.Text = Convert.ToString(selectedRow.Cells["Remarks"].Value);
            dtpSolutionDate.Text = Convert.ToString(selectedRow.Cells["SolutionDate"].Value); 
        }

        private void btnUpdateSolutionDetails_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageBugSolutions(selectedId,
                    bugId,
                    MemberId,
                    txtSolutionDetails.Text,
                    dtpSolutionDate.Text,
                    txtRemarks.Text,
                    2);
                if (result == true)
                {
                    MessageBox.Show("Solution SUCCESSFULLY UPDATED TO DATABASE");
                    dgvSolutionDetails.DataSource = bsec.GetSolutionsByMemberId(MemberId);
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING Solution TO DATABASE");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteBugDetails_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageBugSolutions(0,
                    Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()),
                    MemberId,
                    txtSolutionDetails.Text,
                    dtpSolutionDate.Text,
                    txtRemarks.Text,
                    1);
                if (result == true)
                {
                    dgvSolutionDetails.DataSource = bsec.GetSolutionsByMemberId(MemberId);
                    MessageBox.Show("The solution for the bug has been recorded");
                }
                else
                {
                    MessageBox.Show("Error in saving the bug information");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Here");
            }
        }
    }
}
