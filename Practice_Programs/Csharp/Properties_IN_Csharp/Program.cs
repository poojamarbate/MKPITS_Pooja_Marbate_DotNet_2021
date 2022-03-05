using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_IN_Csharp
{
    class Student
    {
        //autoimplimenetation property
        public string fnname { get;private set; }
        public string lname { get; private set; }

        public Student(string n1,string n2)
        {
            fnname = n1;
            lname = n2;
        }
        //    private int _stdId;
        //    private string _Name;
        //    private string _Fname;
        //    private int _SubjectTotalMarks=100;//Read only Property


        //public int TotalMarks
        //{
        //    get
        //    {
        //        return this._SubjectTotalMarks;
        //    }
        //}

        //public int StudentID //write only
        //{
        //    set
        //    {
        //        this._stdId = value;
        //    }
        //}










        //public int StdId
        //{
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            Console.WriteLine("id cannot be zero or negetive");
        //        }
        //        else
        //        {
        //            this._stdId = value;
        //        }
                
        //    }
        //    get
        //    {
        //        return this._stdId;
        //    }

        //}

        //public string Name
        //{
        //    set
        //    {
        //       if(string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("please enter your name");
        //        }
        //        else
        //        {
        //            this._Name = value;
        //        }
              
        //    }
        //    get
        //    {
        //        return this._Name;
        //    }
        //}


        //public string Fname
        //{
        //    set
        //    {
        //        if(string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("enter your father name");
        //        }
        //        else
        //        {
        //            this._Fname = value;
        //        }
                
        //    }
        //    get
        //    {
        //        return this._Fname;
        //    }
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Pooja","Marbate");
            Console.WriteLine(s.fnname+" "+s.lname);



            //s.StudentID = 12;
            //Console.WriteLine(s.TotalMarks);
            //s.fnname = "Pooja";
            //s.lname = "Marbate";
           // Console.WriteLine(s.fnname+" "+s.lname);
            
            
            
            //s.StdId = 3;
            //Console.WriteLine(s.StdId);

            //s.Name = "Suraj";
            //Console.WriteLine(s.Name);
            Console.ReadLine();

        }
    }
}
