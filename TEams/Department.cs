﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEams
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    
        public Department(int departmentId, string name)
        {
            DepartmentId = departmentId;
            Name = name;
        }
        
            
        
    }
}
