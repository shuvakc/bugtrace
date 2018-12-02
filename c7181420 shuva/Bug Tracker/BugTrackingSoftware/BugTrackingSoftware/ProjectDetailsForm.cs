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
    public partial class ProjectDetailsForm : Form
    {
        public ProjectDetailsForm()
        {
            InitializeComponent();
        }
        ProjectClass pc = new ProjectClass();
        private void ProjectDetailsForm_Load(object sender, EventArgs e)
        {
            dgvProjectDetails.DataSource = pc.GetAllProjects();
        }
    }
}
