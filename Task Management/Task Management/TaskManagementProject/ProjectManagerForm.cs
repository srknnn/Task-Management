﻿using System;
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
    public partial class ProjectManagerForm : Form
    {
      
        public ProjectManagerForm()
        {
            InitializeComponent();
        }

        public void FormAc<T>()where T : Form,new()
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


        private void projeOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<ProjectEditForm>();
        }

        private void müşteriKaydıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerEditForm>();
        }

        private void çalışanKaydıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAc<EmployeeEditForm>();

        }

        private void projeleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAc<ProjectDetailsForm>();
        }

        private void müştelerileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<CustomerListForm>();

        }


        private void çalışanlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<EmployeeListForm>();
        }


        private void boştakiİşlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc<TaskEvaluation>();
        }

        private void projeyiBitirToolStripMenuItem_Click(object sender, EventArgs e)
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
