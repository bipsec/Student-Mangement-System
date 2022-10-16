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
        //Get
        //Update Data
        //Set Data

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
            //for (int i = 0; i < studentList.Count; i++)
            //{
            //    if (studentList[i].id == id) return studentList[i];
            //}
            return (from item in studentList where item.id == id select item).FirstOrDefault();
        }
       // DataInfo sem;
        public static Semester GetSemester()
        {
            DataInfo sem = GetData();
            List<Semester> semesterList = sem.semeterList;

            if (System.IO.File.Exists(fileName))
            {
                string oldData = System.IO.File.ReadAllText(fileName);
                sem = JsonConvert.DeserializeObject<DataInfo>(oldData);
            }
            else
            {
                sem = new DataInfo();
            }
            return null;


        }
        //DataInfo course;

        public static Course GetCourse()
        {
            DataInfo course = GetData();
            List<Course> courseList = course.courseList;

            if (System.IO.File.Exists(fileName))
            {
                string oldData = System.IO.File.ReadAllText(fileName);
                course = JsonConvert.DeserializeObject<DataInfo>(oldData);
            }
            else
            {
                course = new DataInfo();
            }
            return null;


        }
    }
}
