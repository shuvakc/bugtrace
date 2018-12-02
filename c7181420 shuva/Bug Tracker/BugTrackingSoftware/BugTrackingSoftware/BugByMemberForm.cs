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
    public partial class BugByMemberForm : Form
    {
        public BugByMemberForm()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        ReportingClass rc = new ReportingClass();

        private void BugByMemberForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMemberName.DataSource = mc.GetAllMembers();
                cmbMemberName.DisplayMember = "MemberName";
                cmbMemberName.ValueMember = "MemberId";
                cmbMemberName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                 dgvReport.DataSource=rc.GetBugByMember(Convert.ToInt32(cmbMemberName.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
