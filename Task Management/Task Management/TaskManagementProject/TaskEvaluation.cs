using _01_BusinessLayer.BusinessLogicLayer;
using _01_Entities;
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
    public partial class TaskEvaluation : Form
    {
        ProjectEmployeesBLL _projectEmployeesBLL;
        TasksBLL _tasksBLL;
        //ProjectBLL _projectBLL;
        public TaskEvaluation()
        {
            InitializeComponent();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _tasksBLL = new TasksBLL();
        }
        public static Employee employee;

        public void GetProjects()
        {
            object query = _projectEmployeesBLL.GetProject(employee.EmployeeID);
            dgvProjects.DataSource = query;
            dgvProjects.Columns[0].Visible = false;
        }
        private void TaskEvaluation_Load(object sender, EventArgs e)
        {
            GetProjects();

            if (employee.EmployeeType.EmployeeTypeID != 2)
            {
                lbl1.Visible = false;
                btnUpdate.Visible = false;
                rdbBeDeveloped.Visible = false;
                rdbTest.Visible = false;
            }

        }

        private void dgvProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int ProjectId = (int)dgvProjects.SelectedRows[0].Cells["ProjectID"].Value;

                object query = _tasksBLL.GetTask(ProjectId, 1);
                dgvIdleTask.DataSource = query;
                dgvIdleTask.Columns[0].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int idleTaskID = (int)dgvIdleTask.SelectedRows[0].Cells["TaskID"].Value;

                int status = rdbBeDeveloped.Checked == true ? 2 : 3;

                Tasks tasks = _tasksBLL.Get(idleTaskID);
                tasks.StatusID = status;
                if (_tasksBLL.Update(tasks))
                {
                    GetProjects();
                    MessageBox.Show("İşin Durumu Güncellenmiştir");
                }
                else
                {
                    MessageBox.Show("İşin Durumu Güncellenememiştir!");
                }

            }
            catch (Exception)
            {

            }


        }
    }
}
