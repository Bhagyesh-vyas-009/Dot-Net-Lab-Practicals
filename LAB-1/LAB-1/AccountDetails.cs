using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
//Write a program for implementing single inheritance which creates one
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted from account details
namespace LAB_1
{
    public class AccountDetails
    {
        public double p, r, n;
        public AccountDetails()
        {
            Console.WriteLine("Enter Balance : ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest : ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time Duration : ");
            n = Convert.ToDouble(Console.ReadLine());
        }

    }

    public class Interest : AccountDetails
    {
        public void printInterest()
        {
            Console.WriteLine($"Balance = {p}");
            Console.WriteLine("Interest : {0}",((p*r*n)/100));
        }
    }
}
