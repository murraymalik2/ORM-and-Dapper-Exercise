﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class Department
    {
        public Department()
        {
        }
        public int DepartmentID { get; set} 
        public string Name { get; set; }
        
    }
}
