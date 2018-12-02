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
    public partial class AllMemberProjectReport : Form
    {
        public AllMemberProjectReport()
        {
            InitializeComponent();
        }
        ReportingClass rc = new ReportingClass();
        private void AllMemberProjectReport_Load(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.AllProjectReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
