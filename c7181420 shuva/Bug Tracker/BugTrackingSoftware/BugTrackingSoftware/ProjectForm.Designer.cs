namespace BugTrackingSoftware
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.dgvProjectDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.dtpProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpProjectStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(4, 154);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(148, 68);
            this.btnDeleteProject.TabIndex = 2;
            this.btnDeleteProject.Text = "DELETE PROJECT";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(4, 4);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(148, 68);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "ADD PROJECT";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDeleteProject);
            this.panel2.Controls.Add(this.btnUpdateProject);
            this.panel2.Controls.Add(this.btnAddProject);
            this.panel2.Location = new System.Drawing.Point(853, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 246);
            this.panel2.TabIndex = 5;
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(3, 78);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(148, 70);
            this.btnUpdateProject.TabIndex = 1;
            this.btnUpdateProject.Text = "UPDATE PROJECT";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // dgvProjectDetails
            // 
            this.dgvProjectDetails.AllowUserToAddRows = false;
            this.dgvProjectDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvProjectDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjectDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.ReadOnly = true;
            this.dgvProjectDetails.Size = new System.Drawing.Size(1004, 244);
            this.dgvProjectDetails.TabIndex = 2;
            this.dgvProjectDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectDetails_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProjectDetails);
            this.panel1.Location = new System.Drawing.Point(8, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 244);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.txtProjectDescription);
            this.groupBox1.Controls.Add(this.dtpProjectEndDate);
            this.groupBox1.Controls.Add(this.dtpProjectStartDate);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 285);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please provide all the informations";
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(180, 120);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(649, 159);
            this.txtProjectDescription.TabIndex = 7;
            // 
            // dtpProjectEndDate
            // 
            this.dtpProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProjectEndDate.Location = new System.Drawing.Point(572, 79);
            this.dtpProjectEndDate.Name = "dtpProjectEndDate";
            this.dtpProjectEndDate.Size = new System.Drawing.Size(257, 31);
            this.dtpProjectEndDate.TabIndex = 6;
            // 
            // dtpProjectStartDate
            // 
            this.dtpProjectStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProjectStartDate.Location = new System.Drawing.Point(180, 84);
            this.dtpProjectStartDate.Name = "dtpProjectStartDate";
            this.dtpProjectStartDate.Size = new System.Drawing.Size(257, 31);
            this.dtpProjectStartDate.TabIndex = 5;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(180, 38);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(649, 31);
            this.txtProjectName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Project End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name:";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProjectDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.DateTimePicker dtpProjectEndDate;
        private System.Windows.Forms.DateTimePicker dtpProjectStartDate;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDeleteProject;
        public System.Windows.Forms.Button btnAddProject;
        public System.Windows.Forms.Button btnUpdateProject;
    }
}