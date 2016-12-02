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
    public partial class CustomerRequestEvaluation : Form
    {
        CustomerRequestBLL _customerRequestBLL;
        ProjectEmployeesBLL _projectEmloyeesBLL;
        public CustomerRequestEvaluation()
        {
            InitializeComponent();
            _customerRequestBLL = new CustomerRequestBLL();
            _projectEmloyeesBLL = new ProjectEmployeesBLL();
        }

        public static Employee employee;

        public void RefreshRequest()
        {
            dgvRequests.DataSource = _customerRequestBLL.EmployeeRequest(employee.EmployeeID);
        }

        private void CustomerRequestEvaluation_Load(object sender, EventArgs e)
        {
            RefreshRequest();

        }

        private void btnAddTaskRequest_Click(object sender, EventArgs e)
        {
            try
            {
                TaskTakeDown taskTakeDown = new TaskTakeDown();
                taskTakeDown.MdiParent =  this.MdiParent;
                TaskTakeDown._requestID = (int)dgvRequests.SelectedRows[0].Cells["CustomerRequestID"].Value;
                TaskTakeDown.flag = true;
                TaskTakeDown._projectID = _customerRequestBLL.GetAll().FirstOrDefault(x => x.CustomerRequestID == (int)dgvRequests.SelectedRows[0].Cells["CustomerRequestID"].Value).ProjectID;
                taskTakeDown.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işe dönüştüreceğini isteği seçiniz!","İş Oluşturma",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void btnIgnoreRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int requestID = (int)dgvRequests.SelectedRows[0].Cells["CustomerRequestID"].Value;

                CustomerRequest customerRequest = _customerRequestBLL.Get(requestID);
                customerRequest.isActive = false;
                _customerRequestBLL.Update(customerRequest);
                RefreshRequest();
                txtDescription.Text = string.Empty;
                MessageBox.Show("İsteğin İptali Başarılı!");
            }
            catch (Exception)
            {

         
            }

           
        }

        private void dgvRequests_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                txtDescription.Text = _customerRequestBLL.Get((int)dgvRequests.SelectedRows[0].Cells["CustomerRequestID"].Value).Description;
            }
            catch (Exception)
            {

                
            }
      
        }
    }
}
