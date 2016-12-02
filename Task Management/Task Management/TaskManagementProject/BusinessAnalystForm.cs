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
    public partial class BusinessAnalystForm : Form
    {
        public BusinessAnalystForm()
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
        private void değerlendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerRequestEvaluation>();
           
        }

        private void taskOluşturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAc<TaskTakeDown>();
           
        }

        private void boştakiİşlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<TaskEvaluation>();
        }

        private void taskAnalizEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<AnalyzeTask>();        
        }


        private void müşteriDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerListForm>();        
        }

        private void talepKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerRequestCreate>();
        }

        private void projeDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<ProjectDetailsForm>();
        }

        private void projeAnalizEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<ProjectListForm>();
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
