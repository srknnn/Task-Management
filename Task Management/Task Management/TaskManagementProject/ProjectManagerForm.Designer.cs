namespace TaskManagementProject
{
    partial class ProjectManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projeYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeyiBitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKaydıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müştelerileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanKaydıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boştakiİşlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formlarıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeYönetimiToolStripMenuItem,
            this.müşteriYönetimiToolStripMenuItem,
            this.çalışanYönetimiToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.formlarıKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projeYönetimiToolStripMenuItem
            // 
            this.projeYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeOluşturToolStripMenuItem,
            this.projeleriListeleToolStripMenuItem,
            this.projeyiBitirToolStripMenuItem});
            this.projeYönetimiToolStripMenuItem.Name = "projeYönetimiToolStripMenuItem";
            this.projeYönetimiToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.projeYönetimiToolStripMenuItem.Text = "Proje Yönetimi";
            // 
            // projeOluşturToolStripMenuItem
            // 
            this.projeOluşturToolStripMenuItem.Name = "projeOluşturToolStripMenuItem";
            this.projeOluşturToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projeOluşturToolStripMenuItem.Text = "Proje Kaydı Oluştur";
            this.projeOluşturToolStripMenuItem.Click += new System.EventHandler(this.projeOluşturToolStripMenuItem_Click);
            // 
            // projeleriListeleToolStripMenuItem
            // 
            this.projeleriListeleToolStripMenuItem.Name = "projeleriListeleToolStripMenuItem";
            this.projeleriListeleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projeleriListeleToolStripMenuItem.Text = "Projeleri Listele ";
            this.projeleriListeleToolStripMenuItem.Click += new System.EventHandler(this.projeleriListeleToolStripMenuItem_Click);
            // 
            // projeyiBitirToolStripMenuItem
            // 
            this.projeyiBitirToolStripMenuItem.Name = "projeyiBitirToolStripMenuItem";
            this.projeyiBitirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projeyiBitirToolStripMenuItem.Text = "Projeyi Bitir";
            this.projeyiBitirToolStripMenuItem.Click += new System.EventHandler(this.projeyiBitirToolStripMenuItem_Click);
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriKaydıOluşturToolStripMenuItem,
            this.müştelerileriListeleToolStripMenuItem});
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            // 
            // müşteriKaydıOluşturToolStripMenuItem
            // 
            this.müşteriKaydıOluşturToolStripMenuItem.Name = "müşteriKaydıOluşturToolStripMenuItem";
            this.müşteriKaydıOluşturToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.müşteriKaydıOluşturToolStripMenuItem.Text = "Müşteri Kaydı Oluştur";
            this.müşteriKaydıOluşturToolStripMenuItem.Click += new System.EventHandler(this.müşteriKaydıOluşturToolStripMenuItem_Click);
            // 
            // müştelerileriListeleToolStripMenuItem
            // 
            this.müştelerileriListeleToolStripMenuItem.Name = "müştelerileriListeleToolStripMenuItem";
            this.müştelerileriListeleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.müştelerileriListeleToolStripMenuItem.Text = "Müştelerileri Listele";
            this.müştelerileriListeleToolStripMenuItem.Click += new System.EventHandler(this.müştelerileriListeleToolStripMenuItem_Click);
            // 
            // çalışanYönetimiToolStripMenuItem
            // 
            this.çalışanYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanKaydıOluşturToolStripMenuItem,
            this.çalışanlarıListeleToolStripMenuItem});
            this.çalışanYönetimiToolStripMenuItem.Name = "çalışanYönetimiToolStripMenuItem";
            this.çalışanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.çalışanYönetimiToolStripMenuItem.Text = "Çalışan Yönetimi";
            // 
            // çalışanKaydıOluşturToolStripMenuItem
            // 
            this.çalışanKaydıOluşturToolStripMenuItem.Name = "çalışanKaydıOluşturToolStripMenuItem";
            this.çalışanKaydıOluşturToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.çalışanKaydıOluşturToolStripMenuItem.Text = "Çalışan Kaydı Oluştur";
            this.çalışanKaydıOluşturToolStripMenuItem.Click += new System.EventHandler(this.çalışanKaydıOluşturToolStripMenuItem_Click);
            // 
            // çalışanlarıListeleToolStripMenuItem
            // 
            this.çalışanlarıListeleToolStripMenuItem.Name = "çalışanlarıListeleToolStripMenuItem";
            this.çalışanlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.çalışanlarıListeleToolStripMenuItem.Text = "Çalışanları Listele";
            this.çalışanlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarıListeleToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boştakiİşlerToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // boştakiİşlerToolStripMenuItem
            // 
            this.boştakiİşlerToolStripMenuItem.Name = "boştakiİşlerToolStripMenuItem";
            this.boştakiİşlerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.boştakiİşlerToolStripMenuItem.Text = "Boştaki İşler";
            this.boştakiİşlerToolStripMenuItem.Click += new System.EventHandler(this.boştakiİşlerToolStripMenuItem_Click);
            // 
            // formlarıKapatToolStripMenuItem
            // 
            this.formlarıKapatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formlarıKapatToolStripMenuItem.Name = "formlarıKapatToolStripMenuItem";
            this.formlarıKapatToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.formlarıKapatToolStripMenuItem.Text = "Formları Kapat";
            this.formlarıKapatToolStripMenuItem.Click += new System.EventHandler(this.formlarıKapatToolStripMenuItem_Click);
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectManagerForm";
            this.Text = "Proje Yöneticisi Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projeYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKaydıOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanKaydıOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müştelerileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boştakiİşlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeyiBitirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formlarıKapatToolStripMenuItem;
    }
}

