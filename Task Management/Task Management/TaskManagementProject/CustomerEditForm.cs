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
    public partial class CustomerEditForm : Form
    {
        CustomerBLL _customerBLL;
        public static int id;
        public static bool choice;
        private Customer customer;

        public CustomerEditForm()
        {
            InitializeComponent();

            _customerBLL = new CustomerBLL();
        }

        private void CleanBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }
        }

        public bool control = false;
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Kaydet")
            {
                control = Convert.ToBoolean(_customerBLL.Get(txtEMail.Text));

                if (control)
                {
                    MessageBox.Show("Bu Email daha önce kullanılmış!");

                }
                else
                {

                    if (string.IsNullOrWhiteSpace(txtContactName.Text))
                    {
                        errorProvider.SetError(txtContactName, "Yetkili ismi boş geçilemez");
                        return;
                    }
                    
                   
                        customer.ContactName = txtContactName.Text;
                        errorProvider.SetError(txtContactName, "");
                    
                    
                    if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
                    {
                        errorProvider.SetError(txtCompanyName, "Şirket ismi boş geçilemez");
                        return;
                    }
                   
                    
                        customer.CompanyName = txtCompanyName.Text;
                        errorProvider.SetError(txtCompanyName, "");
                    
                    
                    if (string.IsNullOrWhiteSpace(txtAdress.Text))
                    {
                        errorProvider.SetError(txtAdress, "Adres alanı boş geçilemez");
                        return;
                    }
                    
                    
                        customer.Address = txtAdress.Text;
                        errorProvider.SetError(txtAdress, "");
                    
                    
                    if (string.IsNullOrWhiteSpace(txtEMail.Text))
                    {
                        errorProvider.SetError(txtEMail, "Email alanı boş geçilemez");
                        return;
                    }
                    
                    
                        customer.Email = txtEMail.Text;
                        errorProvider.SetError(txtEMail, "");
                    
                    
                    if (string.IsNullOrWhiteSpace(txtPhone.Text))
                    {
                        errorProvider.SetError(txtPhone, "Telefon alanı boş geçilemez");
                        return;
                    }
                    
                    
                        customer.Phone = txtPhone.Text;
                        errorProvider.SetError(txtPhone, "");
                    
                    _customerBLL.Add(customer);
                    MessageBox.Show("Müşteri kaydedildi.");
                    CleanBox();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtContactName.Text))
                {
                    errorProvider.SetError(txtContactName, "Yetkili ismi boş geçilemez");
                    return;
                }
                
                    customer.ContactName = txtContactName.Text;
                    errorProvider.SetError(txtContactName, "");
                
                
                if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
                {
                    errorProvider.SetError(txtCompanyName, "Şirket ismi boş geçilemez");
                    return;
                }
                
                    customer.CompanyName = txtCompanyName.Text;
                    errorProvider.SetError(txtCompanyName, "");
                
                
                if (string.IsNullOrWhiteSpace(txtAdress.Text))
                {
                    errorProvider.SetError(txtAdress, "Adres alanı boş geçilemez");
                    return;
                }
                
                    customer.Address = txtAdress.Text;
                    errorProvider.SetError(txtAdress, "");
                
                
                if (string.IsNullOrWhiteSpace(txtEMail.Text))
                {
                    errorProvider.SetError(txtEMail, "Email alanı boş geçilemez");
                    return;
                }
                
                    customer.Email = txtEMail.Text;
                    errorProvider.SetError(txtEMail, "");
                
                
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    errorProvider.SetError(txtPhone, "Telefon alanı boş geçilemez");
                    return;
                }
                
                    customer.Phone = txtPhone.Text;
                    errorProvider.SetError(txtPhone, "");
                
                _customerBLL.Update(customer);
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.");
                CleanBox();
            }


        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

            if (choice)
            {
                customer = _customerBLL.Get(id);
                txtContactName.Text = customer.ContactName;
                txtCompanyName.Text = customer.CompanyName;
                txtAdress.Text = customer.Address;
                txtEMail.Text = customer.Email;
                txtPhone.Text = customer.Phone;
                btnSave.Text = "Güncelle";

            }
        }
    }
}
