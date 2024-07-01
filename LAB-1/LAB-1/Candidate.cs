using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class Candidate
    {
        int ID, Age;
        string Name;
        double Weight, Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Candidate ID : ");
            ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter  Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Weight : ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter  Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID : {0} \nName : {1} \n Age : {2} \nWeight : {3} \nHeight : {4}",ID,Name,Age,Weight,Height);
        }
    }
}
