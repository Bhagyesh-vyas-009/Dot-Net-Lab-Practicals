using LAB_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Write a program with following specifications:
//Class Name: Student
//Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
//Get Students Details using constructor and DisplayStudentDetails() using
//member function.
namespace LAB_1
{
    internal class Student
    {
        public long Enrollment_No, Semester;
        public string Student_Name;
        public double CPI, SPI;

        public Student()
        {
            Console.WriteLine("Enter  Enrollment No : ");
            Enrollment_No = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Student Name : ");
            Student_Name = Console.ReadLine();
            Console.WriteLine("Enter  Semester: ");
            Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  SPI : ");
            SPI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter  CPI : ");
            CPI = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment No : {0} \nStudent Name : {1} \nSemester : {2} \nSPI : {3} \nCPI : {4}", Enrollment_No, Student_Name, Semester, SPI, CPI);
        }
    }
}
