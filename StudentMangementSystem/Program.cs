using Newtonsoft.Json;
using System;

namespace StudentMangementSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Welcome to Student Management System");
            Console.WriteLine();
            string[] initialSCreen = new string[3] { "Add new Student", "View Student Details", "Delete Student" };
            for (int i = 0; i < initialSCreen.Length; i++)
            {
                Console.Write((i + 1) + ". " + initialSCreen[i] + " ");

            }
            string num;
            Console.WriteLine();
            Console.Write("Enter 1/2/3: ");
            num = Console.ReadLine();
            Console.WriteLine();


            if (num == "1")
            {
                //Add new Student
                InputInfo.AddNewStudent();
            }
            else if (num == "2")
            {
                // View Student Details
                string stdID;
                Console.Write("Enter Student ID: ");
                stdID = Console.ReadLine();
                Student student = DataManager.GetStudent(stdID);
                
                if (student != null)
                {
                    DataManager.ViewStudentDetails(stdID);
                    // Add new Semester
                    Console.Write("To add semester, type 1: ");
                    if (Console.ReadLine() == "1")
                    {
                        InputInfo.AddNewSemester(stdID);
                        //Add New Course
                        Console.Write("To Add Course, type 1: ");
                        if (Console.ReadLine() == "1")
                        {
                            InputInfo.AddNewCourse(stdID);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
            }
            else if (num == "3")
            {
                //Delete Student
                string stdID;
                Console.Write("Enter Student Id: ");
                stdID = Console.ReadLine();
                Student student = DataManager.GetStudent(stdID);
                
                if (student!= null)
                {
                    DataManager.DeleteStudent(Console.ReadLine());
                    Console.WriteLine("Student Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine("Student not Found.");
                }
                
               
            }

            Console.ReadLine();
        }
    }

}
