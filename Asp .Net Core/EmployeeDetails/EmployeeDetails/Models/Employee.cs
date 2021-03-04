using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class Employee
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public decimal Salary { get; set; }
       public bool IsPermanent { get; set; }

        public Employee() { }

        public Employee(int id, string name, decimal salary, bool ispermanent) {

            Id = id;
            Name = name;
            Salary = salary;
            IsPermanent = ispermanent;
        } 
    }
}
