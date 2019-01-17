using System;
using System.Collections.Generic;

namespace WebApiTest.Models
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public  HashSet<Employee> Employee{get;private set;}
    }
}