using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Information about student");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Surname: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{lastName } {firstName} {middleName}";
        }
    }
}
