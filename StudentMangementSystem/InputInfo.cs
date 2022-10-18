using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class InputInfo
    {

        public static void AddNewStudent()
        {
            Student student = new Student();


            Console.Write("First Name: ");
            student.firstName = Console.ReadLine();
            while (!Validator.NameValidator(student.firstName))
            {
                Console.Write("First Name: ");
                student.firstName = Console.ReadLine();
            }
            
            Console.Write("Middle Name: ");
            student.middleName = Console.ReadLine();
            while (!Validator.NameValidator(student.middleName))
            {
                Console.Write("Middle Name: ");
                student.middleName = Console.ReadLine();
            }
            Console.Write("Last Name: ");
            student.lastName = Console.ReadLine();
            while (!Validator.NameValidator(student.lastName))
            {
                Console.Write("Last Name: ");
                student.lastName = Console.ReadLine();
            }
            Console.Write("Stduent ID: ");
            student.id = Console.ReadLine();
            while (!Validator.studentIDValidator(student.id))
            {
                Console.Write("Stduent ID: ");
                student.id = Console.ReadLine();
            }
            Console.Write("Joining Batch: ");
            student.joiningBatch = Console.ReadLine();
            while (!Validator.joiningBatchValidator(student.joiningBatch))
            {
                Console.Write("Joining Batch: ");
                student.joiningBatch = Console.ReadLine();
            }
            Console.Write("Department: ");
            student.department = Console.ReadLine();
            while (!Validator.stringValidator(student.department))
            {
                Console.Write("Department: ");
                student.department = Console.ReadLine();
            }
            Console.Write("Degree: ");
            student.degree = Console.ReadLine();
            while (!Validator.stringValidator(student.degree))
            {
                Console.Write("Department: ");
                student.degree = Console.ReadLine();
            }



            DataInfo data = DataManager.GetData();
            data.studentList.Add(student);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            

            DataManager.SaveData(json);
            Console.WriteLine("Student Added Successfully.");

            //Console.ReadLine();

        }
        public static void AddNewSemester(string stdId)
        {
            Semester newSem = new Semester();
            newSem.stdId = stdId;
            Console.Write("Enter semester name: ");
            newSem.semesterName = Console.ReadLine();
            while (!Validator.semesterNameValidator(newSem.semesterName))
            {
                Console.Write("Enter semester name: ");
                newSem.semesterName = Console.ReadLine();
            }

            Console.Write("Year: ");
            newSem.year = Console.ReadLine();
            while (!Validator.yearValidator(newSem.year))
            {
                Console.Write("Enter semester name: ");
                newSem.year = Console.ReadLine();
            }


            DataInfo data = DataManager.GetData();
            data.semesterList.Add(newSem);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            Console.WriteLine("Semester Added Successfully.");

            DataManager.SaveData(json);

            

        }
        public static void AddNewCourse(string stdId)
        {
            Course newCourse = new Course();

            newCourse.stdId = stdId;

            Console.Write("Enter CourseID: ");
            newCourse.courseId = Console.ReadLine();
            while (!Validator.courseIDValidator(newCourse.courseId))
            {
                Console.Write("Enter CourseID: ");
                newCourse.courseId = Console.ReadLine();
            }

            Console.Write("Enter Course Name: ");
            newCourse.courseName = Console.ReadLine();
            while (!Validator.NameValidator(newCourse.courseName))
            {
                Console.Write("Enter Course Name: ");
                newCourse.courseName = Console.ReadLine();
            }

            Console.Write("Enter Instructor name: ");
            newCourse.instructorName = Console.ReadLine();
            while (!Validator.NameValidator(newCourse.instructorName))
            {
                Console.Write("Enter Instructor name: ");
                newCourse.instructorName = Console.ReadLine();
            }

            Console.Write("Enter credits: ");
            newCourse.courseCredit = (Console.ReadLine());
            while (!Validator.creditValidator(newCourse.courseCredit))
            {
                Console.Write("Enter credits: ");
                newCourse.courseCredit = (Console.ReadLine());
            }


            DataInfo data = DataManager.GetData();
            data.courseList.Add(newCourse);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            Console.WriteLine("Course Added Successfully.");

            DataManager.SaveData(json);

            //Console.ReadLine();



        }

    }
}

