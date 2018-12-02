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
    public partial class ProjectMembersDetails : Form
    {
        public ProjectMembersDetails()
        {
            InitializeComponent();
        }
        ProjectMemberClass pmc = new ProjectMemberClass();
        private void ProjectMembersDetails_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProjectMembersDetails.DataSource = pmc.GetAllProjectMembers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
