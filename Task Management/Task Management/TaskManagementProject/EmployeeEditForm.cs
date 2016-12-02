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
using _01_DataAccessLayer;

namespace TaskManagementProject
{
    public partial class EmployeeEditForm : Form
    {
        EmployeeBLL _employeeBLL;
        EmployeeTypeBLL _employeeTypeBLL;
        public static int id;
        public static bool choice;
        private Employee employee;

        private void CleanControls()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox) item).SelectedItem =null;
                }
                else if(item is MaskedTextBox)
                {
                    ((MaskedTextBox) item).Text = string.Empty;
                }
            }
        }

        public EmployeeEditForm()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            _employeeTypeBLL = new EmployeeTypeBLL();
        }
        public bool control = false;
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            employee = new Employee();

            if (btnCreateEmployee.Text == "Çalışan Oluştur")
            {
                control = Convert.ToBoolean(_employeeBLL.Get(txtEmail.Text));

                if (control)
                {
                    MessageBox.Show("Bu E-mail daha önce kayıt gerçekleştirilmiş.");
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
                    {
                        errorProvider.SetError(txtEmployeeName, "Çalışan ismi boş geçilemez");
                        return;
                    }
                    
                        employee.FirstName = txtEmployeeName.Text;
                        errorProvider.SetError(txtEmployeeName, "");
                    
            

                    if (string.IsNullOrWhiteSpace(txtEmployeeLastName.Text))
                    {
                        errorProvider.SetError(txtEmployeeLastName, "Çalışan soyismi boş geçilemez");
                        return;
                    }
                    
                        employee.LastName = txtEmployeeLastName.Text;
                        errorProvider.SetError(txtEmployeeLastName, "");
                    

                    employee.EmployeeTypeID = (int) cmbEmployeeType.SelectedValue;

                    if (string.IsNullOrWhiteSpace(mskdTxtPhone.Text))
                    {
                        errorProvider.SetError(mskdTxtPhone, "Telefon numarası boş geçilemez.");
                        return;
                    }
                    
                        employee.Phone = mskdTxtPhone.Text;
                        errorProvider.SetError(mskdTxtPhone, "");
                    

                    if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        errorProvider.SetError(txtEmail, "EMail boş geçilemez.");
                        return;
                    }
                    
                        employee.EMail = txtEmail.Text;
                        errorProvider.SetError(txtEmail, "");
                    


                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        errorProvider.SetError(txtPassword, "Şifre kısmı boş geçilemez.");
                        return;
                    }
                    
                        employee.Password = txtPassword.Text;
                        errorProvider.SetError(txtPassword, "");
                    
                    _employeeBLL.Add(employee);
                    MessageBox.Show("Çalışan oluşturma işlemi başarıyla gerçekleşti.");
                    CleanControls();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
                {
                    errorProvider.SetError(txtEmployeeName, "Çalışan ismi boş geçilemez");
                    return;
                }

                employee.FirstName = txtEmployeeName.Text;
                errorProvider.SetError(txtEmployeeName, "");



                if (string.IsNullOrWhiteSpace(txtEmployeeLastName.Text))
                {
                    errorProvider.SetError(txtEmployeeLastName, "Çalışan soyismi boş geçilemez");
                    return;
                }

                employee.LastName = txtEmployeeLastName.Text;
                errorProvider.SetError(txtEmployeeLastName, "");


                employee.EmployeeTypeID = (int)cmbEmployeeType.SelectedValue;

                if (string.IsNullOrWhiteSpace(mskdTxtPhone.Text))
                {
                    errorProvider.SetError(mskdTxtPhone, "Telefon numarası boş geçilemez.");
                    return;
                }

                employee.Phone = mskdTxtPhone.Text;
                errorProvider.SetError(mskdTxtPhone, "");


                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider.SetError(txtEmail, "EMail boş geçilemez.");
                    return;
                }

                employee.EMail = txtEmail.Text;
                errorProvider.SetError(txtEmail, "");



                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider.SetError(txtPassword, "Şifre kısmı boş geçilemez.");
                    return;
                }

                employee.Password = txtPassword.Text;
                errorProvider.SetError(txtPassword, "");
                _employeeBLL.Update(employee);
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.");
                CleanControls();
            }

        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            cmbEmployeeType.DataSource = _employeeTypeBLL.GetAll();
            cmbEmployeeType.ValueMember = "EmployeeTypeID";
            cmbEmployeeType.DisplayMember = "Name";

            if (choice)
            {
                employee = _employeeBLL.Get(id);
                txtEmployeeName.Text = employee.FirstName;
                txtEmployeeLastName.Text = employee.LastName;
                txtEmployeeName.Enabled = false;
                txtEmployeeLastName.Enabled = false;
                cmbEmployeeType.SelectedValue = employee.EmployeeTypeID;
                //cmbEmployeeType.ValueMember = employee.EmployeeType.ToString();
                mskdTxtPhone.Text = employee.Phone;
                txtEmail.Text = employee.EMail;
                txtPassword.Text = employee.Password;
                btnCreateEmployee.Text = "Güncelle";

            }


        }
    }
}
