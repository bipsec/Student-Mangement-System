# Student Mangement System
 
 This is a console Application of Student Mangement System. Initially user can see 3 mode namely:<br />
 1. Add New Student,<br />
 2. View Student Details,<br />
 3. Delete Student.<br />
 <br />
 Mode 1:<br />
 In this mode user can add student. To add a new Student user need to fill up the following properties.<br />
   First Name: string - length(min 3)<br />
   Middle Name: string - length(min 3)<br />
   Last Name: string - length(min 3)<br />
   Student ID: string format: XXX-XXX-XXX. (must be unique)<br />
   Joining Batch: string format: dd.mm.yyyy<br />
   Department: string<br />
   Degree: string<br />
   <br />
   After the successful addition of a new student, the user can see a successful message.<br />
   
Mode 2:<br /> 
In this mode User can see student details. To see all of the information, user need to enter the student ID. If found the details will be shown unless there will be a    message that the student is not found as the student does not exist.<br />
<br />
After seeing the student info, user can add new semeseter as well as new course to that student.<br />
To add new semester to that student, user need to enter the following entities:<br />
<br />
Semester Name: string(must be Summer/Fall/Spring)<br />
Year: string format: YYYY.<br />
<br />
To add new course to that student, user need to enter the following entities:<br />
<br />
Course ID: string format: XXX YYY<br />
Course Name:string (min 3)<br />
Instructor name: (min 3)<br />
Credits: int<br />
<br />
<br />
Mode 3:<br />
Student deletion will be done by providing the student ID. If not found the id, the student does not exist.
   
   
