using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementApp.Model
{
    public class Department
    {
        public Department()
        {
            
        }
        public Department(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
