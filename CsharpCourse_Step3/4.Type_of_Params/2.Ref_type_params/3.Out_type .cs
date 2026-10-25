using System;

namespace TypeParameter_OutType
{
    class EmployeeDemo
    {
        static void Main()
        {
            int employeeId = 101;
            bool isActive = false;
            string employeeName = "Ravi";

            DisplayEmployeeDetails(out employeeId, out isActive, out employeeName);

            Console.WriteLine($"Outside Method \nEmployee id is : {employeeId}");
            Console.WriteLine($"Employee status is {isActive}");
            Console.WriteLine($"Employee name {employeeName}");



            static void DisplayEmployeeDetails(out int empId, out bool status, out string name)
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