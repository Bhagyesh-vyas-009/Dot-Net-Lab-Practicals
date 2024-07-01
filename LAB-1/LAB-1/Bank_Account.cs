using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Write a pogram to Create a class Bank_Account with Account_No, Email,
//User_Name, Account_Type and Account_Balance as data members. Also
//create a Member function GetAccountDetails() & DisplayAccountDetails().

namespace LAB_1
{
    internal class Bank_Account
    {
        int Account_No;
        string Email,User_Name,Account_Type;
        double Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter User Name : ");
            User_Name = Console.ReadLine();
            Console.WriteLine("Enter  Account No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Email : ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter  Account Type : ");
            Account_Type = Console.ReadLine();
            Console.WriteLine("Enter  Account Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("User Name : {0} \nAccount No : {1} \nEmail : {2} \nAccount Type : {3} \nAccount Balance : {4}", User_Name,Account_No,Email,Account_Type,Account_Balance);
        }
    }
}
