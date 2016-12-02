using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_BusinessLayer.BusinessLogicLayer;
using _01_Entities;

namespace TaskManagementProject
{
    public partial class TaskForm : Form
    {
        private ProjectEmployeesBLL _projectEmployeesBll;
        private TasksBLL _tasksBll;
        public static Employee _employee;
        public TaskForm()
        {
            _projectEmployeesBll = new ProjectEmployeesBLL();
            _tasksBll = new TasksBLL();
            InitializeComponent();
        }
  
        private void TaskForm_Load(object sender, EventArgs e)
        {
            object query = _projectEmployeesBll.GetProject(_employee.EmployeeID);
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].Visible = false;
        }

        private int projectId;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                projectId = (int)dataGridView1.SelectedRows[0].Cells["ProjectID"].Value;

                object query = _tasksBll.GetTask(projectId, 2);

                dataGridView2.DataSource = query;
                dataGridView2.Columns[0].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnFinishedTask_Click(object sender, EventArgs e)
        {
            try
            {
                Tasks task = _tasksBll.Get(TaskId);
                task.StatusID = 3;
                if (_tasksBll.Update(task))
                {

                    MessageBox.Show("Bitirilen İş Değerlendirilmek Üzere Testera Gönderildi");


                }
                else
                {
                    MessageBox.Show("İş Testera Aktarılamadı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int TaskId;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TaskId = (int)dataGridView2.SelectedRows[0].Cells["TaskID"].Value;
            }
            catch (Exception)
            {

           
            }

           
        }
    }
}
