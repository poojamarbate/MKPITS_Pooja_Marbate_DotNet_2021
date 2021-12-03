using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alphabet = "A-Z";
            Console.WriteLine("Alphabets : "+Alphabet);
            string L = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Length of Alphabets : "+L.Length);
            string Capital = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            Console.WriteLine("Capital Letters : "+Capital.ToUpper());
            Console.WriteLine("Small letters : "+Capital.ToLower());

            // String concatenation:
            string Name = "Bill";
            string Lastname = "Gates";
            //string Fullname = Name + Lastname;
            string Fullname = string.Concat(Name, Lastname);
            Console.WriteLine(Fullname);

            //Another opertion to concate string is string interpolation
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            //access string
            string mystring = "Hello World";
            Console.WriteLine("Indexing of String : "+mystring[0]);
            Console.WriteLine("Index Of : "+mystring.IndexOf("e"));

            // Full name
            string fname = "John Doe";

            // Location of the letter D
            int user = name.IndexOf("D");

            // Get last name
            string lname = name.Substring(user);

            // Print the result
            Console.WriteLine(lname);



        }
    }
}
