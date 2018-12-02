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
    public partial class MemberDetailsList : Form
    {
        public MemberDetailsList()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        private void MemberDetailsList_Load(object sender, EventArgs e)
        {
            dgvMemberDetails.DataSource = mc.GetAllMembers();
        }
    }
}
