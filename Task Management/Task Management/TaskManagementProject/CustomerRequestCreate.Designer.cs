namespace TaskManagementProject
{
    partial class CustomerRequestCreate
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbError = new System.Windows.Forms.RadioButton();
            this.rdbNewRequest = new System.Windows.Forms.RadioButton();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddCustomerRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(9, 63);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(459, 162);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployess_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteriler";
            // 
            // rdbError
            // 
            this.rdbError.AutoSize = true;
            this.rdbError.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbError.Location = new System.Drawing.Point(650, 125);
            this.rdbError.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbError.Name = "rdbError";
            this.rdbError.Size = new System.Drawing.Size(55, 20);
            this.rdbError.TabIndex = 3;
            this.rdbError.Text = "Hata";
            this.rdbError.UseVisualStyleBackColor = true;
            // 
            // rdbNewRequest
            // 
            this.rdbNewRequest.AutoSize = true;
            this.rdbNewRequest.Checked = true;
            this.rdbNewRequest.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbNewRequest.Location = new System.Drawing.Point(512, 125);
            this.rdbNewRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbNewRequest.Name = "rdbNewRequest";
            this.rdbNewRequest.Size = new System.Drawing.Size(91, 20);
            this.rdbNewRequest.TabIndex = 4;
            this.rdbNewRequest.TabStop = true;
            this.rdbNewRequest.Text = "Yeni Talep";
            this.rdbNewRequest.UseVisualStyleBackColor = true;
            // 
            // dgvProjects
            // 
            this.dgvProjects.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(12, 284);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(456, 190);
            this.dgvProjects.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Projeler";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(512, 245);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(225, 178);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "";
            // 
            // btnAddCustomerRequest
            // 
            this.btnAddCustomerRequest.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomerRequest.Location = new System.Drawing.Point(574, 435);
            this.btnAddCustomerRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCustomerRequest.Name = "btnAddCustomerRequest";
            this.btnAddCustomerRequest.Size = new System.Drawing.Size(111, 39);
            this.btnAddCustomerRequest.TabIndex = 9;
            this.btnAddCustomerRequest.Text = "Gönder";
            this.btnAddCustomerRequest.UseVisualStyleBackColor = true;
            this.btnAddCustomerRequest.Click += new System.EventHandler(this.btnAddCustomerRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(509, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "İstek Tipini Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label4.Location = new System.Drawing.Point(509, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "İsteğiniz :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CustomerRequestCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCustomerRequest);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.rdbNewRequest);
            this.Controls.Add(this.rdbError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerRequestCreate";
            this.Text = "Müşteri İsteği Oluşturma Formu";
            this.Load += new System.EventHandler(this.CustomerRequestCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbError;
        private System.Windows.Forms.RadioButton rdbNewRequest;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnAddCustomerRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}