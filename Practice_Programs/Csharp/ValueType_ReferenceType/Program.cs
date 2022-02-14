using System;

namespace ValueType_ReferenceType
{
    class Program
    {
        struct Employee
        {
            public int Salary;
            public int Age;
        }

        class Employee1
        {
            public int Salary;
            public int Age;
        }
        static void Main(string[] args)
        {
            //struct .... class

            //struct....value type......save in 'stack'memory

            //class.....Reference Type......'Heap'

            /*
             *   struct Employee
             *   { 
             *    public int salary; ........save in 'stack' less space
             *    public int age;
             *    }
             *    
             *    Main Program:
             *    
             *  Employee e=new Employee();
             *  e.salary=5000;
             *  e.Age=23;
             *  
             *  Employee e1=e;
             *  Employee e2=e;
             */

            Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;
            Console.WriteLine(e.Age);
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
            Console.WriteLine("***************************************");
            // Reference Type 
            //object Heap memeory
            //reference Stack memory

            Employee1 emp = new Employee1();
            emp.Salary = 4500;
            emp.Age = 23;
            Employee1 emp1 = emp;
            Employee1 emp2 = emp;
            emp.Age = 27;
            Console.WriteLine(emp1.Age);
            Console.WriteLine(emp2.Age);

            /* Value Type: data store in same memory(stack)
             * 
             * bool
             * byte
             * char
             * decimal
             * double
             * enum
             * float
             * int
             * long
             * sbyte
             * short
             * struct
             * uint
             * ulong
             * ushort
             */

            /*
             * Reference Type:It store the Addres  
             *                object in Heap memeory.
             * 
             * string
             * all array
             * class
             * object
             * delegates
             * interface
             */

            Console.ReadLine();


        }
    }
}
