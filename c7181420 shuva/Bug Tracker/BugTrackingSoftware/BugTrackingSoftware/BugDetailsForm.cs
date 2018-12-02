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
    public partial class BugDetailsForm : Form
    {
        public BugDetailsForm()
        {
            InitializeComponent();
        }
        BugEntryClass bec = new BugEntryClass();
        private void BugDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvBugDetails.DataSource = bec.GetAllBugs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
