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
    public partial class ProjectDetailsForm : Form
    {
        private ProjectEmployeesBLL _projectEmployeesBLL;
        private EmployeeBLL _employeeBLL;
        //private ProjectBLL _projectBLL;
        public static Employee employee;
        public ProjectDetailsForm()
        {
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _employeeBLL = new EmployeeBLL();
            InitializeComponent();
        }

        private void GetProjects()
        {
            object query = _projectEmployeesBLL.GetProject(employee.EmployeeID);
            dataGridView1.DataSource = query;
        }

        private void ProjectDetailsForm_Load(object sender, EventArgs e)
        {
           GetProjects();
        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchProjects.Text) || string.IsNullOrWhiteSpace(txtSearchProjects.Text))
            {
                
                GetProjects();

            }
            var search = _projectEmployeesBLL.GetAll().Where(x =>x.EmployeeID==employee.EmployeeID && x.project.Name.ToLower().Contains(txtSearchProjects.Text.ToLower())).Select(x=>new
            {
                x.project.Name,

                x.project.Description


            }).OrderByDescending(x => x.Name).ToList();

            dataGridView1.DataSource = search;
        }
    }
}
