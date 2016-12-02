using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagementProject
{
    public partial class SoftwareDeveloperForm : Form
    {
        public SoftwareDeveloperForm()
        {
            InitializeComponent();
        }

        public void FormAc<T>() where T : Form, new()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is T)
                {
                    frm.BringToFront();
                    return;
                }

            }

            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        private void boştaDuranİşlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<IdleTaskForm>();
        }

        private void işlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<TaskForm>();
        }
    }
}
