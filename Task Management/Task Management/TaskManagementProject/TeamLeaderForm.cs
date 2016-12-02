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
    public partial class TeamLeaderForm : Form
    {
        public TeamLeaderForm()
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

        private void tasklereAyırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskTakeDown.flag = false;
            FormAc<TaskTakeDown>();

        }

        private void değerlendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerRequestEvaluation>();
        }


        private void bitenTasklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<FinishedTask>();
        }

        private void projeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<ProjectListForm>();

        }

        private void müşteriDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerListForm>();
        }

        private void bostakiIslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<TaskEvaluation>();
        }

        private void talepOluşturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerRequestCreate>();
        }

        private void detaylarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<ProjectDetailsForm>();
        }

        private void formlarıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
        }
    }
}
