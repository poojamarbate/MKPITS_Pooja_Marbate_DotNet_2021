using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DropdownStudy21.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}