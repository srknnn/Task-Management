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
    public partial class AnalyzeTask : Form
    {
        ProjectEmployeesBLL _projectEmployeesBLL;
        TasksBLL _tasksBLL;
        public static Employee employee;
        public AnalyzeTask()
        {
            InitializeComponent();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _tasksBLL = new TasksBLL();
        }

        public void GetProject()
        {
            object query =_projectEmployeesBLL.GetProjectTask(employee.EmployeeID);
            dataGridViewProjects.DataSource = query;
            dataGridViewProjects.Columns[0].Visible = false;
        }

        private void AnalyzeTask_Load(object sender, EventArgs e)
        {
            GetProject();
        }


        int ProjectId;

        public void GetTask(int ProjectID)
        {
            object query = _tasksBLL.GetTask(ProjectID,1);
            dataGridViewTask.DataSource = query;
            dataGridViewTask.Columns[0].Visible = false;
        }

        private void dataGridViewProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ProjectId = (int)dataGridViewProjects.SelectedRows[0].Cells["ProjectID"].Value;
                GetTask(ProjectId);
            }
            catch (Exception)
            {

            }

        }
        int TaskId;
        private void dataGridViewTask_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TaskId = (int)dataGridViewTask.SelectedRows[0].Cells["TaskID"].Value;
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tasks task = _tasksBLL.Get(TaskId);
                task.EmployeeID = employee.EmployeeID;
                task.StatusID = 3;
                if (_tasksBLL.Update(task))
                {
                    GetProject();
                    GetTask(ProjectId);
                    MessageBox.Show("İş Analiz Edilmiş Üzerinize Alınmıştır. İşin Yeni durumu Geliştirilecek olup Yazılım Geliştiriciler Artık İşe Müdahale edebilir.");

                }
                else
                {
                    MessageBox.Show("İş Üzerinize Alınamayıp Durumu Değiştirilememiştir!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
