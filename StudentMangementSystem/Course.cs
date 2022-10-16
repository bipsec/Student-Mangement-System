using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class Course
    {
        string courseId, courseName, instructorName, courseCredit;
        Console.Write("Course ID: ");
        courseId = Console.ReadLine();
        Console.Write("Course Name: ");
        courseName = Console.ReadLine();
        Console.Write("Instructor Name: ");
        instructorName = Console.ReadLine();
        Console.Write("Course Credit: ");
        courseCredit = Console.ReadLine();
        showCourse(courseId, courseName, instructorName, courseCredit);
    }

    public static void showCourse(string a, b, c, d)
    {
        Console.WriteLine("Course ID: " + a);
        Console.WriteLine("Course Name: " + b);
        Console.WriteLine("Instructor Name: " + c);
        Console.WriteLine("Course Credit: " + d);

    }

    public static void addNewCourse()
    {
        string courseId, courseName, instructorName, courseCredit;
        Console.Write("Course ID: ");
        courseId = Console.ReadLine();
        Console.Write("Course Name: ");
        courseName = Console.ReadLine();
        Console.Write("Instructor Name: ");
        instructorName = Console.ReadLine();
        Console.Write("Course Credit: ");
        courseCredit = Console.ReadLine();
    }
}
