using System;

namespace GenericParameter_WithEntity_Example
{

    class Repository<T> where T : class
    {
        public void Save<T>(T entity)
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
    class Employee
    {
        public int Id { get; set; }
    }

    class Student
    {
        public int Id { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Repository<Employee> repository = new Repository<Employee>();
            Employee employee = new Employee() { Id = 101 };
            repository.Save<Employee>(employee);

            Repository<Student> repository1 = new Repository<Student>();
            Student student = new Student() { Id = 201 };
            repository1.Save<Student>(student);
        }
    }
}