using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_HelperMethods.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Marks { get; set; }
    }
    public enum City
    {
        Mumbai,
        Puna,
        Nagpur,
        Banglore,
        Chennai
    }
}