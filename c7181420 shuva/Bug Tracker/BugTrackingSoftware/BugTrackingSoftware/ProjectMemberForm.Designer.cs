namespace BugTrackingSoftware
{
    partial class ProjectMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMemberForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMemberRole = new System.Windows.Forms.TextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.txtMemberResponsibilities = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbDeketeProjectMember = new System.Windows.Forms.Button();
            this.btnUpdateProjectMember = new System.Windows.Forms.Button();
            this.btnAddProjectMember = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProjectMemberDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMemberDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMemberRole);
            this.groupBox1.Controls.Add(this.cmbProject);
            this.groupBox1.Controls.Add(this.cmbMember);
            this.groupBox1.Controls.Add(this.txtMemberResponsibilities);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please provide all the informations";
            // 
            // txtMemberRole
            // 
            this.txtMemberRole.Location = new System.Drawing.Point(225, 107);
            this.txtMemberRole.Name = "txtMemberRole";
            this.txtMemberRole.Size = new System.Drawing.Size(302, 31);
            this.txtMemberRole.TabIndex = 7;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(225, 29);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(302, 31);
            this.cmbProject.TabIndex = 6;
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(225, 65);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(302, 31);
            this.cmbMember.TabIndex = 5;
            // 
            // txtMemberResponsibilities
            // 
            this.txtMemberResponsibilities.Location = new System.Drawing.Point(225, 144);
            this.txtMemberResponsibilities.Multiline = true;
            this.txtMemberResponsibilities.Name = "txtMemberResponsibilities";
            this.txtMemberResponsibilities.Size = new System.Drawing.Size(302, 127);
            this.txtMemberResponsibilities.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Member Responsibilties:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Member Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btbDeketeProjectMember);
            this.panel1.Controls.Add(this.btnUpdateProjectMember);
            this.panel1.Controls.Add(this.btnAddProjectMember);
            this.panel1.Location = new System.Drawing.Point(553, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 277);
            this.panel1.TabIndex = 1;
            // 
            // btbDeketeProjectMember
            // 
            this.btbDeketeProjectMember.Location = new System.Drawing.Point(3, 176);
            this.btbDeketeProjectMember.Name = "btbDeketeProjectMember";
            this.btbDeketeProjectMember.Size = new System.Drawing.Size(161, 87);
            this.btbDeketeProjectMember.TabIndex = 2;
            this.btbDeketeProjectMember.Text = "DELETE PROJECT MEMBER";
            this.btbDeketeProjectMember.UseVisualStyleBackColor = true;
            this.btbDeketeProjectMember.Click += new System.EventHandler(this.btbDeketeProjectMember_Click);
            // 
            // btnUpdateProjectMember
            // 
            this.btnUpdateProjectMember.Location = new System.Drawing.Point(3, 93);
            this.btnUpdateProjectMember.Name = "btnUpdateProjectMember";
            this.btnUpdateProjectMember.Size = new System.Drawing.Size(161, 77);
            this.btnUpdateProjectMember.TabIndex = 1;
            this.btnUpdateProjectMember.Text = "UPDATE PROJECT MEMBER";
            this.btnUpdateProjectMember.UseVisualStyleBackColor = true;
            this.btnUpdateProjectMember.Click += new System.EventHandler(this.btnUpdateProjectMember_Click);
            // 
            // btnAddProjectMember
            // 
            this.btnAddProjectMember.Location = new System.Drawing.Point(3, 3);
            this.btnAddProjectMember.Name = "btnAddProjectMember";
            this.btnAddProjectMember.Size = new System.Drawing.Size(161, 77);
            this.btnAddProjectMember.TabIndex = 0;
            this.btnAddProjectMember.Text = "ADD PROJECT MEMBER";
            this.btnAddProjectMember.UseVisualStyleBackColor = true;
            this.btnAddProjectMember.Click += new System.EventHandler(this.btnAddProjectMember_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvProjectMemberDetails);
            this.panel2.Location = new System.Drawing.Point(13, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 237);
            this.panel2.TabIndex = 2;
            // 
            // dgvProjectMemberDetails
            // 
            this.dgvProjectMemberDetails.AllowUserToAddRows = false;
            this.dgvProjectMemberDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvProjectMemberDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjectMemberDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectMemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectMemberDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectMemberDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectMemberDetails.Name = "dgvProjectMemberDetails";
            this.dgvProjectMemberDetails.ReadOnly = true;
            this.dgvProjectMemberDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectMemberDetails.Size = new System.Drawing.Size(707, 233);
            this.dgvProjectMemberDetails.TabIndex = 0;
            this.dgvProjectMemberDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectMemberDetails_CellContentClick);
            // 
            // ProjectMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProjectMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.Load += new System.EventHandler(this.ProjectMemberForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMemberDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMemberRole;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.TextBox txtMemberResponsibilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btbDeketeProjectMember;
        private System.Windows.Forms.Button btnUpdateProjectMember;
        private System.Windows.Forms.Button btnAddProjectMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProjectMemberDetails;
    }
}