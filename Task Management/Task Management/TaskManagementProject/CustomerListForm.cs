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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            _customerBLL = new CustomerBLL();
            InitializeComponent();
        }

        private CustomerBLL _customerBLL;

        public void GetCustomers()
        {
            dataGridView1.DataSource = _customerBLL.GetAll().Select(x => new
            {
                x.CustomerID,
                x.ContactName,
                x.CompanyName,
                x.Address,
                x.Email,
                x.Phone,

            }).ToList();

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = (int) dataGridView1.SelectedRows[0].Cells["CustomerID"].Value;
            _customerBLL.Remove(_customerBLL.Get(customer.CustomerID));
            dataGridView1.DataSource = _customerBLL.GetAll();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerEditForm customerEditForm = new CustomerEditForm();

                CustomerEditForm.id = (int)dataGridView1.SelectedRows[0].Cells["CustomerID"].Value;
                CustomerEditForm.choice = true;
                customerEditForm.MdiParent = this.MdiParent;
                customerEditForm.Show();
            }
            catch (Exception)
            {
                    
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCustomerSearch.Text) || string.IsNullOrWhiteSpace(txtCustomerSearch.Text))
            {
                _customerBLL.GetAll();


            }
            var search = _customerBLL.GetAll().Where(x => x.CompanyName.ToLower().Contains(txtCustomerSearch.Text.ToLower())).OrderByDescending(x => x.CompanyName).ToList();

            dataGridView1.DataSource = search;
        }
    }
}
