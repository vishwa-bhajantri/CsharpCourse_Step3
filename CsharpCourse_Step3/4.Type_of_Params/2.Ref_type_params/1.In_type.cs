using System;

namespace TypeParameter_InType
{
    class EmployeeDemo
    {
        static void Main()
        {
            int employeeId = 101;
            bool isActive = true;
            string employeeName = "Ravi";

            Console.WriteLine($"Outside Method Employee id is : {employeeId}");
            Console.WriteLine($"Employee status is {isActive}");
            Console.WriteLine($"Employee name {employeeName}");


            DisplayEmployeeDetails(in employeeId, in isActive, in employeeName);


            static void DisplayEmployeeDetails(in int empId, in bool status, in string name)
            {

                Console.WriteLine($"Inside Method Employee id is : {empId}");
                Console.WriteLine($"Employee status is {status}");
                Console.WriteLine($"Employee name {name}");
            }
        }
    }
}