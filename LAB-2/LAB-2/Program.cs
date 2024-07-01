using LAB_2;
using System;


//2.1

//try
//{
//    Console.Write("Enter Number to divide 100: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    int ans = 100 / n;
//    Console.WriteLine($"Answer = {ans}");
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}

//2.2

//try
//{
//    int[] a = new int[5];
//    Console.WriteLine("Enter 5 Array Elements : ");
//    for (int i = 0; i < 10; i++)
//    {
//        a[i] = Convert.ToInt32(Console.ReadLine());
//    }

//    Console.WriteLine("Array elements :: ");
//    foreach (int item in a)
//    {
//        Console.WriteLine(item);
//    }
//}
//catch (IndexOutOfRangeException e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine("Can't Access Index Grater then Array Size");
//}

//2.3
//Calculate calc = new Calculate();
//calc.SumOfTwo(10, 2);
//calc.SumOfThree(2, 5, 3);

//2.4
//Result res = new Result();
//res.Addition(10,5);
//res.Subtraction(10,5);

//2.5
//string name = "Darshan";
//string name1 = "University";

//int len = name.Length;

//string joinedString = string.Concat(name, name1);

//joinedString = string.Concat(joinedString, "Rajkot");
//Boolean res = name.Equals(name1);

//string str = "This is the \"String\" class";

//Console.WriteLine(len);
//Console.WriteLine(joinedString);
//Console.WriteLine(res);
//Console.WriteLine(str);

//Console.WriteLine("To Lower :" + name.ToLower());
//Console.WriteLine("To Upper :" + name.ToUpper());
//bool check = name.Contains("shan");
////Console.WriteLine(check);
//Console.WriteLine("Contains : " + name.Contains("shan"));

//string result = name1.Substring(2);
//string result1 = name1.Substring(0, 9);//name1.Substring(0, 9)(start,charcter) need to return
//Console.WriteLine(result);
//Console.WriteLine(result1);

//int compare = String.Compare(name, name1);
//Console.WriteLine(compare);

//Console.WriteLine("StartsWith : " + name1.StartsWith("Uni"));

//Console.WriteLine(name1.Insert(10, "Rajkot"));

//Console.WriteLine(name1.LastIndexOf("i"));

//Console.WriteLine(name1.Remove(5));

//Console.WriteLine(name1.Replace("e", "i"));

//Console.WriteLine(name.CompareTo(name1));

//Console.WriteLine(name.Clone());

//Console.WriteLine(name1.Contains("sity"));

//Console.WriteLine(name.EndsWith("an"));
//string name2 = "  Darshan     ";
//Console.WriteLine(name.Equals(name2));

//Console.WriteLine(name1.IndexOf("e"));

//Console.WriteLine(name2.Trim());

//Console.WriteLine(name2.TrimEnd());
//Console.WriteLine(name2.TrimStart());


//2.6

//Console.Write("Enter String : ");
//string str = Console.ReadLine();
//string str2 = "";
//for (int i = 0; i < str.Length; i++)
//{
//    if (!char.IsUpper(Convert.ToChar(str[i])))
//    {
//        str2 += Convert.ToString(str[i]).ToUpper();
//    }
//    else
//    {
//        str2 += Convert.ToString(str[i]).ToLower();
//    }
//}
//Console.WriteLine($"Output = {str2}");


//2.7

//Area ar = new Area();
//ar.Circle(10);
//ar.Square(10);
//ar.Triangle(5, 2);


//2.8
//Console.Write("Enter Number : ");
//int num = Convert.ToInt32(Console.ReadLine());
//try
//{
//    if (num % 2 != 0)
//    {
//        throw new Exception("Number is not even");
//    }
//    else
//    {
//        Console.WriteLine("{0} is even number", num);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//2.9
//Console.Write("Enter Senetence :");
//string s = Console.ReadLine();
//string large = "";
//foreach (string item in s.Split(" "))
//{
//    if (large.Length < s.Length)
//    {
//        large = item;
//    }
//}
//Console.WriteLine(large);

LongestWord lw = new LongestWord();
Console.Write("Enter sentence : ");
string str = Console.ReadLine();
Console.WriteLine("Longest word from \"{0}\" is {1}", str, lw.FindLongestWord(str));


//2.10
ChangeCase ch = new ChangeCase();
ch.methodChangeCase('b');

