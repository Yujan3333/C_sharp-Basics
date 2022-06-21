using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModelNameSpace;

namespace EmployeeDetailsNS
{
    class EmployeeDetails
    {
        public EmployeeModel AddEmployeeDetails()
        {
            Console.WriteLine("Enter the employee detail.......\n");
            int eid;
            string ename, eaddress;
            Console.WriteLine("Enter the employee id:");
            eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name:");
            ename = Console.ReadLine();
            Console.WriteLine("Enter the employee address:");
            eaddress = Console.ReadLine();


            EmployeeModel eModel = new EmployeeModel();
            eModel.Id = eid;
            eModel.Name = ename;
            eModel.Address = eaddress;

            return eModel;

        }

        public void DisplayEmployeeDetails(List <EmployeeModel> employeeList)
        {

            foreach (var e in employeeList)
            {
                Console.WriteLine("Id={0}, Name={1}, Address={2} ", e.Id, e.Name, e.Address);
            }
        }

        public List <EmployeeModel> UpdateEmployeeDetails(List <EmployeeModel> employeeList)
        {
            Console.WriteLine("Enter the Employee Id to replace:");
            int empId= int.Parse(Console.ReadLine());

            
            foreach(EmployeeModel e in employeeList)
            {
                if(e.Id == empId)
                {
                    Console.WriteLine("Enter the new Name:");
                    string newName=Console.ReadLine();
                    Console.WriteLine("Enter the new Address:");
                    string newAddress= Console.ReadLine();
                    e.Name=newName;  
                    e.Address=newAddress;
                    return employeeList;
                }
                else
                {
                    Console.WriteLine("There is no employee with that ID!");
                    return employeeList;
                }
            }
            return null;
        }
        public List <EmployeeModel> DeleteEmployeeDetails(List<EmployeeModel>employeeList)
        {
            Console.WriteLine("Enter Employee Id to remove:");
            int empId = int.Parse(Console.ReadLine());
            foreach (EmployeeModel e in employeeList)
            {
                if (e.Id == empId)
                {
                    employeeList.Remove(e);
                    Console.WriteLine("Emplyee Record Deleted!!");
                    return employeeList;
                }
            }
            return null;

        }
    }
}