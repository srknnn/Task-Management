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
    public partial class ProjectEditForm : Form
    {
        EmployeeBLL _empBLL;
        EmployeeTypeBLL _employeeTypeBLL;
        CustomerBLL _customerBLL;
        ProjectBLL _projectBLL;
        List<Employee> employeList;
        ProjectEmployeesBLL _projectEmployeesBLL;

        public ProjectEditForm()
        {
            InitializeComponent();
            _empBLL = new EmployeeBLL();
            _employeeTypeBLL = new EmployeeTypeBLL();
            _customerBLL = new CustomerBLL();
            _projectBLL = new ProjectBLL();
            employeList = new List<Employee>();
            _projectEmployeesBLL = new ProjectEmployeesBLL();

            dateRequedEnd.MinDate = DateTime.Now;
            dateRequedStart.MinDate = DateTime.Now;
        }

        public static Employee employee;

        int _cmbSelectedID;
        private void ProjectEditForm_Load(object sender, EventArgs e)
        {
            cmbEmployeeType.DataSource = _employeeTypeBLL.GetAll().OrderBy(x => x.EmployeeTypeID).ToList();
            cmbEmployeeType.DisplayMember = "Name";
            cmbEmployeeType.ValueMember = "EmployeeTypeID";
            _cmbSelectedID = (int)cmbEmployeeType.SelectedValue;

            cmbCustomer.DataSource = _customerBLL.GetAll().OrderBy(x => x.CompanyName).ToList();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";

            EmployeeListRefresh();
        }

        public void EmployeeListRefresh()
        {
            lstEmployees.Items.Clear();

            List<Employee> employeeList;
            try
            {
                _cmbSelectedID = (int)cmbEmployeeType.SelectedValue;
                employeeList = _empBLL.GetEmployee(_cmbSelectedID);

                foreach (var item in employeeList)
                {
                    bool flag = false;
                    //foreach (ListViewItem item2 in listViewEmployees.Items)
                    //{
                    //    if (item.EmployeeID == ((Employee)item2.Tag).EmployeeID)
                    //    {
                    //        flag = true;
                    //    }
                    //}
                    foreach (var item2 in lstProjectEmployees.Items)
                    {
                        if (item.EmployeeID == ((Employee)item2).EmployeeID)
                        {
                            flag = true;
                        }
                    }


                    if (!flag)
                    {
                        lstEmployees.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {


            }
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

            EmployeeListRefresh();

        }

        public void GetList()
        {
            lstProjectEmployees.Items.Clear();

            foreach (Employee item in employeList)
            {
                lstProjectEmployees.Items.Add(item);
            }
            EmployeeListRefresh();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstEmployees.CheckedItems.Count; i++)
            {
                employeList.Add((Employee)lstEmployees.CheckedItems[i]);
            }
            GetList();
            cmbEmployeeType.SelectedIndex = 0;

        }

        private void btnProjectCreate_Click(object sender, EventArgs e)
        {
            int Type1 = 0, Type2 = 0, Type3 = 0, Type4 = 0, Type5 = 0;
            try
            {
                Project project = new Project();


                if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                {
                    errorProvider.SetError(txtProjectName, "Proje İsmi Boş Geçilemez");
                    return;
                }
                else
                {
                    project.Name = txtProjectName.Text;
                    errorProvider.SetError(txtProjectName, "");
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    errorProvider.SetError(txtDescription, "Proje Açıklaması Boş Geçilemez");
                    return;
                }
                else
                {
                    project.Description = txtDescription.Text;
                    errorProvider.SetError(txtDescription, "");
                }

                project.EmployeeID = employee.EmployeeID; 
                project.CustomerID = (int)cmbCustomer.SelectedValue;
                project.RequiredStartDate = dateRequedStart.Value;
                project.RequiredEndDate = dateRequedEnd.Value;
                project.isActive = true;
                project.isDelected = false;

                foreach (Employee item in employeList)
                {

                    if (item.EmployeeType.EmployeeTypeID == 1)
                    {
                        Type1++;
                    }
                    else if(item.EmployeeType.EmployeeTypeID == 2)
                    {
                        Type2++;
                    }else if(item.EmployeeType.EmployeeTypeID == 3)
                    {
                        Type3++;
                    }
                    else if(item.EmployeeType.EmployeeTypeID == 4)
                    {
                        Type4++;
                    }else if (item.EmployeeType.EmployeeTypeID == 5)
                    {
                        Type5++;
                    }

                }

                if (Type1==0)
                {
                    MessageBox.Show("Proje Yöneticisi Eklenmemiştir, Lütfen Ekleyiniz!","Çalışan Ekleme Uyarısı",MessageBoxButtons.OK);
                    return;
                }
                if(Type2 == 0)
                {
                    MessageBox.Show("Takım Lideri Eklenmemiştir, Lütfen Ekleyiniz!", "Çalışan Ekleme Uyarısı", MessageBoxButtons.OK);
                    return;
                }
                if (Type3 == 0)
                {
                    MessageBox.Show("İş Analisti Eklenmemiştir, Lütfen Ekleyiniz!", "Çalışan Ekleme Uyarısı", MessageBoxButtons.OK);
                    return;
                }
                if (Type4 == 0)
                {
                    MessageBox.Show("Test Uzmanı Eklenmemiştir, Lütfen Ekleyiniz!", "Çalışan Ekleme Uyarısı", MessageBoxButtons.OK);
                    return;
                }
                if (Type5 == 0)
                {
                    MessageBox.Show("Yazılım Geliştirici Eklenmemiştir, Lütfen Ekleyiniz!", "Çalışan Ekleme Uyarısı", MessageBoxButtons.OK);
                    return;
                }

                _projectBLL.Add(project);

                foreach (Employee item in employeList)
                {
                    ProjectEmployees proEmp = new ProjectEmployees();
                    proEmp.EmployeeID = item.EmployeeID;
                    proEmp.ProjectID = project.ProjectID;
                    proEmp.isEmployeeActive = true;
                    _projectEmployeesBLL.Add(proEmp);
                }

                MessageBox.Show("Proje Oluşturuldu","Proje Oluşturma",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Proje Oluşturulamadı", "Proje Oluşturma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < lstProjectEmployees.CheckedItems.Count; i++)
                {
                    employeList.Remove((Employee)lstProjectEmployees.CheckedItems[i]);
                }


                //Employee employee = (Employee)listViewEmployees.SelectedItems[0].Tag;
               
                GetList();
                cmbEmployeeType.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Çalışanlar Çıkarılamadı!");
            }
        }
    }
}
