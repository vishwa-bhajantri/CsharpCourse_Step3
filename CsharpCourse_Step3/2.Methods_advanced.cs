using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Advanced
{

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }

    }

    class StudentOperations
    {
        public static Student GetStudent()
        {
            Student student = new Student();

            student.Name = "Peter";
            student.Age = 18;
            student.Subject = "Java Script";

            return student;
        }

        //return multiple Student details
        public static Student[] GetStudents()
        {
            return new Student[]
            {
                new Student(){Name = "Bob", Age = 21, Subject = "JavaScript"},
                new Student(){Name = "Kristi", Age = 20, Subject = "CSS"},
                new Student(){Name = "Nathan", Age = 23, Subject = "HTML"},
            };
        }

        public static Student UpdateStudent(Student stu)
        {

            stu.Subject = stu.Subject + " - Advanced";
            return stu;
            //Student student = new Student();

            //student.Name = "Peter";
            //student.Age = 18;
            //student.Subject = "Java Script";

            //return student;
        }

        public static Student[] UpdateStudents(Student[] studentList)
        {
            foreach (Student student in studentList)
            {
                student.Subject = student.Subject + "- Advanced";
            }
            return studentList;
            
            
        }
    }

    class program
    {
        public static void Main()
        {
            Student s1 = StudentOperations.GetStudent();

            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Age);
            Console.WriteLine(s1.Subject);

            Student[] students = StudentOperations.GetStudents();
            foreach(Student s in students)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Age);
                Console.WriteLine(s.Subject);
            }
            Student updatedStudentDetails = StudentOperations.UpdateStudent(s1);
            Console.WriteLine($"Updated Student {updatedStudentDetails.Name}, {updatedStudentDetails.Age}, {updatedStudentDetails.Subject}");

           Student[] students1 = StudentOperations.UpdateStudents(students);
            foreach(Student s in students1)
            {
                Console.WriteLine($"Updated Student {s.Name}, {s.Age}, {s.Subject}");
            }
        }
    }
}
