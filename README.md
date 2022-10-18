# Student Mangement System
 
 This is a console Application of Student Mangement System. Initially user can see 3 mode namely: 1. Add New Student, 2. View Student Details, 3. Delete Student.
 
 Mode 1:
 In this mode user can add student. To add a new Student user need to fill up the following properties.
   First Name: string - length(min 3)
   Middle Name: string - length(min 3)
   Last Name: string - length(min 3)
   Student ID: string format: XXX-XXX-XXX. (must be unique)
   Joining Batch: string format: dd.mm.yyyy
   Department: string
   Degree: string
   
   After the successful addition of a new student, the user can see a successful message.
   
Mode 2: 
In this mode User can see student details. To see all of the information, user need to enter the student ID. If found the details will be shown unless there will be a    message that the student is not found as the student does not exist.

After seeing the student info, user can add new semeseter as well as new course to that student.
To add new semester to that student, user need to enter the following entities:

Semester Name: string(must be Summer/Fall/Spring)
Year: string format: YYYY.

To add new course to that student, user need to enter the following entities:

Course ID: string format: XXX YYY
Course Name:string (min 3)
Instructor name: (min 3)
Credits: int


Mode 3:
Student deletion will be done by providing the student ID. If not found the id, the student does not exist.
   
   
