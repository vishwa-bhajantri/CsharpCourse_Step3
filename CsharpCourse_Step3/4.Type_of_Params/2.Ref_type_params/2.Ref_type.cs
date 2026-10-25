using System;
using System.Net.NetworkInformation;
using Type_of_Params;

namespace TypeParameter_RefType
{
    class EmployeeDemo
    {
        static void Main()
        {
            int employeeId = 101;
            bool isActive = false;
            string employeeName = "Ravi";

            DisplayEmployeeDetails(ref employeeId, ref isActive, ref employeeName);

            Console.WriteLine($"Outside Method \nEmployee id is : {employeeId}");
            Console.WriteLine($"Employee status is {isActive}");
            Console.WriteLine($"Employee name {employeeName}");



            static void DisplayEmployeeDetails(ref int empId, ref bool status, ref string name)
            {
                empId = 300;
                status = true;
                name = "Laila";

                Console.WriteLine($"Inside Method \nEmployee id is : {empId}");
                Console.WriteLine($"Employee status is {status}");
                Console.WriteLine($"Employee name {name}");
            }
        }
    }
}