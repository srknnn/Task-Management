namespace TaskManagementProject
{
    partial class TaskTakeDown
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
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblProjectName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewProjects.Location = new System.Drawing.Point(10, 64);
            this.dataGridViewProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.RowTemplate.Height = 24;
            this.dataGridViewProjects.Size = new System.Drawing.Size(284, 455);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProjects_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projenizi Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İş Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Açıklama : ";
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(423, 454);
            this.dateStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(195, 20);
            this.dateStartDate.TabIndex = 4;
            // 
            // dateEndTime
            // 
            this.dateEndTime.Location = new System.Drawing.Point(423, 502);
            this.dateEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(195, 20);
            this.dateEndTime.TabIndex = 5;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(419, 71);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(220, 20);
            this.txtTaskName.TabIndex = 6;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(419, 300);
            this.richTxtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(317, 142);
            this.richTxtDescription.TabIndex = 7;
            this.richTxtDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 454);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Başlangıç Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 506);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bitiş Tarihi : ";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(419, 134);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(317, 154);
            this.dataGridViewEmployee.TabIndex = 10;
            this.dataGridViewEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployee_CellMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Çalışanlar:";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(639, 527);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(97, 31);
            this.btnCreateTask.TabIndex = 12;
            this.btnCreateTask.Text = "Oluştur";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.Location = new System.Drawing.Point(416, 16);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(46, 16);
            this.lblProjectName.TabIndex = 14;
            this.lblProjectName.Text = "label8";
            this.lblProjectName.Visible = false;
            // 
            // TaskTakeDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 569);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.dateEndTime);
            this.Controls.Add(this.dateStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProjects);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(763, 607);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(763, 607);
            this.Name = "TaskTakeDown";
            this.Text = "İş Atama Formu";
            this.Load += new System.EventHandler(this.TaskTakeDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblProjectName;
    }
}