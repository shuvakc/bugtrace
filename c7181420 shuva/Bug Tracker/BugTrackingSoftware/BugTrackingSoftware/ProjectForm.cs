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
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        ProjectClass pc = new ProjectClass();
        int selectedId = 0;
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.ManageProjects(0, txtProjectName.Text, txtProjectDescription.Text, dtpProjectStartDate.Text, dtpProjectEndDate.Text, 1);
                if (res == true)
                {
                    MessageBox.Show("NEW PROJECT SUCCESSFULLY ADDED TO THE DATABASE");
                    dgvProjectDetails.DataSource = pc.GetAllProjects();
                    
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING PROJECT TO DATABASE");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            dgvProjectDetails.DataSource = pc.GetAllProjects();
        }

        private void dgvProjectDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProjectDetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProjectDetails.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProjectDetails.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["ProjectId"].Value);

                txtProjectName.Text = Convert.ToString(selectedRow.Cells["ProjectName"].Value);
                txtProjectDescription.Text = Convert.ToString(selectedRow.Cells["ProjectDescription"].Value);
                dtpProjectStartDate.Text = Convert.ToString(selectedRow.Cells["StartDate"].Value);
                dtpProjectEndDate.Text = Convert.ToString(selectedRow.Cells["EndDate"].Value);
                selectedId = Convert.ToInt32(a);
            }
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = blc.ManageProjects(selectedId, txtProjectName.Text, txtProjectDescription.Text, dtpProjectStartDate.Text, dtpProjectEndDate.Text, 2);
                if (res == true)
                {
                    MessageBox.Show("PROJECT SUCCESSFULLY UPDATED TO THE DATABASE");
                    dgvProjectDetails.DataSource = pc.GetAllProjects();

                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING PROJECT TO DATABASE");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = pc.DeleteProjectByID(selectedId);
                if (result == true)
                {
                    MessageBox.Show("Member Deleted from the database");
                    dgvProjectDetails.DataSource = pc.GetAllProjects();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
