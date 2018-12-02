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
    public partial class ProjectMemberForm : Form
    {
        public ProjectMemberForm()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        ProjectMemberClass pmc = new ProjectMemberClass();
        ProjectClass pc = new ProjectClass();
        MemberClass mc = new MemberClass();
        int selectedId;
        private void ProjectMemberForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMember.DataSource = mc.GetAllMembers();
                cmbMember.DisplayMember = "UserName";
                cmbMember.ValueMember = "MemberId";
                cmbMember.SelectedIndex = -1;
                cmbProject.DataSource = pc.GetAllProjects();
                cmbProject.DisplayMember = "ProjectName";
                cmbProject.ValueMember = "ProjectId";
                cmbProject.SelectedIndex = -1;
                dgvProjectMemberDetails.DataSource = pmc.GetAllProjectMembers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProjectMember_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageProjectMembers(0,
                    Convert.ToInt32(cmbProject.SelectedValue.ToString()),
                    Convert.ToInt32(cmbMember.SelectedValue.ToString()),
                    txtMemberRole.Text,
                    txtMemberResponsibilities.Text,
                    1);
                if (result == true)
                {
                    MessageBox.Show("Member for the project successfully added");
                    dgvProjectMemberDetails.DataSource = pmc.GetAllProjectMembers();
                }
                else
                {
                    MessageBox.Show("Error in adding member to the project");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProjectMember_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageProjectMembers(selectedId,
                    Convert.ToInt32(cmbProject.SelectedValue.ToString()),
                    Convert.ToInt32(cmbMember.SelectedValue.ToString()),
                    txtMemberRole.Text,
                    txtMemberResponsibilities.Text,
                    2);
                if (result == true)
                {
                    MessageBox.Show("Member for the project successfully updated");
                    dgvProjectMemberDetails.DataSource = pmc.GetAllProjectMembers();
                }
                else
                {
                    MessageBox.Show("Error in updating member to the project");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProjectMemberDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProjectMemberDetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProjectMemberDetails.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProjectMemberDetails.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Id"].Value);

                cmbProject.SelectedValue = Convert.ToString(selectedRow.Cells["ProjectId"].Value);
                cmbMember.SelectedValue = Convert.ToString(selectedRow.Cells["MemberId"].Value);
                txtMemberRole.Text = Convert.ToString(selectedRow.Cells["MemberRole"].Value);
                txtMemberResponsibilities.Text = Convert.ToString(selectedRow.Cells["Responsibilities"].Value);
                selectedId = Convert.ToInt32(a);
            }
        }

        private void btbDeketeProjectMember_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = pmc.DeleteProjectMemberById(selectedId);
                if (result == true)
                {
                    MessageBox.Show("Member Deleted from the database");
                    dgvProjectMemberDetails.DataSource = pmc.GetAllProjectMembers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
