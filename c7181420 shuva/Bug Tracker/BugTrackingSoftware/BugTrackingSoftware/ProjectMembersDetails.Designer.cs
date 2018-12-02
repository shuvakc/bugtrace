namespace BugTrackingSoftware
{
    partial class ProjectMembersDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMembersDetails));
            this.dgvProjectMembersDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMembersDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjectMembersDetails
            // 
            this.dgvProjectMembersDetails.AllowUserToAddRows = false;
            this.dgvProjectMembersDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvProjectMembersDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjectMembersDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectMembersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectMembersDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectMembersDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectMembersDetails.Name = "dgvProjectMembersDetails";
            this.dgvProjectMembersDetails.ReadOnly = true;
            this.dgvProjectMembersDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectMembersDetails.Size = new System.Drawing.Size(1080, 561);
            this.dgvProjectMembersDetails.TabIndex = 0;
            // 
            // ProjectMembersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 561);
            this.Controls.Add(this.dgvProjectMembersDetails);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProjectMembersDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUG TRACKING SOFTWARE";
            this.Load += new System.EventHandler(this.ProjectMembersDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMembersDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjectMembersDetails;
    }
}