using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec4_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 230.30m;
            int[] marks = { 34, 45, 54, 35 };
            //non generic collection class
            ArrayList myarraylist = new ArrayList();
            //boxing : converting value type to reference type (object) is called boxing
            myarraylist.Add(12);
            myarraylist.Add(DateTime.Now);
            myarraylist.Add("Pooja");
            myarraylist.Add('p');
            myarraylist.Add(Math.PI);
            myarraylist.Add(price);
            myarraylist.Add(new Student() { rollnumber=1, Name = "Pooja" });
            myarraylist.AddRange(marks);
            foreach(object o in myarraylist)
                Console.WriteLine(o); //unboxing : converting object into its original value type

            //generic class List
            Console.WriteLine("\n");
            Console.WriteLine("Generic Class List\n");
            List<Student> students = new List<Student>()
            {
                new Student{rollnumber=2,Name="Simmi"},
                new Student{rollnumber=3,Name="Sujal"},
                new Student{rollnumber=4,Name="ishant"},
                new Student{rollnumber=5,Name="Jay"},
                new Student{rollnumber=6,Name="Krishna"},
            };                  
            foreach(Student s in students)
            {
                Console.WriteLine(s); 
            }
            Console.WriteLine("\nCount of students is : " + students.Count);
            //nongeneric class HashTable
            Hashtable mytable = new Hashtable();
            mytable.Add(2, "Soap");
            mytable.Add(3, "Facewash");
            mytable.Add(4,DateTime.Now.ToLongTimeString());
            mytable.Add(7, 67.78m);
            mytable.Add(5, marks);
            mytable.Add(11, null);
            foreach(DictionaryEntry m in mytable)
                Console.WriteLine("Key: {0} ,Value: {1}",m.Key,m.Value);

            //generic class Hashtable
            //Dictionary<Student> mydictionary = new Dictionary<Student>();

            //non generic Stack
            Stack mystack = new Stack();
            mystack.Push(78); //add push()
            mystack.Push("Mohit");
            mystack.Push(78.98m);
            mystack.Push(7000.67m);
            mystack.Push("12/12/21");
            //last in First out
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Peek());//to see only and not remove the top items
            Console.WriteLine(mystack.Pop());// to remove item from top pop()
            Console.WriteLine(mystack.Pop());




            Console.ReadKey();
        }
    }
}
