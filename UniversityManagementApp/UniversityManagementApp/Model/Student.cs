using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Address { get; set; }

        public int?  DepartmentId { get; set; }

        
    }
}
