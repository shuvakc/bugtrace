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
    public partial class DatewiseProjectReportFrm : Form
    {
        public DatewiseProjectReportFrm()
        {
            InitializeComponent();
        }
        ReportingClass rc = new ReportingClass();
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.AllProjectsByDates(dtpStartDate.Text, dtpEndDate.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
