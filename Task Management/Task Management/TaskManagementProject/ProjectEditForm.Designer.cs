namespace TaskManagementProject
{
    partial class ProjectEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.dateRequedEnd = new System.Windows.Forms.DateTimePicker();
            this.btnProjectCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.dateRequedStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstProjectEmployees = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklaması :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "İstenen Bitiş Tarihi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(469, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Projedeki Çalışanlar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(70, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Müşteri :";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjectName.Location = new System.Drawing.Point(131, 104);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(291, 23);
            this.txtProjectName.TabIndex = 8;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(131, 56);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(293, 24);
            this.cmbCustomer.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(131, 244);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(291, 241);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "";
            // 
            // dateRequedEnd
            // 
            this.dateRequedEnd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateRequedEnd.Location = new System.Drawing.Point(131, 202);
            this.dateRequedEnd.Name = "dateRequedEnd";
            this.dateRequedEnd.Size = new System.Drawing.Size(291, 23);
            this.dateRequedEnd.TabIndex = 15;
            // 
            // btnProjectCreate
            // 
            this.btnProjectCreate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjectCreate.Location = new System.Drawing.Point(263, 514);
            this.btnProjectCreate.Name = "btnProjectCreate";
            this.btnProjectCreate.Size = new System.Drawing.Size(427, 35);
            this.btnProjectCreate.TabIndex = 17;
            this.btnProjectCreate.Text = "Projeyi Oluştur";
            this.btnProjectCreate.UseVisualStyleBackColor = true;
            this.btnProjectCreate.Click += new System.EventHandler(this.btnProjectCreate_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(469, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Çalışan Tipi : ";
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Location = new System.Drawing.Point(553, 56);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(251, 24);
            this.cmbEmployeeType.TabIndex = 19;
            this.cmbEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeType_SelectedIndexChanged);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeAdd.Location = new System.Drawing.Point(472, 246);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(331, 27);
            this.btnEmployeeAdd.TabIndex = 20;
            this.btnEmployeeAdd.Text = "Ekle";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(472, 113);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(332, 112);
            this.lstEmployees.TabIndex = 21;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(472, 457);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(331, 27);
            this.btnDeleteEmployee.TabIndex = 22;
            this.btnDeleteEmployee.Text = "Çıkar";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dateRequedStart
            // 
            this.dateRequedStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateRequedStart.Location = new System.Drawing.Point(131, 154);
            this.dateRequedStart.Name = "dateRequedStart";
            this.dateRequedStart.Size = new System.Drawing.Size(290, 23);
            this.dateRequedStart.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "İstenen Bitiş Tarihi :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(469, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Çalışanlar : ";
            // 
            // lstProjectEmployees
            // 
            this.lstProjectEmployees.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lstProjectEmployees.FormattingEnabled = true;
            this.lstProjectEmployees.Location = new System.Drawing.Point(472, 306);
            this.lstProjectEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstProjectEmployees.Name = "lstProjectEmployees";
            this.lstProjectEmployees.Size = new System.Drawing.Size(332, 130);
            this.lstProjectEmployees.TabIndex = 26;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 560);
            this.Controls.Add(this.lstProjectEmployees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateRequedStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.cmbEmployeeType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnProjectCreate);
            this.Controls.Add(this.dateRequedEnd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 598);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 598);
            this.Name = "ProjectEditForm";
            this.Text = "Proje Ekleme ";
            this.Load += new System.EventHandler(this.ProjectEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateRequedEnd;
        private System.Windows.Forms.Button btnProjectCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.CheckedListBox lstEmployees;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.DateTimePicker dateRequedStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox lstProjectEmployees;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}