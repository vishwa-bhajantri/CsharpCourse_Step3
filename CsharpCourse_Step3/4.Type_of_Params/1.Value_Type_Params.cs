using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Type_of_Params
{
    class Employee
    { 
        static void Main()
        {
            int employeeId = 101;
            bool isActive = false;
            string employeeName = "Ravi";

            Console.WriteLine($"Outside Method Employee id is : {employeeId} Employee status is {isActive} Employee name {employeeName}");

            UpdateEmployeeDetails(employeeId, isActive, employeeName);
        }

        static void UpdateEmployeeDetails(int empId, bool status, string name)
        {
            empId = 201;
            status = true;
            name = "Lahy";

            Console.WriteLine($"Inside Method Employee id is : {empId} Employee status is {status} Employee name {name}");
        }
    }
}
