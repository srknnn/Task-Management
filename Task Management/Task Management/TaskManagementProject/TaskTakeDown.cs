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
    public partial class TaskTakeDown : Form
    {
        ProjectBLL _projectBLL;
        ProjectEmployeesBLL _projectEmployeesBLL;
        TasksBLL _taskBLL;
        Tasks _task;
        int ManagerID;
        CustomerRequestBLL _customerRequestBLL;
        public static bool flag = false;
        public static int _requestID;
        public static int _projectID;
        public static Employee employee;

         
        public TaskTakeDown()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _taskBLL = new TasksBLL();
            ManagerID = employee.EmployeeID;
            _customerRequestBLL = new CustomerRequestBLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!flag)
            {
                _task = new Tasks();
                if (string.IsNullOrWhiteSpace(txtTaskName.Text))
                {
                    errorProvider1.SetError(txtTaskName, "İş İsmi Boş Geçilemez");
                    return;
                }
                else
                {
                    _task.Name = txtTaskName.Text;
                    errorProvider1.SetError(txtTaskName, "");
                }
                if (string.IsNullOrWhiteSpace(richTxtDescription.Text))
                {
                    errorProvider1.SetError(richTxtDescription, "Açıklama Kısmı Boş Geçilemez");
                    return;
                }
                else
                {
                    _task.Description = richTxtDescription.Text;
                    errorProvider1.SetError(richTxtDescription, "");
                }


                _task.ProjectID = ProjectId;
                _task.EmployeeID = EmployeeId;
                _task.ManagerID = ManagerID;
                _task.StartDate = dateStartDate.Value.Date;
                _task.EndDate = dateEndTime.Value.Date;
                _task.StatusID = 1;

                var query = _taskBLL.GetAll().Select(x => new { x.ProjectID });

                object VarMi;
                try
                {
                    VarMi = _taskBLL.GetAll().FirstOrDefault(x => x.ProjectID == ProjectId).Name;
                }
                catch (Exception)
                {

                    VarMi = null;
                }

               

                if (VarMi == null)
                {
                    Project project = _projectBLL.Get(ProjectId);
                    project.ProjectStartDate = DateTime.Today;
                    _projectBLL.Update(project);
                }

                if (_taskBLL.Add(_task))
                {
                    MessageBox.Show("İş Oluşturulmuştur.");

                }
                else
                {
                    MessageBox.Show("İş Oluşturulamadı");
                }
            }
            else
            {
                MessageBox.Show("istekten iş oluşturma!");

                _task = new Tasks();
                if (string.IsNullOrWhiteSpace(txtTaskName.Text))
                {
                    errorProvider1.SetError(txtTaskName, "İş İsmi Boş Geçilemez");
                    return;
                }
                else
                {
                    _task.Name = txtTaskName.Text;
                    errorProvider1.SetError(txtTaskName, "");
                }
                if (string.IsNullOrWhiteSpace(richTxtDescription.Text))
                {
                    errorProvider1.SetError(richTxtDescription, "Açıklama Kısmı Boş Geçilemez");
                    return;
                }
                else
                {
                    _task.Description = richTxtDescription.Text;
                    errorProvider1.SetError(richTxtDescription, "");
                }


                _task.ProjectID = _projectID;
                _task.EmployeeID = EmployeeId;
                _task.ManagerID = ManagerID;
                _task.StartDate = dateStartDate.Value.Date;
                _task.EndDate = dateEndTime.Value.Date;
                _task.StatusID = 1;

                var query = _taskBLL.GetAll().Select(x => new { x.ProjectID });

                object VarMi;
                try
                {
                    VarMi = _taskBLL.GetAll().FirstOrDefault(x => x.ProjectID == ProjectId).Name;
                }
                catch (Exception)
                {

                    VarMi = null;
                }

                if (VarMi == null)
                {
                    Project project = _projectBLL.Get(ProjectId);
                    project.ProjectStartDate = DateTime.Today;
                    _projectBLL.Update(project);
                }

                if (_taskBLL.Add(_task))
                {
                    MessageBox.Show("İş Oluşturulmuştur");
                }
                else
                {
                    MessageBox.Show("İş Oluşturulamadı");
                }

                CustomerRequest customerRequest = _customerRequestBLL.Get(_requestID);
                customerRequest.isActive = false;
                _customerRequestBLL.Update(customerRequest);
                MessageBox.Show("İş Oluşturma Başarılı");

            }
        }

        private void TaskTakeDown_Load(object sender, EventArgs e)
        {

            if (flag)
            {
                Project project = _projectBLL.Get(_projectID);
                lblProjectName.Text = project.Name;
                lblProjectName.Visible = true;
                label1.Visible = false;
                dataGridViewProjects.Visible = false;
                CustomerRequest customerRequest = _customerRequestBLL.Get(_requestID);
                richTxtDescription.Text = customerRequest.Description;
                dataGridViewEmployee.DataSource = _projectEmployeesBLL.EmployeeAndProject(_projectID);
                dataGridViewEmployee.Columns[0].Visible = false;
                dataGridViewEmployee.Columns[1].Visible = false;
                this.Text = "İstekten İş Oluşturma";
            }
            else
            {
                object query = _projectEmployeesBLL.GetProject(employee.EmployeeID);
                dataGridViewProjects.DataSource = query;
                dataGridViewProjects.Columns[0].Visible = false;

            }

        }
        int ProjectId;
        private void dataGridViewProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProjectId = (int)dataGridViewProjects.SelectedRows[0].Cells["ProjectID"].Value;

            object query = _projectEmployeesBLL.GetEmployee(ProjectId);

            dataGridViewEmployee.DataSource = query;
            dataGridViewEmployee.Columns[0].Visible = false;
        }

        int? EmployeeId;
        private void dataGridViewEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                EmployeeId = (int)dataGridViewEmployee.SelectedRows[0].Cells["EmployeeID"].Value;
            }
            catch (Exception)
            {


            }

        }
    }
}
