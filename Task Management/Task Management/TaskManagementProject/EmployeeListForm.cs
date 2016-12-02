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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            _employeeBLL = new EmployeeBLL();

            InitializeComponent();
        }
        
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeID = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;
            _employeeBLL.Remove(_employeeBLL.Get(employee.EmployeeID));
            dataGridView1.DataSource = _employeeBLL.GetAll();
        }

        EmployeeBLL _employeeBLL;

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _employeeBLL.GetAll();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEditForm empolyeeEdit = new EmployeeEditForm(); 

            EmployeeEditForm.id = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;
            EmployeeEditForm.choice = true;
            this.Hide();
            empolyeeEdit.MdiParent = this.MdiParent;
            empolyeeEdit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmployeeSearch.Text) || string.IsNullOrWhiteSpace(txtEmployeeSearch.Text))
            {
                _employeeBLL.GetAll();
                

            }
            var search = _employeeBLL.GetAll().Where(x => x.FirstName.ToLower().Contains(txtEmployeeSearch.Text.ToLower())).OrderByDescending(x => x.FirstName).ToList();

            dataGridView1.DataSource = search;
        }
    }
}
