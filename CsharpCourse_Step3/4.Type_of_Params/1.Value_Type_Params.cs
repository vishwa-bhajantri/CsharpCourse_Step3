using System;

namespace Type_of_Params
{
    class Employee
    { 
        static void Main()
        {
            int employeeId = 101;
            bool isActive = false;
            string employeeName = "Ravi";

            UpdateEmployeeDetails(employeeId, isActive, employeeName);
        }

        static void UpdateEmployeeDetails(int empId, bool status, string name)
        {
            empId = 201;
            status = true;
            name = "Lahy";

            Console.WriteLine($"Employee id is : {empId} Employee status is {status} Employee name {name}");
        }
    }
}
