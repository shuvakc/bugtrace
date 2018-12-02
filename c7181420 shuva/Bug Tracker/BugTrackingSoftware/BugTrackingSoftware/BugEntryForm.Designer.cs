namespace BugTrackingSoftware
{
    partial class BugEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugEntryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBugDetails = new System.Windows.Forms.TextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.dtpBugEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteBugDetails = new System.Windows.Forms.Button();
            this.btnUpdateBugDetails = new System.Windows.Forms.Button();
            this.btnAddBugDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBugEntryDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugEntryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLineNumber);
            this.groupBox1.Controls.Add(this.txtBlockName);
            this.groupBox1.Controls.Add(this.txtMethodName);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBugDetails);
            this.groupBox1.Controls.Add(this.cmbProject);
            this.groupBox1.Controls.Add(this.dtpBugEntryDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please provide all the fields";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Line, Method.. Details will be added by the developer.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Line Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Block Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Method Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Class Name:";
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(167, 231);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(374, 26);
            this.txtLineNumber.TabIndex = 11;
            // 
            // txtBlockName
            // 
            this.txtBlockName.Location = new System.Drawing.Point(167, 190);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(374, 26);
            this.txtBlockName.TabIndex = 10;
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(167, 149);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(374, 26);
            this.txtMethodName.TabIndex = 9;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(167, 108);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(374, 26);
            this.txtClassName.TabIndex = 8;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(167, 329);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(374, 26);
            this.txtRemarks.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remarks:";
            // 
            // txtBugDetails
            // 
            this.txtBugDetails.Location = new System.Drawing.Point(167, 262);
            this.txtBugDetails.Multiline = true;
            this.txtBugDetails.Name = "txtBugDetails";
            this.txtBugDetails.Size = new System.Drawing.Size(374, 61);
            this.txtBugDetails.TabIndex = 5;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(167, 66);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(374, 27);
            this.cmbProject.TabIndex = 4;
            // 
            // dtpBugEntryDate
            // 
            this.dtpBugEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBugEntryDate.Location = new System.Drawing.Point(167, 23);
            this.dtpBugEntryDate.Name = "dtpBugEntryDate";
            this.dtpBugEntryDate.Size = new System.Drawing.Size(374, 26);
            this.dtpBugEntryDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bug Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDeleteBugDetails);
            this.panel1.Controls.Add(this.btnUpdateBugDetails);
            this.panel1.Controls.Add(this.btnAddBugDetails);
            this.panel1.Location = new System.Drawing.Point(579, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 367);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteBugDetails
            // 
            this.btnDeleteBugDetails.Location = new System.Drawing.Point(3, 238);
            this.btnDeleteBugDetails.Name = "btnDeleteBugDetails";
            this.btnDeleteBugDetails.Size = new System.Drawing.Size(169, 115);
            this.btnDeleteBugDetails.TabIndex = 2;
            this.btnDeleteBugDetails.Text = "DELETE BUG DETAILS";
            this.btnDeleteBugDetails.UseVisualStyleBackColor = true;
            this.btnDeleteBugDetails.Click += new System.EventHandler(this.btnDeleteBugDetails_Click);
            // 
            // btnUpdateBugDetails
            // 
            this.btnUpdateBugDetails.Location = new System.Drawing.Point(3, 124);
            this.btnUpdateBugDetails.Name = "btnUpdateBugDetails";
            this.btnUpdateBugDetails.Size = new System.Drawing.Size(169, 105);
            this.btnUpdateBugDetails.TabIndex = 1;
            this.btnUpdateBugDetails.Text = "UPDATE BUG DETAILS";
            this.btnUpdateBugDetails.UseVisualStyleBackColor = true;
            this.btnUpdateBugDetails.Click += new System.EventHandler(this.btnUpdateBugDetails_Click);
            // 
            // btnAddBugDetails
            // 
            this.btnAddBugDetails.Location = new System.Drawing.Point(3, 3);
            this.btnAddBugDetails.Name = "btnAddBugDetails";
            this.btnAddBugDetails.Size = new System.Drawing.Size(169, 113);
            this.btnAddBugDetails.TabIndex = 0;
            this.btnAddBugDetails.Text = "ADD BUG DETAILS";
            this.btnAddBugDetails.UseVisualStyleBackColor = true;
            this.btnAddBugDetails.Click += new System.EventHandler(this.btnAddBugDetails_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvBugEntryDetails);
            this.panel2.Location = new System.Drawing.Point(3, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 237);
            this.panel2.TabIndex = 2;
            // 
            // dgvBugEntryDetails
            // 
            this.dgvBugEntryDetails.AllowUserToAddRows = false;
            this.dgvBugEntryDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvBugEntryDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBugEntryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBugEntryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugEntryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBugEntryDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvBugEntryDetails.Name = "dgvBugEntryDetails";
            this.dgvBugEntryDetails.ReadOnly = true;
            this.dgvBugEntryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBugEntryDetails.Size = new System.Drawing.Size(751, 233);
            this.dgvBugEntryDetails.TabIndex = 0;
            this.dgvBugEntryDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugEntryDetails_CellContentClick);
            // 
            // BugEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BugEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.Load += new System.EventHandler(this.BugEntryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugEntryDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBugDetails;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.DateTimePicker dtpBugEntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteBugDetails;
        private System.Windows.Forms.Button btnUpdateBugDetails;
        private System.Windows.Forms.Button btnAddBugDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBugEntryDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label9;
    }
}