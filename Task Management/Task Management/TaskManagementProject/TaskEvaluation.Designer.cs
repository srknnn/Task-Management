namespace TaskManagementProject
{
    partial class TaskEvaluation
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
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.dgvIdleTask = new System.Windows.Forms.DataGridView();
            this.rdbBeDeveloped = new System.Windows.Forms.RadioButton();
            this.rdbTest = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdleTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(9, 25);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(360, 153);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjects_CellMouseClick);
            // 
            // dgvIdleTask
            // 
            this.dgvIdleTask.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvIdleTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdleTask.Location = new System.Drawing.Point(9, 204);
            this.dgvIdleTask.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIdleTask.Name = "dgvIdleTask";
            this.dgvIdleTask.RowTemplate.Height = 24;
            this.dgvIdleTask.Size = new System.Drawing.Size(360, 275);
            this.dgvIdleTask.TabIndex = 1;
            // 
            // rdbBeDeveloped
            // 
            this.rdbBeDeveloped.AutoSize = true;
            this.rdbBeDeveloped.Checked = true;
            this.rdbBeDeveloped.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbBeDeveloped.Location = new System.Drawing.Point(406, 232);
            this.rdbBeDeveloped.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBeDeveloped.Name = "rdbBeDeveloped";
            this.rdbBeDeveloped.Size = new System.Drawing.Size(106, 20);
            this.rdbBeDeveloped.TabIndex = 2;
            this.rdbBeDeveloped.TabStop = true;
            this.rdbBeDeveloped.Text = "Geliştirilecek";
            this.rdbBeDeveloped.UseVisualStyleBackColor = true;
            // 
            // rdbTest
            // 
            this.rdbTest.AutoSize = true;
            this.rdbTest.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTest.Location = new System.Drawing.Point(406, 278);
            this.rdbTest.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTest.Name = "rdbTest";
            this.rdbTest.Size = new System.Drawing.Size(109, 20);
            this.rdbTest.TabIndex = 3;
            this.rdbTest.Text = "Test Edilecek";
            this.rdbTest.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(406, 323);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boştaki Task";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(415, 188);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 16);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "İşi Güncelle";
            // 
            // TaskEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 556);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rdbTest);
            this.Controls.Add(this.rdbBeDeveloped);
            this.Controls.Add(this.dgvIdleTask);
            this.Controls.Add(this.dgvProjects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 594);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(719, 594);
            this.Name = "TaskEvaluation";
            this.Text = "İş Değerlendirme Formu";
            this.Load += new System.EventHandler(this.TaskEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdleTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridView dgvIdleTask;
        private System.Windows.Forms.RadioButton rdbBeDeveloped;
        private System.Windows.Forms.RadioButton rdbTest;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
    }
}