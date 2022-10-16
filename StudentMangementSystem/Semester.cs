using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class Semester
    {
        enum Code { Summer, Fall, Spring };
        Code sem = Code.Fall;
        string year = "2022";
        Console.WriteLine("Semsester Code: " + sem);
        Console.WriteLine("Year: "+ year);
    }
    public static void addNewSemester()
    {
        string semesterCode, year, id, course;
        Console.Write("Enter semester code: ");
        semesterCode = Console.ReadLine();
        Console.Write("Enter Year: ");
        year = Console.ReadLine();
        Console.Write("Assign to the student ID: ");
        id = Console.ReadLine();
        Console.Write("Do you want to assign course to that student?  Yes/No");
        course = Console.ReadLine();


        if (id == Student.id && course == "Yes")
        {
            //some code goes here.
            //adding semseter to the student semsester arr.
            // addNewCourse();
        }
        else
        {
            Console.WriteLine("Sorry, student is not found by the ID");
        }
    }
