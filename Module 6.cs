using System;
using System.Collections.Generic;

namespace Module_6
{
    public class Person
    {
        public Person() { }
        public Person(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
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

        private string firstName;
        private string secondName;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string stateOrProvince;
        private string country;
        private int zipOrPostal;
     
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string StateOrProvince
        {
            get { return stateOrProvince; }
            set { stateOrProvince = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int ZipOrPostal
        {
            get { return zipOrPostal; }
            set { zipOrPostal = value; }
        }
    }
    public class Student : Person
    {
        public Student() : base() { }
        public Student(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
                      string City, string StateOrProvince, string Country, int ZipOrPostal) 
        : base (FirstName, SecondName, AddressLine1, AddressLine2, City, StateOrProvince, Country, ZipOrPostal)
        { studentsCounter++; }

        public static int studentsCounter = 0;

        public void MissClasses()
        {
            Console.WriteLine("Classes are successfully skipped!");
        }
    }
    public class Teacher : Person
    {
        public Teacher() : base() { }
        public Teacher(string FirstName, string SecondName, string AddressLine1, string AddressLine2,
                      string City, string StateOrProvince, string Country, int ZipOrPostal)
        : base(FirstName, SecondName, AddressLine1, AddressLine2, City, StateOrProvince, Country, ZipOrPostal){ }

        public void ToBeAnAngry ()
        {
            Console.WriteLine("You are now angry.");
        }
    }
    public class Course
    {
        public Course() { }

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