﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementApp.Model
{
    public class StudentDepartmentView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Address { get; set; }

        public int? DepartmentId { get; set; }

        public string DepartmentName { get; set; }


    }
}
