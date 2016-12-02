namespace TaskManagementProject
{
    partial class IdleTaskForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewEmptyTasks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmptyTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.RowTemplate.Height = 24;
            this.dataGridViewProjects.Size = new System.Drawing.Size(268, 337);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProjects_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "İşi Üzerine Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEmptyTasks
            // 
            this.dataGridViewEmptyTasks.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewEmptyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmptyTasks.Location = new System.Drawing.Point(285, 33);
            this.dataGridViewEmptyTasks.Name = "dataGridViewEmptyTasks";
            this.dataGridViewEmptyTasks.Size = new System.Drawing.Size(286, 337);
            this.dataGridViewEmptyTasks.TabIndex = 2;
            this.dataGridViewEmptyTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmptyTasks_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boşta Duran İşler";
            // 
            // IdleTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmptyTasks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewProjects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 537);
            this.Name = "IdleTaskForm";
            this.Text = "IdleTaskForm";
            this.Load += new System.EventHandler(this.IdleTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmptyTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewEmptyTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}