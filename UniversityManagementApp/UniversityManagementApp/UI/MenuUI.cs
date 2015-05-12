using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementApp.UI
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void departmentEntryButton_Click(object sender, EventArgs e)
        {
            DepartmentEntryUI departmentEntryUi = new DepartmentEntryUI();
            departmentEntryUi.Show();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI studentEntryUi = new StudentEntryUI();
            studentEntryUi.Show();
        }

        
    }
}
