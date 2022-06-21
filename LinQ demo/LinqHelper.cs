using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class LinqHelper
    {
        public void CreateList()
        {
            List<int> numbers = new List<int>() { 1, 3, 4, 5, 7, 8, 9, 6, 2 };
            Console.WriteLine("Selecting number greater then 5 using  Linq");   
            //Here result represents List therfore we use foreach to display
            //Here using Query Synatax in linq
            var result=from value in numbers where value%2==0 select value;
            Console.WriteLine("Even is:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //Here Using Method Syntax in linq
            var result2 = numbers.Where(x => x%2==1);
            Console.WriteLine("Odd:");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        } 
        public static void GetEmployeeDetails()
        {
            var employeeDetails = Employee.GetAllEmployees();
            var result= from value in employeeDetails
                        select value;
            int maxSalary= employeeDetails.Max(x => x.Salary );
            foreach(var item in result)
            {
                Console.WriteLine("Name:{0} and Salary:{1}", item.Name, item.Salary);
            }
            Console.WriteLine("Max Salary is:{0}",maxSalary);
        }
    }
}
