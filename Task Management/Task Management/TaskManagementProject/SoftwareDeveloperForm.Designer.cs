namespace TaskManagementProject
{
    partial class SoftwareDeveloperForm
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
            this.işleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boştaDuranİşlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işleriGörüntüleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işleriGörüntüleToolStripMenuItem
            // 
            this.işleriGörüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boştaDuranİşlerToolStripMenuItem,
            this.işlerimToolStripMenuItem});
            this.işleriGörüntüleToolStripMenuItem.Name = "işleriGörüntüleToolStripMenuItem";
            this.işleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.işleriGörüntüleToolStripMenuItem.Text = "İşleri Görüntüle";
            // 
            // boştaDuranİşlerToolStripMenuItem
            // 
            this.boştaDuranİşlerToolStripMenuItem.Name = "boştaDuranİşlerToolStripMenuItem";
            this.boştaDuranİşlerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.boştaDuranİşlerToolStripMenuItem.Text = "Boşta Duran İşler";
            this.boştaDuranİşlerToolStripMenuItem.Click += new System.EventHandler(this.boştaDuranİşlerToolStripMenuItem_Click);
            // 
            // işlerimToolStripMenuItem
            // 
            this.işlerimToolStripMenuItem.Name = "işlerimToolStripMenuItem";
            this.işlerimToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.işlerimToolStripMenuItem.Text = "İşlerim";
            this.işlerimToolStripMenuItem.Click += new System.EventHandler(this.işlerimToolStripMenuItem_Click);
            // 
            // SoftwareDeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 533);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SoftwareDeveloperForm";
            this.Text = "Yazılım Geliştirici Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boştaDuranİşlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlerimToolStripMenuItem;
    }
}