using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class Student
    {
        enum Dept { Computer, BBA, Math, English };
        enum Degree { BSC, BBA, BA, MSC, MBA, MA };
        
            string firstName, middleName, lastName, id;


            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Middle Name: ");
            middleName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Stduent ID: ");
            id = Console.ReadLine();
            Dept dept = Dept.BBA;
            Degree degree = Degree.BSC;
            Console.WriteLine("Student Details: ");
            Console.WriteLine("Student Name: " + firstName + " " + middleName + " " + lastName);
            Console.WriteLine("Std_ID: " + id);
            Console.WriteLine("Dept: " + dept);
            Console.WriteLine("Degree: " + degree);
        
    }
}
