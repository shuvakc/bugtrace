    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            // Launch the ToolsQA WebSite
            driver.Url = ("https://github.com/shuvakc/bugtrace");

            // Type Name in the FirstName text box      
            //driver.FindElement(By.Name("firstname")).SendKeys("shuvakc");
            driver.FindElement(By.Id("user_login")).SendKeys("shuvaprabhatkc2359@gmail.com");

            //Type LastName in the LastName text box
            driver.FindElement(By.Id("user_password")).SendKeys("shuvakc2359");

            // Click on the Submit button
            driver.FindElement(By.Name("commit")).Click();

        }
    }
}
