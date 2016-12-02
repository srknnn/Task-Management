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
    public partial class IdleTaskForm : Form
    {
        ProjectEmployeesBLL _projectEmployeesBLL;
        public static Employee _employee;
        TasksBLL _taskBLL;
        public IdleTaskForm()
        {
            InitializeComponent();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _taskBLL = new TasksBLL();
        }

        private void IdleTaskForm_Load(object sender, EventArgs e)
        {
            object  query = _projectEmployeesBLL.GetProjectTask(_employee.EmployeeID);
            dataGridViewProjects.DataSource = query;
            dataGridViewProjects.Columns[0].Visible = false;
        }
        int ProjectId;
        private void dataGridViewProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ProjectId = (int)dataGridViewProjects.SelectedRows[0].Cells["ProjectID"].Value;

                object query = _taskBLL.GetIdleTask(ProjectId, 2);

                dataGridViewEmptyTasks.DataSource = query;
                dataGridViewEmptyTasks.Columns[0].Visible = false;
            }
            catch (Exception)
            {

            }
        }
        int TaskId;
        private void dataGridViewEmptyTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaskId = (int)dataGridViewEmptyTasks.SelectedRows[0].Cells["TaskID"].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tasks task = _taskBLL.Get(TaskId);
                task.EmployeeID = _employee.EmployeeID;
                if (_taskBLL.Update(task))
                {

                    MessageBox.Show("İşi Üstünüze Aldınız.");
                  

                }
                else
                {
                    MessageBox.Show("İşi Üstünüze alamadınız!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
