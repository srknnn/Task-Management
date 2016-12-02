namespace TaskManagementProject
{
    partial class AnalyzeTask
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
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(85, 32);
            this.dataGridViewProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.RowTemplate.Height = 24;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(578, 214);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProjects_CellMouseClick);
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTask.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(84, 284);
            this.dataGridViewTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowTemplate.Height = 24;
            this.dataGridViewTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTask.Size = new System.Drawing.Size(578, 214);
            this.dataGridViewTask.TabIndex = 1;
            this.dataGridViewTask.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTask_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(82, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(82, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlanmamış Taskler";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(84, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(579, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Analiz Edildi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnalyzeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTask);
            this.Controls.Add(this.dataGridViewProjects);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(782, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(782, 610);
            this.Name = "AnalyzeTask";
            this.Text = "Analiz Formu";
            this.Load += new System.EventHandler(this.AnalyzeTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}