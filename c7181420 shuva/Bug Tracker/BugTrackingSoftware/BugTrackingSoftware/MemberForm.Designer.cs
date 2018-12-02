namespace BugTrackingSoftware
{
    partial class MemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDOJ = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rdbOther = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMemberDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.dtpDOJ);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.rdbOther);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please provide all the informations";
            // 
            // dtpDOJ
            // 
            this.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOJ.Location = new System.Drawing.Point(542, 149);
            this.dtpDOJ.Name = "dtpDOJ";
            this.dtpDOJ.Size = new System.Drawing.Size(272, 31);
            this.dtpDOJ.TabIndex = 23;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(152, 149);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(272, 31);
            this.dtpDOB.TabIndex = 22;
            // 
            // rdbOther
            // 
            this.rdbOther.AutoSize = true;
            this.rdbOther.Location = new System.Drawing.Point(358, 111);
            this.rdbOther.Name = "rdbOther";
            this.rdbOther.Size = new System.Drawing.Size(80, 27);
            this.rdbOther.TabIndex = 21;
            this.rdbOther.TabStop = true;
            this.rdbOther.Text = "Other";
            this.rdbOther.UseVisualStyleBackColor = true;
            this.rdbOther.CheckedChanged += new System.EventHandler(this.rdbOther_CheckedChanged);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(257, 111);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(93, 27);
            this.rdbFemale.TabIndex = 20;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(152, 111);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(72, 27);
            this.rdbMale.TabIndex = 19;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Member",
            "Tester"});
            this.cmbRole.Location = new System.Drawing.Point(542, 67);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(272, 31);
            this.cmbRole.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(662, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(544, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(272, 31);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(152, 185);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(272, 31);
            this.txtUserName.TabIndex = 15;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(542, 108);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(272, 31);
            this.txtDesignation.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(542, 34);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 31);
            this.txtAddress.TabIndex = 13;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(152, 72);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(272, 31);
            this.txtContactNumber.TabIndex = 12;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(152, 35);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(272, 31);
            this.txtMemberName.TabIndex = 11;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMemberName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(435, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Role:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "User Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date of Join";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Designation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMemberDetails);
            this.panel1.Location = new System.Drawing.Point(9, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 244);
            this.panel1.TabIndex = 1;
            // 
            // dgvMemberDetails
            // 
            this.dgvMemberDetails.AllowUserToAddRows = false;
            this.dgvMemberDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvMemberDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvMemberDetails.Name = "dgvMemberDetails";
            this.dgvMemberDetails.ReadOnly = true;
            this.dgvMemberDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberDetails.Size = new System.Drawing.Size(1004, 244);
            this.dgvMemberDetails.TabIndex = 2;
            this.dgvMemberDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberDetails_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDeleteMember);
            this.panel2.Controls.Add(this.btnUpdateMember);
            this.panel2.Controls.Add(this.btnAddMember);
            this.panel2.Location = new System.Drawing.Point(854, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 276);
            this.panel2.TabIndex = 2;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(3, 186);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(148, 83);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "DELETE MEMBER";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click_1);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(4, 92);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(148, 88);
            this.btnUpdateMember.TabIndex = 1;
            this.btnUpdateMember.Text = "UPDATE MEMBER";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(3, 3);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(148, 83);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "ADD MEMBER";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1020, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDOJ;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rdbOther;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMemberDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnAddMember;
    }
}