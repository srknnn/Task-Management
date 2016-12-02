namespace TaskManagementProject
{
    partial class CustomerRequestEvaluation
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
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTaskRequest = new System.Windows.Forms.Button();
            this.btnIgnoreRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequests
            // 
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(0, 1);
            this.dgvRequests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowTemplate.Height = 24;
            this.dgvRequests.Size = new System.Drawing.Size(537, 499);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequests_CellMouseClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(566, 85);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 189);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Açıklama";
            // 
            // btnAddTaskRequest
            // 
            this.btnAddTaskRequest.Location = new System.Drawing.Point(604, 301);
            this.btnAddTaskRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTaskRequest.Name = "btnAddTaskRequest";
            this.btnAddTaskRequest.Size = new System.Drawing.Size(224, 37);
            this.btnAddTaskRequest.TabIndex = 3;
            this.btnAddTaskRequest.Text = "İş Olarak Ata";
            this.btnAddTaskRequest.UseVisualStyleBackColor = true;
            this.btnAddTaskRequest.Click += new System.EventHandler(this.btnAddTaskRequest_Click);
            // 
            // btnIgnoreRequest
            // 
            this.btnIgnoreRequest.Location = new System.Drawing.Point(604, 374);
            this.btnIgnoreRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIgnoreRequest.Name = "btnIgnoreRequest";
            this.btnIgnoreRequest.Size = new System.Drawing.Size(224, 41);
            this.btnIgnoreRequest.TabIndex = 4;
            this.btnIgnoreRequest.Text = "Yok Say";
            this.btnIgnoreRequest.UseVisualStyleBackColor = true;
            this.btnIgnoreRequest.Click += new System.EventHandler(this.btnIgnoreRequest_Click);
            // 
            // CustomerRequestEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 500);
            this.Controls.Add(this.btnIgnoreRequest);
            this.Controls.Add(this.btnAddTaskRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvRequests);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(908, 538);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(908, 538);
            this.Name = "CustomerRequestEvaluation";
            this.Text = "Müşteri İstek Değerlendirme Formu";
            this.Load += new System.EventHandler(this.CustomerRequestEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTaskRequest;
        private System.Windows.Forms.Button btnIgnoreRequest;
    }
}