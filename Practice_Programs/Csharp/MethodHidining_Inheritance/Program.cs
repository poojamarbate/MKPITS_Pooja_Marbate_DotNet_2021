using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidining_Inheritance
{
    class Parent
    {
     public void Show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    class Child:Parent
    {
        public new void Show() //NEW KEYWORD::parent class k method ko hide kiya h
        {
            //   Console.WriteLine("Child class method");

            //CALL PARENT CLASS
            base.Show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Child c = new Child();//runs child class method parent class method hide.
            
            //((Parent)c).Show(); //TYPE Casting




            Parent p = new Child();
            p.Show(); //parent class method
            Console.ReadLine();
        }
    }
}
/*
 * Different Ways To calls a hidden base class member from derived class:
    
   1. use base keyword
   2.CAST CHILD TYPE TO PARENT TYPE AND INVOKE THE HIDDEN MEMBER
   3.parent class pc= new childclass();........pc.hiddenMethod();




=>parent class can have the reference of its child class.
=>when we create the object of child ,parent class 
  object is also created.

 */