namespace BugTrackingSoftware
{
    partial class BugSolutionForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugSolutionForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSolutionDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteBugDetails = new System.Windows.Forms.Button();
            this.btnUpdateSolutionDetails = new System.Windows.Forms.Button();
            this.btnAddSolutionDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBugDetails = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.dtpSolutionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBugDetails = new System.Windows.Forms.ListView();
            this.BugId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BugDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSolutionDetails = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolutionDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolutionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(3, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 237);
            this.panel2.TabIndex = 5;
            // 
            // dgvSolutionDetails
            // 
            this.dgvSolutionDetails.AllowUserToAddRows = false;
            this.dgvSolutionDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSolutionDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolutionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolutionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolutionDetails.Location = new System.Drawing.Point(3, 471);
            this.dgvSolutionDetails.Name = "dgvSolutionDetails";
            this.dgvSolutionDetails.ReadOnly = true;
            this.dgvSolutionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolutionDetails.Size = new System.Drawing.Size(970, 233);
            this.dgvSolutionDetails.TabIndex = 0;
            this.dgvSolutionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolutionDetails_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDeleteBugDetails);
            this.panel1.Controls.Add(this.btnUpdateSolutionDetails);
            this.panel1.Controls.Add(this.btnAddSolutionDetails);
            this.panel1.Location = new System.Drawing.Point(792, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 253);
            this.panel1.TabIndex = 4;
            // 
            // btnDeleteBugDetails
            // 
            this.btnDeleteBugDetails.Location = new System.Drawing.Point(15, 170);
            this.btnDeleteBugDetails.Name = "btnDeleteBugDetails";
            this.btnDeleteBugDetails.Size = new System.Drawing.Size(154, 75);
            this.btnDeleteBugDetails.TabIndex = 2;
            this.btnDeleteBugDetails.Text = "NEXT SOLUTION DETAILS";
            this.btnDeleteBugDetails.UseVisualStyleBackColor = true;
            this.btnDeleteBugDetails.Click += new System.EventHandler(this.btnDeleteBugDetails_Click);
            // 
            // btnUpdateSolutionDetails
            // 
            this.btnUpdateSolutionDetails.Location = new System.Drawing.Point(15, 85);
            this.btnUpdateSolutionDetails.Name = "btnUpdateSolutionDetails";
            this.btnUpdateSolutionDetails.Size = new System.Drawing.Size(154, 75);
            this.btnUpdateSolutionDetails.TabIndex = 1;
            this.btnUpdateSolutionDetails.Text = "UPDATE SOLUTION DETAILS";
            this.btnUpdateSolutionDetails.UseVisualStyleBackColor = true;
            this.btnUpdateSolutionDetails.Click += new System.EventHandler(this.btnUpdateSolutionDetails_Click);
            // 
            // btnAddSolutionDetails
            // 
            this.btnAddSolutionDetails.Location = new System.Drawing.Point(15, 4);
            this.btnAddSolutionDetails.Name = "btnAddSolutionDetails";
            this.btnAddSolutionDetails.Size = new System.Drawing.Size(154, 75);
            this.btnAddSolutionDetails.TabIndex = 0;
            this.btnAddSolutionDetails.Text = "ADD SOLUTION DETAILS";
            this.btnAddSolutionDetails.UseVisualStyleBackColor = true;
            this.btnAddSolutionDetails.Click += new System.EventHandler(this.btnAddSolutionDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSolutionDetails);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBugDetails);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbProject);
            this.groupBox1.Controls.Add(this.dtpSolutionDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 455);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please provide all the fields";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Solution Details:";
            // 
            // cmbBugDetails
            // 
            this.cmbBugDetails.FormattingEnabled = true;
            this.cmbBugDetails.Location = new System.Drawing.Point(167, 98);
            this.cmbBugDetails.Name = "cmbBugDetails";
            this.cmbBugDetails.Size = new System.Drawing.Size(296, 31);
            this.cmbBugDetails.TabIndex = 8;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(167, 418);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(296, 31);
            this.txtRemarks.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remarks:";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(167, 62);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(296, 31);
            this.cmbProject.TabIndex = 4;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // dtpSolutionDate
            // 
            this.dtpSolutionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSolutionDate.Location = new System.Drawing.Point(167, 30);
            this.dtpSolutionDate.Name = "dtpSolutionDate";
            this.dtpSolutionDate.Size = new System.Drawing.Size(296, 31);
            this.dtpSolutionDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bug Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // lstBugDetails
            // 
            this.lstBugDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BugId,
            this.BugDetails});
            this.lstBugDetails.Location = new System.Drawing.Point(472, 12);
            this.lstBugDetails.Name = "lstBugDetails";
            this.lstBugDetails.Size = new System.Drawing.Size(314, 449);
            this.lstBugDetails.TabIndex = 6;
            this.lstBugDetails.UseCompatibleStateImageBehavior = false;
            this.lstBugDetails.View = System.Windows.Forms.View.Details;
            // 
            // BugId
            // 
            this.BugId.Text = "Bug Id";
            this.BugId.Width = 115;
            // 
            // BugDetails
            // 
            this.BugDetails.Text = "Bug Details";
            this.BugDetails.Width = 191;
            // 
            // txtSolutionDetails
            // 
            this.txtSolutionDetails.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtSolutionDetails.AutoScrollMinSize = new System.Drawing.Size(261, 18);
            this.txtSolutionDetails.BackBrush = null;
            this.txtSolutionDetails.CharHeight = 18;
            this.txtSolutionDetails.CharWidth = 10;
            this.txtSolutionDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSolutionDetails.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtSolutionDetails.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtSolutionDetails.IsReplaceMode = false;
            this.txtSolutionDetails.Location = new System.Drawing.Point(179, 158);
            this.txtSolutionDetails.Name = "txtSolutionDetails";
            this.txtSolutionDetails.Paddings = new System.Windows.Forms.Padding(0);
            this.txtSolutionDetails.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSolutionDetails.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtSolutionDetails.ServiceColors")));
            this.txtSolutionDetails.Size = new System.Drawing.Size(284, 254);
            this.txtSolutionDetails.TabIndex = 10;
            this.txtSolutionDetails.Text = "//Your solution here...";
            this.txtSolutionDetails.Zoom = 100;
            // 
            // BugSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 716);
            this.Controls.Add(this.dgvSolutionDetails);
            this.Controls.Add(this.lstBugDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BugSolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.Load += new System.EventHandler(this.BugSolutionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolutionDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolutionDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSolutionDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteBugDetails;
        private System.Windows.Forms.Button btnUpdateSolutionDetails;
        private System.Windows.Forms.Button btnAddSolutionDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBugDetails;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.DateTimePicker dtpSolutionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstBugDetails;
        private System.Windows.Forms.ColumnHeader BugId;
        private System.Windows.Forms.ColumnHeader BugDetails;
        private FastColoredTextBoxNS.FastColoredTextBox txtSolutionDetails;
    }
}