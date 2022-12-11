using System;

namespace OOP2
{

    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Davit";
            student.middleName = "Matevos";
            student.lastName = "Ghrzoyan";
            student.age = 27;
            student.id = Guid.NewGuid();
            student.group = "C-Sharp 2022";

            return student;
        }

        //static Student GetStudent()
        //{
        //    Student secondStudent = new Student();

        //    secondStudent.firstName = "Armen";
        //    secondStudent.middleName = "Hayk";
        //    secondStudent.lastName = "Martirosyan";
        //    secondStudent.age = 22;
        //    secondStudent.id = Guid.NewGuid();
        //    secondStudent.group = "Java Script 2022";
        //    secondStudent.Print();

        //    return secondStudent;
        //}

        //static void Print(Student student)
        //{
        //    Console.WriteLine("Information about student");
        //    Console.WriteLine($"Id: {student.id}");
        //    Console.WriteLine($"Last Name: {student.lastName}");
        //    Console.WriteLine($"Name: {student.firstName}");
        //    Console.WriteLine($"Surname: { student.middleName}");
        //    Console.WriteLine($"Age: {student.age}");
        //    Console.WriteLine($"Group: {student.group}");
        //}

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            string fullName = firstStudent.GetFullName();

            Console.WriteLine(fullName);


        }
    }
} 
