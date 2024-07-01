using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Furniture with material, price as data members. Create
//another class Table with Height, surface_area as data members. Write a
//program to implement single inheritance.

namespace LAB_1
{
    public class Furniture
    {
        public string material;
        public double price;
        public Furniture()
        {
            Console.Write("Enter Material : ");
            material = Console.ReadLine();
            Console.Write("Enter Price : ");
            price = Convert.ToDouble(Console.ReadLine());
        }
    }
    public class Table : Furniture
    {
        public double height, surface_area;
      
        public void GetData()
        {
            
            Console.Write("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter surface area: ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }
            public void printTableData()
        {
            Console.WriteLine("Material  : {0} \nPrice : {1} \nHeight : {2} \nSurface Area : {3}",material,price,height,surface_area);
        }
    }

}
