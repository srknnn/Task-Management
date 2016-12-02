namespace TaskManagementProject
{
    partial class ProjectDetailsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchProjects = new System.Windows.Forms.TextBox();
            this.btnSearchProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearchProjects
            // 
            this.txtSearchProjects.Location = new System.Drawing.Point(262, 45);
            this.txtSearchProjects.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProjects.Multiline = true;
            this.txtSearchProjects.Name = "txtSearchProjects";
            this.txtSearchProjects.Size = new System.Drawing.Size(156, 31);
            this.txtSearchProjects.TabIndex = 1;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Location = new System.Drawing.Point(438, 45);
            this.btnSearchProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(99, 31);
            this.btnSearchProject.TabIndex = 2;
            this.btnSearchProject.Text = "Proje Ara";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // ProjectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 386);
            this.Controls.Add(this.btnSearchProject);
            this.Controls.Add(this.txtSearchProjects);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 424);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(825, 424);
            this.Name = "ProjectDetailsForm";
            this.Text = "Proje Detay Formu";
            this.Load += new System.EventHandler(this.ProjectDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchProjects;
        private System.Windows.Forms.Button btnSearchProject;
    }
}