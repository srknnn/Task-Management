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
    public partial class CustomerRequestCreate : Form
    {
        ProjectBLL _projectBLL;
        EmployeeBLL _employeeBLL;
        CustomerBLL _customerBLL;
        ProjectEmployeesBLL _projectEmployeesBLL;
        CustomerRequestBLL _customerRequestBLL;
        public CustomerRequestCreate()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _employeeBLL = new EmployeeBLL();
            _customerBLL = new CustomerBLL();
            _projectEmployeesBLL = new ProjectEmployeesBLL();
            _customerRequestBLL = new CustomerRequestBLL();
        }


        public static Employee employee;
        private void dgvEmployess_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int customerID = (int)dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value;
                dgvProjects.DataSource = _projectBLL.CustomerList(customerID);
            }
            catch (Exception)
            {


            }

        }

        private void CustomerRequestCreate_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = _projectEmployeesBLL.GetEmployeeCustomer(employee.EmployeeID);
        }

        private void btnAddCustomerRequest_Click(object sender, EventArgs e)
        {
            CustomerRequest customerRequest = new CustomerRequest();

            try
            {
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    errorProvider.SetError(txtDescription, "Lütfen Açıklama Kısmını Boş Geçmeyiniz.");
                    return;
                }else
                {
                    customerRequest.Description = txtDescription.Text;
                    errorProvider.SetError(txtDescription, "");
                }
                
                customerRequest.EmployeeID = employee.EmployeeID;
                customerRequest.isActive = true;
                customerRequest.ProjectID = (int)dgvProjects.SelectedRows[0].Cells["ProjectID"].Value;
                customerRequest.RequestDate = DateTime.Now;
                customerRequest.RequestType = rdbNewRequest.Checked == true ? false : true;

                _customerRequestBLL.Add(customerRequest);

                MessageBox.Show("Müşteri Talebi Eklendi!", "Müşteri İstek Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri Talebi Eklenemedi!\n\nLütfen bir müşteri seçip ardından bir proje seçiniz!","Müşteri İstek Formu",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }
        }
    }
}
