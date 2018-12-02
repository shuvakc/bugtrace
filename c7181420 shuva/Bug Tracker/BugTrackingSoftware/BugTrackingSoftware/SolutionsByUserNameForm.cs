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
    public partial class SolutionsByUserNameForm : Form
    {
        public SolutionsByUserNameForm()
        {
            InitializeComponent();
        }
        ReportingClass rc = new ReportingClass();
        public String UserName;
        private void SolutionsByUserNameForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvReport.DataSource = rc.GetSolutionsByUserName(UserName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
