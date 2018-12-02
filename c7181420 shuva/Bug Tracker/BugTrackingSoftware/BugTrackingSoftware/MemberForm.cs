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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }
        public String Gender;
        public int deleteID = 0;
        MemberClass mc = new MemberClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void rdbOther_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Other";
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageMembers(0,
                    txtMemberName.Text,
                    txtAddress.Text,
                    txtContactNumber.Text,
                    txtEmail.Text,
                    Gender,
                    dtpDOB.Text,
                    dtpDOJ.Text,
                    txtDesignation.Text,
                    cmbRole.Text,
                    txtUserName.Text,
                    txtPassword.Text,
                    1);
                if (result == true)
                {
                    MessageBox.Show("Member Successfully Added to the database");
                    dgvMemberDetails.DataSource = mc.GetAllMembers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            dgvMemberDetails.DataSource = mc.GetAllMembers();
            
        }

        private void btnDeleteMember_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool result = mc.DeleteMemberByID(deleteID);
                if (result == true)
                {
                    MessageBox.Show("Member Deleted from the database");
                    dgvMemberDetails.DataSource = mc.GetAllMembers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMemberDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMemberDetails.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvMemberDetails.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvMemberDetails.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["MemberId"].Value);

                deleteID = Convert.ToInt32(a);

                txtMemberName.Text = Convert.ToString(selectedRow.Cells["MemberName"].Value);
                txtAddress.Text = Convert.ToString(selectedRow.Cells["Address"].Value);
                txtContactNumber.Text = Convert.ToString(selectedRow.Cells["Contact"].Value);
                cmbRole.SelectedText = Convert.ToString(selectedRow.Cells["Role"].Value);
                String gender = Convert.ToString(selectedRow.Cells["Gender"].Value);

                if (gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdbFemale.Checked = true;
                }
                else if (gender == "Other")
                {
                    rdbOther.Checked = true;
                }

                dtpDOB.Text = Convert.ToString(selectedRow.Cells["DateofBirth"].Value);
                dtpDOJ.Text = Convert.ToString(selectedRow.Cells["DateofJoin"].Value);
                txtUserName.Text = Convert.ToString(selectedRow.Cells["UserName"].Value);
                txtPassword.Text = Convert.ToString(selectedRow.Cells["Password"].Value);
                txtEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                txtDesignation.Text = Convert.ToString(selectedRow.Cells["Designation"].Value); 
            }
            
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageMembers(deleteID,
                    txtMemberName.Text,
                    txtAddress.Text,
                    txtContactNumber.Text,
                    txtEmail.Text,
                    Gender,
                    dtpDOB.Text,
                    dtpDOJ.Text,
                    txtDesignation.Text,
                    cmbRole.Text,
                    txtUserName.Text,
                    txtPassword.Text,
                    2);
                if (result == true)
                {
                    MessageBox.Show("Member Successfully Updated from the database");
                    dgvMemberDetails.DataSource = mc.GetAllMembers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
