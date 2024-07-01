using LAB_1;

//1.1

//public class program
//{
//    public static void main()
//    {
//Candidate c1 = new Candidate();

//c1.GetCandidateDetails();
//Console.WriteLine("\n\n:::::details :::::\n\n");
//c1.DisplayCandidateDetails();
//}
//}

//1.2

//Staff[] st = new Staff[5];

//for (int i = 0; i < st.Length; i++)
//{
//    st[i] = new Staff();
//    Console.WriteLine("Enter Detail of Staff : {0}", i+1);
//    st[i].getStaffData();
//    Console.WriteLine("---------------------------------");
//}

//for (int i = 0; i < st.Length; i++)
//{
//    if (st[i].getDesignation() == "HOD")
//    {
//        Console.WriteLine("---Staff with HOD Department ---");
//        st[i].displayStaffData();
//    }
//}

//1.3

//Bank_Account acc = new Bank_Account();
//acc.GetAccountDetails();
//Console.WriteLine("\nAccount Details ");
//acc.DisplayAccountDetails(); 
//Console.ReadLine();

//1.4
//Student s1 = new Student();
//Console.WriteLine("\nStudent Details ----\n");
//s1.DisplayStudentDetails();

//1.5

//double l,w;
//Console.WriteLine("Enter Length : ");
//l=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter Width : ");
//w = Convert.ToDouble(Console.ReadLine());

//Rectangle rec = new Rectangle(l, w);

//1.6

//Interest i=new Interest();
//i.printInterest();

//1.7
//Console.Write("Enter Basic Salary : ");
//int basic=Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter TA : ");
//int ta = Convert.ToInt32(Console.ReadLine());

//Salary s = new Salary(basic, ta);
//s.CalculateTotalSalary();

//1.8

//Console.WriteLine("Enter Distance-1 : ");
//double d1=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter Distance-2 : ");
//double d2 = Convert.ToDouble(Console.ReadLine());

//Distance dist=new Distance(d1, d2);
//dist.Sum();
//dist.Display();

//1.9

//Table t = new Table();
//t.GetData();
//Console.WriteLine("\nTable Details ");
//t.printTableData();

//1.10

Prog_10 p10 = new Prog_10();
Employee e1 = new Employee(100000, 0.1, 10000, 0.05);
p10.run(e1);



