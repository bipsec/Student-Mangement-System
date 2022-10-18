using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class DataManager
    {

        readonly static string fileName = "Data.json";
        public static void SaveData(string json)
        {
            System.IO.File.WriteAllText(fileName, json);
        }
        public static DataInfo GetData()
        {
            DataInfo data;
            if (System.IO.File.Exists(fileName))
            {
                string oldData = System.IO.File.ReadAllText(fileName);
                data = JsonConvert.DeserializeObject<DataInfo>(oldData);
            }
            else
            {
                data = new DataInfo();
            }
            return data;
        }

        public static Student GetStudent(string id)
        {
            DataInfo data = GetData();
            List<Student> studentList = data.studentList;
            return (from item in studentList where item.id == id select item).FirstOrDefault();
        }
        // DataInfo sem;
        public static List<Semester> GetSemester(string stdId)
        {
            DataInfo sem = GetData();
            List<Semester> semesterList = sem.semesterList;
            List<Semester> stdSemesterList = new List<Semester>();
            for (int i = 0; i < semesterList.Count; i++)
            {
                if (semesterList[i].stdId == stdId)
                    stdSemesterList.Add(semesterList[i]);
            }
            return stdSemesterList;

        }
        

        public static List<Course> GetCourse(string stdId)
        {
            DataInfo course = GetData();
            List<Course> courseList = course.courseList;
            List<Course> stdCourseList = new List<Course>();
            
            for (int i = 0; i < courseList.Count; i++)
            {
                if (courseList[i].stdId == stdId)
                    stdCourseList.Add(courseList[i]);
            }
            return stdCourseList;
        }

        public static void DeleteStudent(string stdId)
        {
            DataInfo data = GetData();
            //Console.Write(data.studentList.Count);
            for (int i = 0; i < data.studentList.Count; i++)
            {
                if (data.studentList[i].id == stdId) data.studentList.RemoveAt(i);
            }
            for (int i = 0; i < data.semesterList.Count; i++)
            {
                if (data.semesterList[i].stdId == stdId) data.semesterList.RemoveAt(i);
            }
            for (int i = 0; i < data.courseList.Count; i++)
            {
                if (data.courseList[i].stdId == stdId) data.courseList.RemoveAt(i);
            }
            SaveData(JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        public static void ViewStudentDetails(string stdID)
        {
            Student presentStudent = GetStudent(stdID);

            if (presentStudent != null)
            {
                Console.WriteLine("Student Name: " + presentStudent.firstName+ " " + presentStudent.middleName + " " + presentStudent.lastName);
                Console.WriteLine("Student ID: " + presentStudent.id);
                Console.WriteLine("Joining Batch: " + presentStudent.joiningBatch);
                Console.WriteLine("Department: " + presentStudent.department);
                Console.WriteLine("Degree: " + presentStudent.degree);

                List<Semester> semesters = GetSemester(stdID);
                for (int i = 0; i < semesters.Count; i++)
                {
                    Console.WriteLine("Semester Name: " + " " + semesters[i].semesterName + ", " +
                                       "Year: " + " " + semesters[i].year);
                }

                List<Course> courses = GetCourse(stdID);
                for (int i = 0; i < courses.Count; i++)
                {
                    Console.WriteLine("Course ID: "+" "+ courses[i].courseId + ", "+
                                       "Course Name: "+ " "+ courses[i].courseName +", "+
                                       "Instructor Name: "+ " "+ courses[i].instructorName+", "+
                                       "Course Credit: "+ " "+ courses[i].courseCredit );
                }
            }
            else
            {
                Console.WriteLine("Sorry there is no student on this ID");

            }
        }
    }
}
