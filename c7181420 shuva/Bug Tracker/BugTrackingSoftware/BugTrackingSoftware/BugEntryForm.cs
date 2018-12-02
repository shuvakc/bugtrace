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
    public partial class BugEntryForm : Form
    {
        public BugEntryForm()
        {
            InitializeComponent();
        }
        public int MemberId;
        public int selectedId;
        public String UserName;
        BusinessLogicClass blc = new BusinessLogicClass();
        ProjectMemberClass pmc = new ProjectMemberClass();
        BugEntryClass bec = new BugEntryClass();
        MemberClass mc = new MemberClass();
        private void BugEntryForm_Load(object sender, EventArgs e)
        {
            String Role = mc.GetRoleById(MemberId);
            if (Role == "Tester")
            {
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                txtBlockName.Hide();
                txtClassName.Hide();
                txtLineNumber.Hide();
                txtMethodName.Hide();
            }
            else {
                label9.Hide();
            }
            try
            {
                dgvBugEntryDetails.DataSource = bec.GetBugsByMemberId(MemberId);
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

        private void btnAddBugDetails_Click(object sender, EventArgs e)
        {
            try
            {
                String check = dtpBugEntryDate.ToString();
                int checkint = Convert.ToInt32(cmbProject.SelectedValue.ToString());
                int chechint1 = Convert.ToInt32(txtLineNumber.Text);
                bool result = blc.ManageBugsEntry(0,
                    dtpBugEntryDate.Value.ToString(),
                    Convert.ToInt32(cmbProject.SelectedValue.ToString()),
                    MemberId,
                    txtClassName.Text,
                    txtMethodName.Text,
                    txtBlockName.Text,
                    txtLineNumber.Text != null ? Convert.ToInt32(txtLineNumber.Text) : 0,
                    txtBugDetails.Text,
                    txtRemarks.Text,
                    1);
                if (result == true)
                {
                    MessageBox.Show("BUG SUCCESSFULLY ADDED TO DATABASE");
                    dgvBugEntryDetails.DataSource = bec.GetBugsByMemberId(MemberId);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING BUGS TO DATABASE");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBugEntryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBugEntryDetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvBugEntryDetails.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvBugEntryDetails.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["BugId"].Value);

                selectedId = Convert.ToInt32(a);

                dtpBugEntryDate.Text = Convert.ToString(selectedRow.Cells["EntryDate"].Value);
                cmbProject.SelectedValue = Convert.ToString(selectedRow.Cells["ProjectId"].Value);
                txtClassName.Text = Convert.ToString(selectedRow.Cells["ClassName"].Value);
                txtBlockName.Text = Convert.ToString(selectedRow.Cells["BlockName"].Value);
                txtMethodName.Text = Convert.ToString(selectedRow.Cells["MethodName"].Value);
                txtLineNumber.Text = Convert.ToString(selectedRow.Cells["LineNumber"].Value);
                txtBugDetails.Text = Convert.ToString(selectedRow.Cells["BugDetails"].Value);
                txtRemarks.Text = Convert.ToString(selectedRow.Cells["Remarks"].Value);
               
            }
        }

        private void btnUpdateBugDetails_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageBugsEntry(selectedId,
                    dtpBugEntryDate.ToString(),
                    Convert.ToInt32(cmbProject.SelectedValue.ToString()),
                    MemberId,
                    txtClassName.Text,
                    txtMethodName.Text,
                    txtBlockName.Text,
                    Convert.ToInt32(txtLineNumber.Text),
                    txtBugDetails.Text,
                    txtRemarks.Text,
                    2);
                if (result == true)
                {
                    MessageBox.Show("BUG SUCCESSFULLY UPDATED TO DATABASE");
                    dgvBugEntryDetails.DataSource = bec.GetBugsByMemberId(MemberId);
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING BUGS TO DATABASE");
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
                bool result = bec.DeleteBugsById(selectedId);
                if (result == true)
                {
                    MessageBox.Show("Bug Deleted from the database");
                    dgvBugEntryDetails.DataSource = bec.GetBugsByMemberId(MemberId);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
