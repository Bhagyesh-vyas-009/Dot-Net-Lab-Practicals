using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

////Write a program to create a class Staff having data members as Name,
////Department, Designation, Experience & Salary. Accept this data for 5
////different staffs and display only names & salary of those staff who are
////HOD.

namespace LAB_1
{
    internal class Staff
    {
        public string Name, Department, Designation;
        public double Salary, Experience;

        public void getStaffData()
        {
            Console.WriteLine("Enter Staff Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter  Staff Department : ");
            Department = Console.ReadLine();
            Console.WriteLine("Enter  Staff Designation : ");
            Designation = Console.ReadLine();
            Console.WriteLine("Enter  Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter  Expeience : ");
            Experience = Convert.ToDouble(Console.ReadLine());
        }

        public String getDesignation()
        {
            return Designation;
        }

        public void displayStaffData()
        {
            Console.WriteLine("Name : {0} \nDepartment : {1} \nDesignation : {2} \nSalary : {3} \nExperience : {4}", Name, Department, Designation, Salary, Experience);
        }
    }
}
