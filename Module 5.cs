using System;
using System.Collections.Generic;

namespace Module_5
{
    public class Student
    {

        public Student()
        {
            studentsCounter++;
        }
        public Student(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
                      string City, string StateOrProvince, string Country, int ZipOrPostal)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.City = City;
            this.StateOrProvince = StateOrProvince;
            this.Country = Country;
            this.ZipOrPostal = ZipOrPostal;
            studentsCounter++;
        }

        private string studentFirstName;
        private string studentSecondName;
        private string studentAddressLine1;
        private string studentAddressLine2;
        private string studentCity;
        private string studentStateOrProvince;
        private string studentCountry;
        private int studentZipOrPostal;

        public static int studentsCounter = 0;

        public string FirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }
        public string SecondName
        {
            get { return studentSecondName; }
            set { studentSecondName = value; }
        }
        public string AddressLine1
        {
            get { return studentAddressLine1; }
            set { studentAddressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return studentAddressLine2; }
            set { studentAddressLine2 = value; }
        }
        public string City
        {
            get { return studentCity; }
            set { studentCity = value; }
        }
        public string StateOrProvince
        {
            get { return studentStateOrProvince; }
            set { studentStateOrProvince = value; }
        }
        public string Country
        {
            get { return studentCountry; }
            set { studentCountry = value; }
        }
        public int ZipOrPostal
        {
            get { return studentZipOrPostal; }
            set { studentZipOrPostal = value; }
        }
    }
    public class Teacher
    {
        public Teacher(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
                       string City, string StateOrProvince, string Country, int ZipOrPostal)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.City = City;
            this.StateOrProvince = StateOrProvince;
            this.Country = Country;
            this.ZipOrPostal = ZipOrPostal;
        }

        private string teacherFirstName;
        private string teacherSecondName;
        private string teacherAddressLine1;
        private string teacherAddressLine2;
        private string teacherCity;
        private string teacherStateOrProvince;
        private string teacherCountry;
        private int teacherZipOrPostal;

        public string FirstName
        {
            get { return teacherFirstName; }
            set { teacherFirstName = value; }
        }
        public string SecondName
        {
            get { return teacherSecondName; }
            set { teacherSecondName = value; }
        }
        public string AddressLine1
        {
            get { return teacherAddressLine1; }
            set { teacherAddressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return teacherAddressLine2; }
            set { teacherAddressLine2 = value; }
        }
        public string City
        {
            get { return teacherCity; }
            set { teacherCity = value; }
        }
        public string StateOrProvince
        {
            get { return teacherStateOrProvince; }
            set { teacherStateOrProvince = value; }
        }
        public string Country
        {
            get { return teacherCountry; }
            set { teacherCountry = value; }
        }
        public int ZipOrPostal
        {
            get { return teacherZipOrPostal; }
            set { teacherZipOrPostal = value; }
        }
    }
    public class Course
    {
        public Course(){ }

        public Course(string Name, string Credits, int DurationInWeeks,
                      List<Student> Students, List<Teacher> Teacher)
        {
            this.Name = Name;
            this.Credits = Credits;
            this.DurationInWeeks = DurationInWeeks;
            this.Students = Students;
            this.Teachers = Teachers;
        }

        private string courseName;
        private string courseCredits;
        private int courseDurationInWeeks;
        private List<Student> courseStudents = new List<Student>();
        private List<Teacher> courseTeachers = new List<Teacher>();

        public string Name
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string Credits
        {
            get { return courseCredits; }
            set { courseCredits = value; }
        }
        public int DurationInWeeks
        {
            get { return courseDurationInWeeks; }
            set { courseDurationInWeeks = value; }
        }
        public List<Student> Students
        {
            get { return courseStudents; }
            set { courseStudents = value; }
        }
        public List<Teacher> Teachers
        {
            get { return courseTeachers; }
            set { courseTeachers = value; }
        }
    }
    public class Degree
    {
        public Degree()
        {

        }
        public Degree(string Name, string CreditsRequired, Course Courses)
        {
            this.Name = Name;
            this.CreditsRequired = CreditsRequired;
            this.Courses = Courses;
        }

        private string degreeName;
        private string degreeCreditsRequired;
        private Course degreeCourses;

        public string Name
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
        public string CreditsRequired
        {
            get { return degreeCreditsRequired; }
            set { degreeCreditsRequired = value; }
        }
        public Course Courses
        {
            get { return degreeCourses; }
            set { degreeCourses = value; }
        }
    }
    public class UProgram
    {
        public UProgram()
        {

        }
        public UProgram(string Name, string DepartmentHead, Degree Degrees)
        {
            this.Name = Name;
            this.DepartmentHead = DepartmentHead;
            this.Degrees = Degrees;
        }

        private string UProgramName;
        private string UDepartmentHead;
        private Degree UDegrees;

        public string Name
        {
            get { return UProgramName; }
            set { UProgramName = value; }
        }
        public string DepartmentHead
        {
            get { return UDepartmentHead; }
            set { UDepartmentHead = value; }
        }
        public Degree Degrees
        {
            get { return UDegrees; }
            set { UDegrees = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Student init
            Student StudentAlex = new Student("Alex", "Green", "st. Great 16",
                                              "st. NotYeat 88", "New York", 
                                              "State New York", "USA", 880041);
            Student StudentBob = new Student("Bob", "Ross", "St. Josh 77",
                                             "st. michat 28", "Hippostan",
                                              "HippoState", "Honduras", 626381);
            Student StudentAnna = new Student("Anna", "AndAnna", "BlaBlaStreet",
                                              "Not great st 8", "Moscow",
                                              "StateState2", "Russia", 725630);
            #endregion
            #region Teacher init
            Teacher TeacherKsavier = new Teacher("Professor", "Ksaviet", "Michigan 15",
                                                 "Kellenoya 23", "Washington DC", "Wash",
                                                 "AMERICA", 866623);
            #endregion
            #region Course init
            Course ProgrammingInCSharp = new Course();
            ProgrammingInCSharp.Name = "Programming in C#";
            ProgrammingInCSharp.Credits = "No credits";
            ProgrammingInCSharp.DurationInWeeks = 20;
            ProgrammingInCSharp.Students.Add(StudentAlex);
            ProgrammingInCSharp.Students.Add(StudentBob);
            ProgrammingInCSharp.Students.Add(StudentAnna);
            ProgrammingInCSharp.Teachers.Add(TeacherKsavier);
            #endregion
            #region Degree init
            Degree Bachelor = new Degree();
            Bachelor.Name = "Bachelor degree";
            Bachelor.CreditsRequired = "No credits required";
            Bachelor.Courses = ProgrammingInCSharp;
            #endregion
            #region Program init
            UProgram InformationTechnology = new UProgram();
            InformationTechnology.Name = "Information Technology";
            InformationTechnology.DepartmentHead = "Alan Turing";
            InformationTechnology.Degrees = Bachelor;
            #endregion
            #region Info print
            Console.WriteLine(InformationTechnology.Name + " program contains " +
                              InformationTechnology.Degrees.Name);
            Console.WriteLine();
            Console.WriteLine(InformationTechnology.Degrees.Name + " contains " +
                              InformationTechnology.Degrees.Courses.Name);
            Console.WriteLine();
            Console.WriteLine(InformationTechnology.Degrees.Courses.Name + " contains " +
                              Student.studentsCounter + " student(s)");
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}