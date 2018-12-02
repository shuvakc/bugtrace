using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
namespace BugTrackingSoftware
{
    public partial class GetSolutionsByProjectForm : Form
    {
        public GetSolutionsByProjectForm()
        {
            InitializeComponent();
        }
        ProjectClass pc = new ProjectClass();
        ReportingClass rc = new ReportingClass();
        private void GetSolutionsByProjectForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProjectName.DataSource = pc.GetAllProjects();
                cmbProjectName.DisplayMember = "ProjectName";
                cmbProjectName.ValueMember = "ProjectId";
                cmbProjectName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.GetSolutionsByProject(Convert.ToInt32(cmbProjectName.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
