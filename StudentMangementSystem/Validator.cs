using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentMangementSystem
{
    class Validator
    {
        public static bool courseIDValidator(string courseID)
        {

            var regex = @"^[a-zA-Z]{0,3} \d{3}$";
            var match = Regex.Match(courseID, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                Console.WriteLine("Please provide Course ID in the format 'XXX YYY'");
                return false;
            }
            return true;

        }


        public static bool studentIDValidator(string studentID)
        {
            //Student ID validation
            Student student = DataManager.GetStudent(studentID);
            if (student!= null)
            {
                Console.WriteLine("Stdent already exists.");
                return false;
            }
            var regex = @"^\(?([0-9]{3})\)?[-]?([0-9]{3})[-]?([0-9]{3})$";
            var match = Regex.Match(studentID, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                Console.WriteLine("Please provide Student ID in the format 'XXX-XXX-XXX'");
                return false;
            }
            return true;
        }

        public static bool joiningBatchValidator(string batch)
        {
            var regex = @"^[0-3]?[0-9].[0-3]?[0-9].(?:[0-9]{2})?[0-9]{2}$";
            var match = Regex.Match(batch, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                Console.WriteLine("Joining Batch should be in the date type format: 'dd.mm.yyyy'");
                return false;
            }
            return true;

        }
        public static bool yearValidator(string year)
        {
            var regex = @"^(?=.*?(19[56789]|20\d{2}).*)\d{4}$";
            var match = Regex.Match(year, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                Console.WriteLine("Year should be in the format 'YYYY'");
                return false;
            }
            return true;

        }

        public static bool NameValidator(string datalength)

        {
            //FirstName, MiddleName, LastName, InstructorName,CourseName
            if (datalength.Length < 3)
            {
                Console.WriteLine("Input should be atleast 3 characters long.");
                return false;
            }
            return true;
        }
        public static bool stringValidator(string datalength)
        {
            if (datalength.Length <= 1)
            {
                Console.WriteLine("Input should be atleast more than 1 charcter.");
                return false;
            }
            return true;
        }
        public static bool creditValidator(string credit)
        {
            if (!credit.All(char.IsDigit))
            {
                Console.WriteLine("Input should be integer.");
                return false;
            }
            return true;
        }
        public static bool semesterNameValidator(string semester)
        {
            

            if(semester == "Summer" || semester == "Spring" || semester == "Fall")
            {

                return true;
            }
            Console.WriteLine("Semester must be: Summer/Spring/Fall");
            return false;

        }



    }
}
