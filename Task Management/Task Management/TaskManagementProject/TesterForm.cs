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
    public partial class TesterForm : Form
    {
        private ProjectEmployeesBLL _projectEmployeesBLL;
        private TasksBLL _tasksBLL;
        public static Employee _employee;
        public TesterForm()
        {
            InitializeComponent();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _tasksBLL = new TasksBLL();

        }

        private void TesterForm_Load(object sender, EventArgs e)
        {

            object query = _projectEmployeesBLL.GetProject(_employee.EmployeeID);
            dgvTesterProjects.DataSource = query;

        }

        private int _projectId;
        private void dgvTesterProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
              _projectId= (int)dgvTesterProjects.SelectedRows[0].Cells["ProjectID"].Value;

                var query = _tasksBLL.GetTask(_projectId, 3);
                dgvProjectsStatus.DataSource = query;
                dgvProjectsStatus.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                Tasks task = _tasksBLL.Get(TaskId);
                task.StatusID = 2;
                if (_tasksBLL.Update(task))
                {

                    MessageBox.Show("Hatalı İş Yazılım Geliştirme Departmanına Yollandı.");


                }
                else
                {
                    MessageBox.Show("İş Yazılım Geliştirme Tarafına Yollanamadı.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int TaskId;
        private void dgvProjectsStatus_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TaskId = (int)dgvProjectsStatus.SelectedRows[0].Cells["TaskID"].Value;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                Tasks task = _tasksBLL.Get(TaskId);
                task.StatusID = 4;
                if (_tasksBLL.Update(task))
                {

                    MessageBox.Show("Bitirilen İş Değerlendirilmek Üzere Takım Liderine Aktarıldı.");
                }
                else
                {
                    MessageBox.Show("Takım Liderine Aktarılamadı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
