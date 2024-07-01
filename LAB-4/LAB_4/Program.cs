using System.Collections;
//4.1
//ArrayList StudentName = new ArrayList();

//StudentName.Add("Bhagyesh");
//StudentName.Add("Krunal");
//StudentName.Add("Harsh");
//StudentName.Add("Yagnik");

//foreach(var st in StudentName)
//{
//    Console.WriteLine(st);
//}

//StudentName.RemoveAt(1);
//Console.WriteLine("\n----After Remove---");
//foreach (var st in StudentName)
//{
//    Console.WriteLine(st);
//}

//StudentName.RemoveRange(0, 1);
//StudentName.RemoveAt(1);
//Console.WriteLine("\n----After Remove---");
//foreach (var st in StudentName)
//{
//    Console.WriteLine(st);
//}

//StudentName.Clear();
//Console.WriteLine("\n----After Clear---");
//foreach (var st in StudentName)
//{
//    Console.WriteLine(st);
//}

//4.2

List<string> StudentNameList=new List<string>();
StudentNameList.Add("Bhagyesh");
StudentNameList.Add("Krunal");
StudentNameList.Add("Harsh");
StudentNameList.Add("Yagnik");
StudentNameList.Add("Bhavin");

Console.WriteLine("---List elements ---");
foreach (string studentName in StudentNameList)
{
    Console.WriteLine(studentName);
}

StudentNameList.Remove("Krunal");
Console.WriteLine("\n---After Remove of Krunal from List");
foreach (string studentName in StudentNameList)
{
    Console.WriteLine(studentName);
}

StudentNameList.RemoveRange(0, 2);
Console.WriteLine("\n---After RemoveRange ---");
foreach (string studentName in StudentNameList)
{
    Console.WriteLine(studentName);
}

Console.WriteLine("\n---After Clear ---");
StudentNameList.Clear();
foreach (string studentName in StudentNameList)
{
    Console.WriteLine(studentName);
}

//4.3
//Stack st=new Stack();

//st.Push(1);
//st.Push(2);
//st.Push(3);
//st.Push(4);
//st.Push(5);
//st.Push(6);
//st.Push(7);
//st.Push(8);
//st.Push(9);

//Console.WriteLine("---Stack Elements---");
//foreach(var e in st)
//{
//    Console.WriteLine(e);
//}

//Console.WriteLine("---After Pop---");
//st.Pop();
//foreach (var e in st)
//{
//    Console.WriteLine(e);
//}

//Console.WriteLine("Peek : {0}",st.Peek());
//Console.Write("Enter element to check Stack contains or not : ");
//int value=Convert.ToInt32(Console.ReadLine());  

//Console.WriteLine("Stack Contains {0} ? --> {1}", value, st.Contains(value));

//Console.WriteLine("\n---After Clear---");
//st.Clear();
//foreach (var e in st)
//{
//    Console.WriteLine(e);
//}

//4.4
//Queue q=new Queue();
//Console.Write("Enter Size of Queue : ");
//int size=Convert.ToInt32(Console.ReadLine());

//for(int i=0; i<size; i++)
//{
//    Console.Write("Enter element {0}:", (i+1));
//    q.Enqueue(Console.ReadLine());
//}

//Console.WriteLine("\nQueue Count : {0}",q.Count);
//Console.WriteLine("\nQueue Elements : ");

//foreach(var qt in q)
//{
//    Console.WriteLine(qt);
//}

//Console.WriteLine("\nAfter Dequeue : ");
//q.Dequeue();
//foreach (var qt in q)
//{
//    Console.WriteLine(qt);
//}

//Console.WriteLine("Peek : {0}",q.Peek());

//Console.WriteLine("Enter Value to check Queue contains or not ? ");
//int value = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Queue Contains {0} --> {1}",value,q.Contains(value));

//Console.WriteLine("\nAfter Clear : ");
//q.Clear();
//foreach (var qt in q)
//{
//    Console.WriteLine(qt);
//}