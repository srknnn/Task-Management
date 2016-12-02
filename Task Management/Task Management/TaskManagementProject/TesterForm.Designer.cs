namespace TaskManagementProject
{
    partial class TesterForm
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
            this.dgvTesterProjects = new System.Windows.Forms.DataGridView();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.dgvProjectsStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesterProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTesterProjects
            // 
            this.dgvTesterProjects.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvTesterProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesterProjects.Location = new System.Drawing.Point(9, 10);
            this.dgvTesterProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTesterProjects.Name = "dgvTesterProjects";
            this.dgvTesterProjects.RowTemplate.Height = 24;
            this.dgvTesterProjects.Size = new System.Drawing.Size(294, 349);
            this.dgvTesterProjects.TabIndex = 1;
            this.dgvTesterProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTesterProjects_CellMouseClick);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(356, 375);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(88, 56);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Bitti";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(271, 375);
            this.btnError.Margin = new System.Windows.Forms.Padding(2);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(81, 56);
            this.btnError.TabIndex = 3;
            this.btnError.Text = "Hatalı";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // dgvProjectsStatus
            // 
            this.dgvProjectsStatus.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvProjectsStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectsStatus.Location = new System.Drawing.Point(407, 10);
            this.dgvProjectsStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProjectsStatus.Name = "dgvProjectsStatus";
            this.dgvProjectsStatus.RowTemplate.Height = 24;
            this.dgvProjectsStatus.Size = new System.Drawing.Size(282, 349);
            this.dgvProjectsStatus.TabIndex = 4;
            this.dgvProjectsStatus.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjectsStatus_CellMouseClick);
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 488);
            this.Controls.Add(this.dgvProjectsStatus);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dgvTesterProjects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TesterForm";
            this.Text = "Test Uzmanı Formu";
            this.Load += new System.EventHandler(this.TesterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesterProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectsStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTesterProjects;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.DataGridView dgvProjectsStatus;
    }
}