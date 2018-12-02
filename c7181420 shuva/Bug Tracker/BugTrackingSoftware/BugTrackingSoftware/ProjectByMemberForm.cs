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
    public partial class ProjectByMemberForm : Form
    {
        public ProjectByMemberForm()
        {
            InitializeComponent();
        }
        public String UserName;
        ReportingClass rc = new ReportingClass();
        private void ProjectByMemberForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.GetProjectByUserName(UserName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
