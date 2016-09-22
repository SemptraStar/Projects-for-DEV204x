using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public struct Student
    {
        public Student(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
                       string City, string StateOrProvince, string Country, int ZipOrPostal)
        {
            this.studentFirstName = FirstName;
            this.studentSecondName = SecondName;
            this.studentAddressLine1 = AddressLine1;
            this.studentAddressLine2 = AddressLine2;
            this.studentCity = City;
            this.studentStateOrProvince = StateOrProvince;
            this.studentCountry = Country;
            this.studentZipOrPostal = ZipOrPostal;
        }

        public string studentFirstName;
        public string studentSecondName;
        public string studentAddressLine1;
        public string studentAddressLine2;
        public string studentCity;
        public string studentStateOrProvince;
        public string studentCountry;
        public int studentZipOrPostal;
    }
    public struct Teacher
    {
        public Teacher(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
                       string City, string StateOrProvince, string Country, int ZipOrPostal)
        {
            this.teacherFirstName = FirstName;
            this.teacherSecondName = SecondName;
            this.teacherAddressLine1 = AddressLine1;
            this.teacherAddressLine2 = AddressLine2;
            this.teacherCity = City;
            this.teacherStateOrProvince = StateOrProvince;
            this.teacherCountry = Country;
            this.teacherZipOrPostal = ZipOrPostal;
        }

        public string teacherFirstName;
        public string teacherSecondName;
        public string teacherAddressLine1;
        public string teacherAddressLine2;
        public string teacherCity;
        public string teacherStateOrProvince;
        public string teacherCountry;
        public int teacherZipOrPostal;
    }
    public struct UProgram
    {
        public UProgram (string ProgramName, string DepartmentHead, Degree Degrees)
        {
            this.UProgramName = ProgramName;
            this.UDepartmentHead = DepartmentHead;
            this.UDegrees = Degrees;
        }

        public string UProgramName;
        public string UDepartmentHead;
        public Degree UDegrees;
    }
    public struct Course
    {
        public Course (string Name, string Credits, int DurationInWeeks, Teacher Teacher)
        {
            this.CourseName = Name;
            this.CourseCredits = Credits;
            this.CourseDurationInWeeks = DurationInWeeks;
            this.CourseTeacher = Teacher;
        }

        public string CourseName;
        public string CourseCredits;
        public int CourseDurationInWeeks;
        public Teacher CourseTeacher;
    }
    public struct Degree
    {
        Degree (string Name, string CreditsRequired)
        {
            this.DegreeName = Name;
            this.DegreeCreditsRequired = CreditsRequired;
        }

        public string DegreeName;
        public string DegreeCreditsRequired;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentsBook = new Student[5];
            Teacher[] teachersBook = new Teacher[5];
            Degree[] degrees = new Degree[5];
            UProgram[] programs = new UProgram[5];
            Course[] courses = new Course[5];

            Random rnd = new Random();

            #region Student array initialization
            for (int i = 0; i < studentsBook.Length; i++)
            {
                studentsBook[i].studentFirstName = String.Format("%Student_{0}_first_name%", i + 1);
                studentsBook[i].studentSecondName = String.Format("%Student_{0}_second_name%", i + 1);
                studentsBook[i].studentAddressLine1 = String.Format("%Student_{0}_address_line_1%", i + 1);
                studentsBook[i].studentAddressLine2 = String.Format("%Student_{0}_address_line_2%", i + 1);
                studentsBook[i].studentCity = String.Format("%Student_{0}_city%", i + 1);
                studentsBook[i].studentStateOrProvince = String.Format("%Student_{0}_state_or_province%", i + 1);
                studentsBook[i].studentCountry = String.Format("%Student_{0}_country%", i + 1);
                studentsBook[i].studentZipOrPostal = rnd.Next(111111, 999999);
            }
            #endregion
            #region Student array print
            for (int i = 0; i < studentsBook.Length; i++)
            {
                if (i == 0)
                    Console.Clear();

                Console.WriteLine("Student #{0}", i + 1);
                Console.WriteLine("First name: {0}", studentsBook[i].studentFirstName);
                Console.WriteLine("Second name: {0}", studentsBook[i].studentSecondName);
                Console.WriteLine("Address line 1: {0}", studentsBook[i].studentAddressLine1);
                Console.WriteLine("Address line 2: {0}", studentsBook[i].studentAddressLine2);
                Console.WriteLine("City: {0}", studentsBook[i].studentCity);
                Console.WriteLine("State or province: {0}", studentsBook[i].studentStateOrProvince);
                Console.WriteLine("Country: {0}", studentsBook[i].studentCountry);
                Console.WriteLine("Zip or postal: {0}", studentsBook[i].studentZipOrPostal);
                Console.WriteLine();
            }
            #endregion

            WaitForInput();

            #region Teacher array initialization
            for (int i = 0; i < teachersBook.Length; i++)
            {
                teachersBook[i].teacherFirstName = String.Format("%Teacher_{0}_first_name%", i + 1);
                teachersBook[i].teacherSecondName = String.Format("%Teacher_{0}_second_name%", i + 1);
                teachersBook[i].teacherAddressLine1 = String.Format("%Teacher_{0}_address_line_1%", i + 1);
                teachersBook[i].teacherAddressLine2 = String.Format("%Teacher_{0}_address_line_2%", i + 1);
                teachersBook[i].teacherCity = String.Format("%Teacher_{0}_city%", i + 1);
                teachersBook[i].teacherStateOrProvince = String.Format("%Teacher_{0}_state_or_province%", i + 1);
                teachersBook[i].teacherCountry = String.Format("%Teacher_{0}_country%", i + 1);
                teachersBook[i].teacherZipOrPostal = rnd.Next(111111, 999999);
            }
            #endregion
            #region Teacher array print
            for (int i = 0; i < teachersBook.Length; i++)
            {
                if (i == 0)
                    Console.Clear();

                Console.WriteLine("Teacher #{0}", i + 1);
                Console.WriteLine("First name: {0}", teachersBook[i].teacherFirstName);
                Console.WriteLine("Second name: {0}", teachersBook[i].teacherSecondName);
                Console.WriteLine("Address line 1: {0}", teachersBook[i].teacherAddressLine1);
                Console.WriteLine("Address line 2: {0}", teachersBook[i].teacherAddressLine2);
                Console.WriteLine("City: {0}", teachersBook[i].teacherCity);
                Console.WriteLine("State or province: {0}", teachersBook[i].teacherStateOrProvince);
                Console.WriteLine("Country: {0}", teachersBook[i].teacherCountry);
                Console.WriteLine("Zip or postal: {0}", teachersBook[i].teacherZipOrPostal);
                Console.WriteLine();
            }
            #endregion

            WaitForInput();

            #region Degree array initialization
            for (int i = 0; i < degrees.Length; i++)
            {
                degrees[i].DegreeName = String.Format("%Degree_{0}_name%", i + 1);
                degrees[i].DegreeCreditsRequired = String.Format("%Credits_required_{0}%", i + 1);
            }
            #endregion
            #region Degree array print
            for (int i = 0; i < degrees.Length; i++)
            {
                if (i == 0)
                    Console.Clear();

                Console.WriteLine("Degree #{0}", i + 1);
                Console.WriteLine("Degree name: {0}", degrees[i].DegreeName);
                Console.WriteLine("Degree credits required: {0}", degrees[i].DegreeCreditsRequired);
                Console.WriteLine();
            }
            #endregion

            WaitForInput();

            #region UProgram array initialization
            for (int i = 0; i < programs.Length; i++)
            {
                programs[i].UProgramName = String.Format("%Program_{0}_name%", i + 1);
                programs[i].UDepartmentHead = String.Format("%Program_{0}_department_head%", i + 1);
                programs[i].UDegrees = degrees[i];
            }
            #endregion
            #region Uprogram array print
            for (int i = 0; i < programs.Length; i++)
            {
                if (i == 0)
                    Console.Clear();

                Console.WriteLine("Program #{0}", i + 1);
                Console.WriteLine("Program name: {0}", programs[i].UProgramName);
                Console.WriteLine("Department head: {0}", programs[i].UDepartmentHead);
                Console.WriteLine("Degrees: {0};\n\t {1};", programs[i].UDegrees.DegreeName,
                                                         programs[i].UDegrees.DegreeCreditsRequired);
                Console.WriteLine();
            }
            #endregion

            WaitForInput();

            #region Course array initialization
            for (int i = 0; i < courses.Length; i++)
            {
                courses[i].CourseName = String.Format("%Course_{0}_name%", i + 1);
                courses[i].CourseCredits = String.Format("%Credits_{0}%", i + 1);
                courses[i].CourseDurationInWeeks = rnd.Next(1, 20);
                courses[i].CourseTeacher = teachersBook[i];
            }
            #endregion
            #region Course array print
            for (int i = 0; i < courses.Length; i++)
            {
                if (i == 0)
                    Console.Clear();

                Console.WriteLine("Course #{0}", i + 1);
                Console.WriteLine("Course name: {0}", courses[i].CourseName);
                Console.WriteLine("Credits: {0}", courses[i].CourseCredits);
                Console.WriteLine("Duration in weeks: {0}", courses[i].CourseDurationInWeeks);
                Console.WriteLine("Teacher: {0};\n\t {1};\n\t {2};\n\t {3};\n\t {4};\n\t {5};\n\t {6};\n\t {7};", 
                        /*0*/     courses[i].CourseTeacher.teacherFirstName,
                        /*1*/     courses[i].CourseTeacher.teacherSecondName,
                        /*2*/     courses[i].CourseTeacher.teacherAddressLine1,
                        /*3*/     courses[i].CourseTeacher.teacherAddressLine2,
                        /*4*/     courses[i].CourseTeacher.teacherCity,
                        /*5*/     courses[i].CourseTeacher.teacherStateOrProvince,
                        /*6*/     courses[i].CourseTeacher.teacherCountry,
                        /*7*/     courses[i].CourseTeacher.teacherZipOrPostal);

                Console.WriteLine();
            }
            #endregion
        }

        static void WaitForInput()
        {
            Console.Write("Press any button...");
            Console.ReadKey();
        }
    }
}
