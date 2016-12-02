namespace TaskManagementProject
{
    partial class TeamLeaderForm
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
            this.projelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklereAyırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bostakiIslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitenTasklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTalepleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değerlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talepOluşturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formlarıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projelerToolStripMenuItem,
            this.tasklarToolStripMenuItem,
            this.müşteriTalepleriToolStripMenuItem,
            this.formlarıKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projelerToolStripMenuItem
            // 
            this.projelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasklereAyırToolStripMenuItem,
            this.projeleriGörüntüleToolStripMenuItem,
            this.detaylarıGörüntüleToolStripMenuItem});
            this.projelerToolStripMenuItem.Name = "projelerToolStripMenuItem";
            this.projelerToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.projelerToolStripMenuItem.Text = "Projeler";
            // 
            // tasklereAyırToolStripMenuItem
            // 
            this.tasklereAyırToolStripMenuItem.Name = "tasklereAyırToolStripMenuItem";
            this.tasklereAyırToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tasklereAyırToolStripMenuItem.Text = "Task\'lere Ayır";
            this.tasklereAyırToolStripMenuItem.Click += new System.EventHandler(this.tasklereAyırToolStripMenuItem_Click);
            // 
            // projeleriGörüntüleToolStripMenuItem
            // 
            this.projeleriGörüntüleToolStripMenuItem.Name = "projeleriGörüntüleToolStripMenuItem";
            this.projeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.projeleriGörüntüleToolStripMenuItem.Text = "Projeyi Bitir";
            this.projeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.projeleriGörüntüleToolStripMenuItem_Click);
            // 
            // detaylarıGörüntüleToolStripMenuItem
            // 
            this.detaylarıGörüntüleToolStripMenuItem.Name = "detaylarıGörüntüleToolStripMenuItem";
            this.detaylarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.detaylarıGörüntüleToolStripMenuItem.Text = "Detayları Görüntüle";
            this.detaylarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.detaylarıGörüntüleToolStripMenuItem_Click);
            // 
            // tasklarToolStripMenuItem
            // 
            this.tasklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bostakiIslerToolStripMenuItem,
            this.bitenTasklarToolStripMenuItem});
            this.tasklarToolStripMenuItem.Name = "tasklarToolStripMenuItem";
            this.tasklarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tasklarToolStripMenuItem.Text = "Tasklar";
            // 
            // bostakiIslerToolStripMenuItem
            // 
            this.bostakiIslerToolStripMenuItem.Name = "bostakiIslerToolStripMenuItem";
            this.bostakiIslerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bostakiIslerToolStripMenuItem.Text = "Boştaki işler";
            this.bostakiIslerToolStripMenuItem.Click += new System.EventHandler(this.bostakiIslerToolStripMenuItem_Click);
            // 
            // bitenTasklarToolStripMenuItem
            // 
            this.bitenTasklarToolStripMenuItem.Name = "bitenTasklarToolStripMenuItem";
            this.bitenTasklarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bitenTasklarToolStripMenuItem.Text = "Biten Tasklar";
            this.bitenTasklarToolStripMenuItem.Click += new System.EventHandler(this.bitenTasklarToolStripMenuItem_Click);
            // 
            // müşteriTalepleriToolStripMenuItem
            // 
            this.müşteriTalepleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.değerlendirmeToolStripMenuItem,
            this.müşteriDetaylarıToolStripMenuItem,
            this.talepOluşturmaToolStripMenuItem});
            this.müşteriTalepleriToolStripMenuItem.Name = "müşteriTalepleriToolStripMenuItem";
            this.müşteriTalepleriToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.müşteriTalepleriToolStripMenuItem.Text = "Müşteri Talepleri";
            // 
            // değerlendirmeToolStripMenuItem
            // 
            this.değerlendirmeToolStripMenuItem.Name = "değerlendirmeToolStripMenuItem";
            this.değerlendirmeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.değerlendirmeToolStripMenuItem.Text = "Değerlendirme";
            this.değerlendirmeToolStripMenuItem.Click += new System.EventHandler(this.değerlendirmeToolStripMenuItem_Click);
            // 
            // müşteriDetaylarıToolStripMenuItem
            // 
            this.müşteriDetaylarıToolStripMenuItem.Name = "müşteriDetaylarıToolStripMenuItem";
            this.müşteriDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.müşteriDetaylarıToolStripMenuItem.Text = "Müşteri Detayları";
            this.müşteriDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.müşteriDetaylarıToolStripMenuItem_Click);
            // 
            // talepOluşturmaToolStripMenuItem
            // 
            this.talepOluşturmaToolStripMenuItem.Name = "talepOluşturmaToolStripMenuItem";
            this.talepOluşturmaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.talepOluşturmaToolStripMenuItem.Text = "Talep Oluşturma";
            this.talepOluşturmaToolStripMenuItem.Click += new System.EventHandler(this.talepOluşturmaToolStripMenuItem_Click);
            // 
            // formlarıKapatToolStripMenuItem
            // 
            this.formlarıKapatToolStripMenuItem.Name = "formlarıKapatToolStripMenuItem";
            this.formlarıKapatToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.formlarıKapatToolStripMenuItem.Text = "Formları Kapat";
            this.formlarıKapatToolStripMenuItem.Click += new System.EventHandler(this.formlarıKapatToolStripMenuItem_Click);
            // 
            // TeamLeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 470);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeamLeaderForm";
            this.Text = "Takım Lideri Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasklereAyırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bostakiIslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTalepleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değerlendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitenTasklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriDetaylarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talepOluşturmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaylarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formlarıKapatToolStripMenuItem;
    }
}