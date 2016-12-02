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
    public partial class ProjectListForm : Form
    {
        ProjectEmployeesBLL _projectEmployeesBLL;
        public static Employee _employee;
        ProjectBLL _projectBLL;
       
        public ProjectListForm()
        {
            InitializeComponent();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _projectBLL = new ProjectBLL();
           
        }

        private void ProjectListForm_Load(object sender, EventArgs e)
        {
            ProjectsList();
        }

        void ProjectsList()
        {
            object query = _projectEmployeesBLL.GetProject(_employee.EmployeeID);
            dataGridViewProjects.DataSource = query;
            dataGridViewProjects.Columns[0].Visible = false;
        }
        int ProjectId;
        private void dataGridViewProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ProjectId = (int)dataGridViewProjects.SelectedRows[0].Cells["ProjectID"].Value;
                object query = _projectEmployeesBLL.GetEmployee(ProjectId);

                dataGridViewEmployees.DataSource = query;
                dataGridViewEmployees.Columns[0].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = _projectBLL.Get(ProjectId);
                project.isActive = false;
                project.ProjectFinishDate = DateTime.Now;
                if (_projectBLL.Update(project))
                {
           
                    MessageBox.Show("Proje Kapanmıştır. Artık Aktif Değildir.");
                    ProjectsList();
                   
                }
                else
                {
                    MessageBox.Show("Proje Kapanamamıştır. Hala Aktiftir!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
