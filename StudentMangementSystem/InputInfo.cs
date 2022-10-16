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
            //Console.Write("Middle Name: ");
            //student.middleName = Console.ReadLine();
            //Console.Write("Last Name: ");
            //student.lastName = Console.ReadLine();
            //Console.Write("Stduent ID: ");
            //student.id = Console.ReadLine();
            //Console.Write("Joining Batch: ");
            //student.joiningBatch = Console.ReadLine();
            //Console.Write("Department: ");
            //student.department = Console.ReadLine();
            //Console.Write("Degree: ");
            //student.degree = Console.ReadLine();


            DataInfo data = DataManager.GetData();
            data.studentList.Add(student);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            Console.WriteLine(json);

            DataManager.SaveData(json);

            Console.ReadLine();
            
        }
        public static void AddNewSemester()
        {
            Semester sem = new Semester();

            Console.Write("Enter semester name: ");
            sem.semesterName = Console.ReadLine();
            Console.Write("Year: ");
            sem.year = Console.ReadLine();


            DataInfo data = DataManager.GetSemester();
            data.semeterList.Add(sem);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            Console.WriteLine(json);

            DataManager.SaveData(json);

            Console.ReadLine();

        }
        public static void AddNewCourse()
        {
            Course newCourse = new Course();

            Console.Write("Enter CourseID: ");
            newCourse.courseId = Console.ReadLine();
            Console.Write("Enter Course Name: ");
            newCourse.courseName = Console.ReadLine();
            Console.Write("Enter Instructor name: ");
            newCourse.instructorName = Console.ReadLine();
            Console.Write("Enter credits: ");
            newCourse.courseCredit = Console.ReadLine();


            DataInfo data = DataManager.GetCourse();
            data.semeterList.Add(newCourse);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            Console.WriteLine(json);

            DataManager.SaveData(json);

            Console.ReadLine();



        }

    }
}

