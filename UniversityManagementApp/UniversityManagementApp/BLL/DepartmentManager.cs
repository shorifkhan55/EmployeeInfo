using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementApp.DAL;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.BLL
{
    class DepartmentManager
    {
        DepartmentGateway gateway = new DepartmentGateway();
        public bool Insert(Department department)
        {
           return gateway.Insert(department)>0;
        }

        public List<Department> GetAllDepartments()
        {
            return gateway.GetAllDepartments();
        }
    }
}
