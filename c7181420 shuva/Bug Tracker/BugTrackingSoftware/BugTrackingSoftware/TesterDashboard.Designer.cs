namespace BugTrackingSoftware
{
    partial class TesterDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TesterDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonProject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalProjects = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReportBug = new System.Windows.Forms.Button();
            this.btnNewBugsEntry = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProejctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BugDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProjectWiseSolutionReport = new System.Windows.Forms.Button();
            this.btnMemberWiseSolutionReport = new System.Windows.Forms.Button();
            this.btnAllBugReport = new System.Windows.Forms.Button();
            this.btnProjectWiseBugReport = new System.Windows.Forms.Button();
            this.btnMemberWiseBugReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATEWISEPROJECTREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLMEMBERREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLPROJECTREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProject
            // 
            this.buttonProject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProject.BackgroundImage")));
            this.buttonProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProject.Location = new System.Drawing.Point(375, 33);
            this.buttonProject.Name = "buttonProject";
            this.buttonProject.Size = new System.Drawing.Size(333, 246);
            this.buttonProject.TabIndex = 0;
            this.buttonProject.UseVisualStyleBackColor = true;
            this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.labelTotalProjects);
            this.panel1.Location = new System.Drawing.Point(375, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 61);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTotalProjects
            // 
            this.labelTotalProjects.AutoSize = true;
            this.labelTotalProjects.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProjects.ForeColor = System.Drawing.Color.Sienna;
            this.labelTotalProjects.Location = new System.Drawing.Point(12, 14);
            this.labelTotalProjects.Name = "labelTotalProjects";
            this.labelTotalProjects.Size = new System.Drawing.Size(44, 47);
            this.labelTotalProjects.TabIndex = 0;
            this.labelTotalProjects.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.btnNewBugsEntry);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(957, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 61);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // buttonReportBug
            // 
            this.buttonReportBug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReportBug.BackgroundImage")));
            this.buttonReportBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReportBug.Location = new System.Drawing.Point(957, 33);
            this.buttonReportBug.Name = "buttonReportBug";
            this.buttonReportBug.Size = new System.Drawing.Size(333, 246);
            this.buttonReportBug.TabIndex = 2;
            this.buttonReportBug.UseVisualStyleBackColor = true;
            // 
            // btnNewBugsEntry
            // 
            this.btnNewBugsEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewBugsEntry.BackgroundImage")));
            this.btnNewBugsEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewBugsEntry.Location = new System.Drawing.Point(268, 2);
            this.btnNewBugsEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewBugsEntry.Name = "btnNewBugsEntry";
            this.btnNewBugsEntry.Size = new System.Drawing.Size(61, 55);
            this.btnNewBugsEntry.TabIndex = 4;
            this.btnNewBugsEntry.UseVisualStyleBackColor = true;
            this.btnNewBugsEntry.Click += new System.EventHandler(this.btnNewBugsEntry_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ProejctName,
            this.MemberName,
            this.BugId,
            this.EntryDate,
            this.ClassName,
            this.MethodName,
            this.BlockName,
            this.LineNumber,
            this.BugDetails});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetails.Location = new System.Drawing.Point(-2, 351);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvDetails.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1488, 520);
            this.dgvDetails.TabIndex = 38;
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            // 
            // SNo
            // 
            this.SNo.HeaderText = "S.NO";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // ProejctName
            // 
            this.ProejctName.HeaderText = "Project Name";
            this.ProejctName.Name = "ProejctName";
            this.ProejctName.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // BugId
            // 
            this.BugId.HeaderText = "Bug Id";
            this.BugId.Name = "BugId";
            this.BugId.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.HeaderText = "Entry Date";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // MethodName
            // 
            this.MethodName.HeaderText = "Method Name";
            this.MethodName.Name = "MethodName";
            this.MethodName.ReadOnly = true;
            // 
            // BlockName
            // 
            this.BlockName.HeaderText = "Block Name";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            // 
            // LineNumber
            // 
            this.LineNumber.HeaderText = "Line Number";
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.ReadOnly = true;
            // 
            // BugDetails
            // 
            this.BugDetails.HeaderText = "Bug Details";
            this.BugDetails.Name = "BugDetails";
            this.BugDetails.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(1531, 714);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 149);
            this.panel6.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shuva Prabhat K.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developed By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bug Tracking System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProjectWiseSolutionReport);
            this.groupBox2.Controls.Add(this.btnMemberWiseSolutionReport);
            this.groupBox2.Controls.Add(this.btnAllBugReport);
            this.groupBox2.Controls.Add(this.btnProjectWiseBugReport);
            this.groupBox2.Controls.Add(this.btnMemberWiseBugReport);
            this.groupBox2.Location = new System.Drawing.Point(1528, 417);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 276);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUG REPORT";
            // 
            // btnProjectWiseSolutionReport
            // 
            this.btnProjectWiseSolutionReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectWiseSolutionReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProjectWiseSolutionReport.Location = new System.Drawing.Point(12, 219);
            this.btnProjectWiseSolutionReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnProjectWiseSolutionReport.Name = "btnProjectWiseSolutionReport";
            this.btnProjectWiseSolutionReport.Size = new System.Drawing.Size(247, 47);
            this.btnProjectWiseSolutionReport.TabIndex = 4;
            this.btnProjectWiseSolutionReport.Text = "PROJECT WISE SOLUTION REPORT";
            this.btnProjectWiseSolutionReport.UseVisualStyleBackColor = true;
            // 
            // btnMemberWiseSolutionReport
            // 
            this.btnMemberWiseSolutionReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberWiseSolutionReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMemberWiseSolutionReport.Location = new System.Drawing.Point(12, 170);
            this.btnMemberWiseSolutionReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemberWiseSolutionReport.Name = "btnMemberWiseSolutionReport";
            this.btnMemberWiseSolutionReport.Size = new System.Drawing.Size(247, 47);
            this.btnMemberWiseSolutionReport.TabIndex = 3;
            this.btnMemberWiseSolutionReport.Text = "MEMBER WISE SOLUTION REPORT";
            this.btnMemberWiseSolutionReport.UseVisualStyleBackColor = true;
            // 
            // btnAllBugReport
            // 
            this.btnAllBugReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBugReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllBugReport.Location = new System.Drawing.Point(12, 122);
            this.btnAllBugReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllBugReport.Name = "btnAllBugReport";
            this.btnAllBugReport.Size = new System.Drawing.Size(247, 47);
            this.btnAllBugReport.TabIndex = 2;
            this.btnAllBugReport.Text = "ALL BUG REPORT";
            this.btnAllBugReport.UseVisualStyleBackColor = true;
            // 
            // btnProjectWiseBugReport
            // 
            this.btnProjectWiseBugReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectWiseBugReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProjectWiseBugReport.Location = new System.Drawing.Point(12, 74);
            this.btnProjectWiseBugReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnProjectWiseBugReport.Name = "btnProjectWiseBugReport";
            this.btnProjectWiseBugReport.Size = new System.Drawing.Size(247, 47);
            this.btnProjectWiseBugReport.TabIndex = 1;
            this.btnProjectWiseBugReport.Text = "PROJECT WISE BUG REPORT";
            this.btnProjectWiseBugReport.UseVisualStyleBackColor = true;
            // 
            // btnMemberWiseBugReport
            // 
            this.btnMemberWiseBugReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberWiseBugReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMemberWiseBugReport.Location = new System.Drawing.Point(12, 26);
            this.btnMemberWiseBugReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemberWiseBugReport.Name = "btnMemberWiseBugReport";
            this.btnMemberWiseBugReport.Size = new System.Drawing.Size(247, 47);
            this.btnMemberWiseBugReport.TabIndex = 0;
            this.btnMemberWiseBugReport.Text = "MEMBER WISE BUG REPORT";
            this.btnMemberWiseBugReport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(1528, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 309);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROJECT REPORT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem,
            this.dATEWISEPROJECTREPORTToolStripMenuItem,
            this.aLLMEMBERREPORTToolStripMenuItem,
            this.aLLPROJECTREPORTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(241, 286);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mEMBERWISEPROJECTREPORTToolStripMenuItem
            // 
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Name = "mEMBERWISEPROJECTREPORTToolStripMenuItem";
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Text = "MEMBER WISE PROJECT REPORT";
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dATEWISEPROJECTREPORTToolStripMenuItem
            // 
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Name = "dATEWISEPROJECTREPORTToolStripMenuItem";
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Text = "DATE WISE PROJECT REPORT";
            this.dATEWISEPROJECTREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLLMEMBERREPORTToolStripMenuItem
            // 
            this.aLLMEMBERREPORTToolStripMenuItem.Name = "aLLMEMBERREPORTToolStripMenuItem";
            this.aLLMEMBERREPORTToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.aLLMEMBERREPORTToolStripMenuItem.Text = "ALL MEMBER REPORT";
            this.aLLMEMBERREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLLPROJECTREPORTToolStripMenuItem
            // 
            this.aLLPROJECTREPORTToolStripMenuItem.Name = "aLLPROJECTREPORTToolStripMenuItem";
            this.aLLPROJECTREPORTToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.aLLPROJECTREPORTToolStripMenuItem.Text = "ALL PROJECT REPORT";
            this.aLLPROJECTREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1523, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 28);
            this.label8.TabIndex = 42;
            this.label8.Text = "TESTER PANEL";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblDateTime);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 871);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1827, 51);
            this.panel3.TabIndex = 43;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(1494, 11);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(121, 28);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "DateTime";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(143, 11);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 28);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Guest";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(8, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Welcome:";
            // 
            // TesterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonReportBug);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonProject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TesterDashboard";
            this.Text = "Tester Dashboard";
            this.Load += new System.EventHandler(this.TesterDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalProjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReportBug;
        private System.Windows.Forms.Button btnNewBugsEntry;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProejctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugDetails;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProjectWiseSolutionReport;
        private System.Windows.Forms.Button btnMemberWiseSolutionReport;
        private System.Windows.Forms.Button btnAllBugReport;
        private System.Windows.Forms.Button btnProjectWiseBugReport;
        private System.Windows.Forms.Button btnMemberWiseBugReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mEMBERWISEPROJECTREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATEWISEPROJECTREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLMEMBERREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLPROJECTREPORTToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDateTime;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label9;
    }
}