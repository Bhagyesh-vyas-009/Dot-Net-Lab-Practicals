using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Write a program to Define a class Salary which will contain member
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee.
namespace LAB_1
{
    internal class Salary
    {
        double Basic, TA, DA, HRA, total_salary;
        public Salary(double Basic, double TA, double DA = 0.1, double HRA = 0.05)
        {
            this.Basic = Basic;
            this.TA = TA;
            this.DA = (DA / 100) * Basic;
            this.HRA = (HRA / 100) * Basic;
        }
        public void CalculateTotalSalary()
        {
            this.total_salary = this.Basic + this.TA + this.DA + this.HRA;
            DisplayTotalSalary();
        }
        public void DisplayTotalSalary()
        {
            Console.WriteLine("Total salary is: " + this.total_salary);
        }

    }
}
