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
    public partial class EmployeeLoginForm : Form
    {
        EmployeeBLL _employeeBLL;

        public EmployeeLoginForm()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEMail.Text))
                {
                    errorProvider.SetError(txtEMail, "Mail Alanı Boş Geçilemez!");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtEMail, "");
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider.SetError(txtPassword, "Şifre Alanı Boş Geçilemez!");
                    return;
                }
                else
                {
                    errorProvider.SetError(txtPassword, "");
                }

                Employee employee = _employeeBLL.Get(txtEMail.Text, txtPassword.Text);
                //Employee Employee = _employeeBLL.GetEmployee(txtEMail.Text);
                //MessageBox.Show(employee.FirstName);
                ProjectEditForm.employee = employee;
                CustomerRequestCreate.employee = employee;
                CustomerRequestEvaluation.employee = employee;
                TaskTakeDown.employee = employee;
                AnalyzeTask.employee = employee;
                TaskEvaluation.employee = employee;
                ProjectDetailsForm.employee = employee;
                ProjectListForm._employee = employee;
                IdleTaskForm._employee = employee;
                FinishedTask._employee = employee;
                TesterForm._employee = employee;
                TaskForm._employee = employee;

                if (employee.EmployeeType.EmployeeTypeID == 1)
                {
                    ProjectManagerForm projectManagerForm = new ProjectManagerForm();
                    projectManagerForm.Size = this.Size;
                    projectManagerForm.WindowState = FormWindowState.Maximized;
                    projectManagerForm.Show();
                    this.Hide();
                }
                else if (employee.EmployeeType.EmployeeTypeID == 2)
                {
                    TeamLeaderForm teamLeaderForm = new TeamLeaderForm();
                    teamLeaderForm.Size = this.Size;
                    teamLeaderForm.WindowState = FormWindowState.Maximized;
                    teamLeaderForm.Show();
                    this.Hide();
                }
                else if (employee.EmployeeType.EmployeeTypeID == 3)
                {
                    BusinessAnalystForm businessAnalystForm = new BusinessAnalystForm();
                    businessAnalystForm.Size = this.Size;
                    businessAnalystForm.WindowState = FormWindowState.Maximized;
                    businessAnalystForm.Show();
                    this.Hide();
                }
                else if (employee.EmployeeType.EmployeeTypeID == 4)
                {
                    TesterForm testerForm = new TesterForm();
                    testerForm.Size = this.Size;
                    testerForm.WindowState = FormWindowState.Maximized;
                    testerForm.Show();
                    this.Hide();
                }
                else if (employee.EmployeeType.EmployeeTypeID == 5)
                {
                    SoftwareDeveloperForm softwareDeveloperForm = new SoftwareDeveloperForm();
                    softwareDeveloperForm.Size = this.Size;
                    softwareDeveloperForm.WindowState = FormWindowState.Maximized;
                    softwareDeveloperForm.Show();
                    this.Hide();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
