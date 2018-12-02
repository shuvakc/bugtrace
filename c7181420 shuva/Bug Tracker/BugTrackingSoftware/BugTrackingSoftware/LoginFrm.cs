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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        MemberClass mc = new MemberClass();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String Role = mc.GetRole(txtUserName.Text, txtPassword.Text);
                if (Role == "Admin")
                {
                    Form1 frm = new Form1();
                    frm.lblUser.Text = txtUserName.Text;
                    frm.Show();
                }
                else if (Role == "Member")
                {
                    MemberDashboard frm = new MemberDashboard();
                    frm.lblUser.Text = txtUserName.Text;
                    frm.Show();
                }else if (Role == "Tester")
                {
                    TesterDashboard frm = new TesterDashboard();
                    frm.lblUser.Text = txtUserName.Text;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("INVALID USER NAME OR PASSWORD");
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
