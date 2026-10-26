using System;

namespace NamedTypeParameter_Example
{
    class Userservice
    {
        static void Main()
        {
            //CreateUser("Paul", "Admin", true);
            CreateUser(name :"Paul", role :"Admin", isActive :true);
        }

        static void CreateUser(string name, string role, bool isActive)
        {
            Console.WriteLine($"User Name : {name}");
            Console.WriteLine($"Role : {role}");
            Console.WriteLine($"is Active : {isActive}");
        }
    }
}