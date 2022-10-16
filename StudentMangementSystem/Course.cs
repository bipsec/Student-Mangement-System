using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class Course
    {
        public string courseId, courseName, instructorName, courseCredit;
      
        public static void showCourse(string a,string b, string c, string d)
        {
            Console.WriteLine("Course ID: " + a);
            Console.WriteLine("Course Name: " + b);
            Console.WriteLine("Instructor Name: " + c);
            Console.WriteLine("Course Credit: " + d);

        }

        
    }

    
}
