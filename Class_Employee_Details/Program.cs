using EmployeeDetailsNS;
using EmployeeModelNameSpace;

List<EmployeeModel> list = new List<EmployeeModel>();
EmployeeDetails eDetail = new EmployeeDetails();
EmployeeModel eModel1 = new EmployeeModel();
for (int i = 0; i < 2; i++)
{
    eModel1 = eDetail.AddEmployeeDetails();
    list.Add(eModel1);
}

//eDetail.DisplayEmployeeDetails(list);


//For Update
list=eDetail.UpdateEmployeeDetails(list);
eDetail.DisplayEmployeeDetails(list);

list=eDetail.DeleteEmployeeDetails(list);
eDetail.DisplayEmployeeDetails(list);