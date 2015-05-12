using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementApp.BLL;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.UI
{
    
    public partial class DepartmentEntryUI : Form
    {
        DepartmentManager deptManager = new DepartmentManager();
        public DepartmentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            Department department = new Department(name);

            if (deptManager.Insert(department))
            {
                MessageBox.Show("Department inserted successfully!");
            }
            
        }
    }
}
