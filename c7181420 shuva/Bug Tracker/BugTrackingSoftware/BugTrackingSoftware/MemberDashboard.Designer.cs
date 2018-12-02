namespace BugTrackingSoftware
{
    partial class MemberDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewBugsEntry = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATEWISEPROJECTREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLMEMBERREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLPROJECTREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalSolutions = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBugsEntry = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBugSolution = new System.Windows.Forms.Button();
            this.lblTotalProject = new System.Windows.Forms.Label();
            this.btnSolutionDetails = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalBugs = new System.Windows.Forms.Label();
            this.btnProjectsDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMemberProjectDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProjectWiseSolutionReport = new System.Windows.Forms.Button();
            this.btnMemberWiseSolutionReport = new System.Windows.Forms.Button();
            this.btnAllBugReport = new System.Windows.Forms.Button();
            this.btnProjectWiseBugReport = new System.Windows.Forms.Button();
            this.btnMemberWiseBugReport = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewBugsEntry
            // 
            this.btnNewBugsEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewBugsEntry.BackgroundImage")));
            this.btnNewBugsEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewBugsEntry.Location = new System.Drawing.Point(197, 0);
            this.btnNewBugsEntry.Name = "btnNewBugsEntry";
            this.btnNewBugsEntry.Size = new System.Drawing.Size(46, 45);
            this.btnNewBugsEntry.TabIndex = 3;
            this.btnNewBugsEntry.UseVisualStyleBackColor = true;
            this.btnNewBugsEntry.Click += new System.EventHandler(this.btnNewBugsEntry_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(1159, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 251);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROJECT REPORT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem,
            this.dATEWISEPROJECTREPORTToolStripMenuItem,
            this.aLLMEMBERREPORTToolStripMenuItem,
            this.aLLPROJECTREPORTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(195, 232);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mEMBERWISEPROJECTREPORTToolStripMenuItem
            // 
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Name = "mEMBERWISEPROJECTREPORTToolStripMenuItem";
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Size = new System.Drawing.Size(188, 19);
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Text = "MEMBER WISE PROJECT REPORT";
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mEMBERWISEPROJECTREPORTToolStripMenuItem.Click += new System.EventHandler(this.mEMBERWISEPROJECTREPORTToolStripMenuItem_Click);
            // 
            // dATEWISEPROJECTREPORTToolStripMenuItem
            // 
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Name = "dATEWISEPROJECTREPORTToolStripMenuItem";
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Size = new System.Drawing.Size(188, 19);
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Text = "DATE WISE PROJECT REPORT";
            this.dATEWISEPROJECTREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dATEWISEPROJECTREPORTToolStripMenuItem.Click += new System.EventHandler(this.dATEWISEPROJECTREPORTToolStripMenuItem_Click);
            // 
            // aLLMEMBERREPORTToolStripMenuItem
            // 
            this.aLLMEMBERREPORTToolStripMenuItem.Name = "aLLMEMBERREPORTToolStripMenuItem";
            this.aLLMEMBERREPORTToolStripMenuItem.Size = new System.Drawing.Size(188, 19);
            this.aLLMEMBERREPORTToolStripMenuItem.Text = "ALL MEMBER REPORT";
            this.aLLMEMBERREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aLLMEMBERREPORTToolStripMenuItem.Click += new System.EventHandler(this.aLLMEMBERREPORTToolStripMenuItem_Click);
            // 
            // aLLPROJECTREPORTToolStripMenuItem
            // 
            this.aLLPROJECTREPORTToolStripMenuItem.Name = "aLLPROJECTREPORTToolStripMenuItem";
            this.aLLPROJECTREPORTToolStripMenuItem.Size = new System.Drawing.Size(188, 19);
            this.aLLPROJECTREPORTToolStripMenuItem.Text = "ALL PROJECT REPORT";
            this.aLLPROJECTREPORTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aLLPROJECTREPORTToolStripMenuItem.Click += new System.EventHandler(this.aLLPROJECTREPORTToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1155, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "MEMBER PANEL";
            // 
            // lblTotalSolutions
            // 
            this.lblTotalSolutions.AutoSize = true;
            this.lblTotalSolutions.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSolutions.ForeColor = System.Drawing.Color.Sienna;
            this.lblTotalSolutions.Location = new System.Drawing.Point(12, 5);
            this.lblTotalSolutions.Name = "lblTotalSolutions";
            this.lblTotalSolutions.Size = new System.Drawing.Size(31, 32);
            this.lblTotalSolutions.TabIndex = 3;
            this.lblTotalSolutions.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(1159, 531);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 122);
            this.panel6.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shuva Prabhat K.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developed By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Tracking System";
            // 
            // btnBugsEntry
            // 
            this.btnBugsEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBugsEntry.BackgroundImage")));
            this.btnBugsEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBugsEntry.Location = new System.Drawing.Point(323, 15);
            this.btnBugsEntry.Name = "btnBugsEntry";
            this.btnBugsEntry.Size = new System.Drawing.Size(250, 200);
            this.btnBugsEntry.TabIndex = 25;
            this.btnBugsEntry.UseVisualStyleBackColor = true;
            this.btnBugsEntry.Click += new System.EventHandler(this.btnBugsEntry_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnBugSolution);
            this.panel5.Controls.Add(this.lblTotalSolutions);
            this.panel5.Location = new System.Drawing.Point(604, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 50);
            this.panel5.TabIndex = 26;
            // 
            // btnBugSolution
            // 
            this.btnBugSolution.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBugSolution.BackgroundImage")));
            this.btnBugSolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBugSolution.Location = new System.Drawing.Point(197, 0);
            this.btnBugSolution.Name = "btnBugSolution";
            this.btnBugSolution.Size = new System.Drawing.Size(46, 45);
            this.btnBugSolution.TabIndex = 4;
            this.btnBugSolution.UseVisualStyleBackColor = true;
            this.btnBugSolution.Click += new System.EventHandler(this.btnBugSolution_Click);
            // 
            // lblTotalProject
            // 
            this.lblTotalProject.AutoSize = true;
            this.lblTotalProject.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProject.ForeColor = System.Drawing.Color.Sienna;
            this.lblTotalProject.Location = new System.Drawing.Point(15, 5);
            this.lblTotalProject.Name = "lblTotalProject";
            this.lblTotalProject.Size = new System.Drawing.Size(31, 32);
            this.lblTotalProject.TabIndex = 1;
            this.lblTotalProject.Text = "0";
            // 
            // btnSolutionDetails
            // 
            this.btnSolutionDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSolutionDetails.BackgroundImage")));
            this.btnSolutionDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolutionDetails.Location = new System.Drawing.Point(604, 20);
            this.btnSolutionDetails.Name = "btnSolutionDetails";
            this.btnSolutionDetails.Size = new System.Drawing.Size(250, 200);
            this.btnSolutionDetails.TabIndex = 23;
            this.btnSolutionDetails.UseVisualStyleBackColor = true;
            this.btnSolutionDetails.Click += new System.EventHandler(this.btnSolutionDetails_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnNewBugsEntry);
            this.panel4.Controls.Add(this.lblTotalBugs);
            this.panel4.Location = new System.Drawing.Point(323, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 50);
            this.panel4.TabIndex = 24;
            // 
            // lblTotalBugs
            // 
            this.lblTotalBugs.AutoSize = true;
            this.lblTotalBugs.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBugs.ForeColor = System.Drawing.Color.Sienna;
            this.lblTotalBugs.Location = new System.Drawing.Point(12, 5);
            this.lblTotalBugs.Name = "lblTotalBugs";
            this.lblTotalBugs.Size = new System.Drawing.Size(31, 32);
            this.lblTotalBugs.TabIndex = 2;
            this.lblTotalBugs.Text = "0";
            // 
            // btnProjectsDetails
            // 
            this.btnProjectsDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjectsDetails.BackgroundImage")));
            this.btnProjectsDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjectsDetails.Location = new System.Drawing.Point(34, 15);
            this.btnProjectsDetails.Name = "btnProjectsDetails";
            this.btnProjectsDetails.Size = new System.Drawing.Size(250, 200);
            this.btnProjectsDetails.TabIndex = 21;
            this.btnProjectsDetails.UseVisualStyleBackColor = true;
            this.btnProjectsDetails.Click += new System.EventHandler(this.btnProjectsDetails_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTotalProject);
            this.panel3.Location = new System.Drawing.Point(34, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 50);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDateTime);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 707);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 42);
            this.panel2.TabIndex = 19;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTime.Location = new System.Drawing.Point(1119, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(95, 22);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "DateTime";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(107, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 22);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Guest";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Welcome:";
            // 
            // btnMemberProjectDetails
            // 
            this.btnMemberProjectDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMemberProjectDetails.BackgroundImage")));
            this.btnMemberProjectDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemberProjectDetails.Location = new System.Drawing.Point(899, 12);
            this.btnMemberProjectDetails.Name = "btnMemberProjectDetails";
            this.btnMemberProjectDetails.Size = new System.Drawing.Size(250, 200);
            this.btnMemberProjectDetails.TabIndex = 34;
            this.btnMemberProjectDetails.UseVisualStyleBackColor = true;
            this.btnMemberProjectDetails.Click += new System.EventHandler(this.btnMemberProjectDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTotalMembers);
            this.panel1.Location = new System.Drawing.Point(899, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 50);
            this.panel1.TabIndex = 35;
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembers.ForeColor = System.Drawing.Color.Sienna;
            this.lblTotalMembers.Location = new System.Drawing.Point(12, 5);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(31, 32);
            this.lblTotalMembers.TabIndex = 2;
            this.lblTotalMembers.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProjectWiseSolutionReport);
            this.groupBox2.Controls.Add(this.btnMemberWiseSolutionReport);
            this.groupBox2.Controls.Add(this.btnAllBugReport);
            this.groupBox2.Controls.Add(this.btnProjectWiseBugReport);
            this.groupBox2.Controls.Add(this.btnMemberWiseBugReport);
            this.groupBox2.Location = new System.Drawing.Point(1155, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 224);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUG REPORT";
            // 
            // btnProjectWiseSolutionReport
            // 
            this.btnProjectWiseSolutionReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectWiseSolutionReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProjectWiseSolutionReport.Location = new System.Drawing.Point(9, 178);
            this.btnProjectWiseSolutionReport.Name = "btnProjectWiseSolutionReport";
            this.btnProjectWiseSolutionReport.Size = new System.Drawing.Size(185, 38);
            this.btnProjectWiseSolutionReport.TabIndex = 4;
            this.btnProjectWiseSolutionReport.Text = "PROJECT WISE SOLUTION REPORT";
            this.btnProjectWiseSolutionReport.UseVisualStyleBackColor = true;
            this.btnProjectWiseSolutionReport.Click += new System.EventHandler(this.btnProjectWiseSolutionReport_Click);
            // 
            // btnMemberWiseSolutionReport
            // 
            this.btnMemberWiseSolutionReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberWiseSolutionReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMemberWiseSolutionReport.Location = new System.Drawing.Point(9, 138);
            this.btnMemberWiseSolutionReport.Name = "btnMemberWiseSolutionReport";
            this.btnMemberWiseSolutionReport.Size = new System.Drawing.Size(185, 38);
            this.btnMemberWiseSolutionReport.TabIndex = 3;
            this.btnMemberWiseSolutionReport.Text = "MEMBER WISE SOLUTION REPORT";
            this.btnMemberWiseSolutionReport.UseVisualStyleBackColor = true;
            this.btnMemberWiseSolutionReport.Click += new System.EventHandler(this.btnMemberWiseSolutionReport_Click);
            // 
            // btnAllBugReport
            // 
            this.btnAllBugReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBugReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllBugReport.Location = new System.Drawing.Point(9, 99);
            this.btnAllBugReport.Name = "btnAllBugReport";
            this.btnAllBugReport.Size = new System.Drawing.Size(185, 38);
            this.btnAllBugReport.TabIndex = 2;
            this.btnAllBugReport.Text = "ALL BUG REPORT";
            this.btnAllBugReport.UseVisualStyleBackColor = true;
            this.btnAllBugReport.Click += new System.EventHandler(this.btnAllBugReport_Click);
            // 
            // btnProjectWiseBugReport
            // 
            this.btnProjectWiseBugReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectWiseBugReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProjectWiseBugReport.Location = new System.Drawing.Point(9, 60);
            this.btnProjectWiseBugReport.Name = "btnProjectWiseBugReport";
            this.btnProjectWiseBugReport.Size = new System.Drawing.Size(185, 38);
            this.btnProjectWiseBugReport.TabIndex = 1;
            this.btnProjectWiseBugReport.Text = "PROJECT WISE BUG REPORT";
            this.btnProjectWiseBugReport.UseVisualStyleBackColor = true;
            this.btnProjectWiseBugReport.Click += new System.EventHandler(this.btnProjectWiseBugReport_Click);
            // 
            // btnMemberWiseBugReport
            // 
            this.btnMemberWiseBugReport.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberWiseBugReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMemberWiseBugReport.Location = new System.Drawing.Point(9, 21);
            this.btnMemberWiseBugReport.Name = "btnMemberWiseBugReport";
            this.btnMemberWiseBugReport.Size = new System.Drawing.Size(185, 38);
            this.btnMemberWiseBugReport.TabIndex = 0;
            this.btnMemberWiseBugReport.Text = "MEMBER WISE BUG REPORT";
            this.btnMemberWiseBugReport.UseVisualStyleBackColor = true;
            this.btnMemberWiseBugReport.Click += new System.EventHandler(this.btnMemberWiseBugReport_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetails.Location = new System.Drawing.Point(33, 301);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1116, 352);
            this.dgvDetails.TabIndex = 37;
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
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMemberProjectDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnBugsEntry);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnSolutionDetails);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnProjectsDetails);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewBugsEntry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mEMBERWISEPROJECTREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATEWISEPROJECTREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLMEMBERREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLPROJECTREPORTToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSolutions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBugsEntry;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBugSolution;
        private System.Windows.Forms.Label lblTotalProject;
        private System.Windows.Forms.Button btnSolutionDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalBugs;
        private System.Windows.Forms.Button btnProjectsDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMemberProjectDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblDateTime;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProjectWiseSolutionReport;
        private System.Windows.Forms.Button btnMemberWiseSolutionReport;
        private System.Windows.Forms.Button btnAllBugReport;
        private System.Windows.Forms.Button btnProjectWiseBugReport;
        private System.Windows.Forms.Button btnMemberWiseBugReport;
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
    }
}