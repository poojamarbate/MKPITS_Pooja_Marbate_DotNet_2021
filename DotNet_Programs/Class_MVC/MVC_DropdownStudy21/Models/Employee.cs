using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DropdownStudy21.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int Salary { get; set; }
        public Nullable<int> Department_Id { get; set; }
        public string gender { get; set; }

        public virtual Department Department { get; set; }
    }
}