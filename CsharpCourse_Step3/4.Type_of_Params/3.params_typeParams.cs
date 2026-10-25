using System;

namespace ParamsParameter_Example
{
    class StudentMarks
    {
        static void Main()
        {
            CalculateToMarks("KETA", 80, 75, 90);
            CalculateToMarks("SHYSHA", 80, 75, 90,56,87);
        }

        static void CalculateToMarks(string StudentName, params int[] marks)
        {
            int total = 0;
            foreach(int mark in marks)
            {
                total += mark;
            }
            Console.WriteLine($"Student Name is {StudentName}");
            Console.WriteLine($"Total marks are : {total}");
        }
    }
}