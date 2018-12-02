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
    public partial class TesterDashboard : Form
    {
        MemberClass mc = new MemberClass();

        public TesterDashboard()
        {
            InitializeComponent();
        }

        private void TesterDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonProject_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewBugsEntry_Click(object sender, EventArgs e)
        {
            BugEntryForm frm = new BugEntryForm();
            frm.MemberId = mc.GetMemberIdByUserName(lblUser.Text);
            frm.UserName = lblUser.Text;
            frm.Show();
        }
    }
}
