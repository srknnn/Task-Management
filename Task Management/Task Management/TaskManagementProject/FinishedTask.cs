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
    public partial class FinishedTask : Form
    {
        public ProjectEmployeesBLL _projectEmployeesBLL;
        private TasksBLL _tasksBLL;
        public static Employee _employee;
        public FinishedTask()
        {
            _projectEmployeesBLL =  new ProjectEmployeesBLL();
            _tasksBLL = new TasksBLL();
            InitializeComponent();
        }

        private void FinishedTask_Load(object sender, EventArgs e)
        {
            object query = _projectEmployeesBLL.GetProjectTask(_employee.EmployeeID);
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].Visible = false;
        }

        private int _projectId;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                _projectId = (int)dataGridView1.SelectedRows[0].Cells["ProjectID"].Value;

                object query = _tasksBLL.GetTask(_projectId, 4);

                dataGridView2.DataSource = query;
                dataGridView2.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
