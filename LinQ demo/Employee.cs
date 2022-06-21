using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employeesList = new List<Employee>()
            {
                new Employee{Id = 1,Name ="Yujan",Gender ="Male",Salary=1000,Department="CSIT"},
                new Employee{Id = 3,Name ="Nirmal",Gender ="Male",Salary=2000,Department="BIT"},
                new Employee{Id = 2,Name ="Bigyan",Gender ="Male",Salary=3000,Department="BIT"},
                new Employee{Id = 4,Name ="Eric",Gender ="Male",Salary=4000,Department="CSIT"}
            };
            return employeesList;
        }
    }
}
