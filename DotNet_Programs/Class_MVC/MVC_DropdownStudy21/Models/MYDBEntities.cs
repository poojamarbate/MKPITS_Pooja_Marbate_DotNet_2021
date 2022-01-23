using System;
using System.Data.Entity;
using System.Linq;

namespace MVC_DropdownStudy21.Models
{
    public class MYDBEntities : DbContext
    {
        // Your context has been configured to use a 'MYDBEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVC_DropdownStudy21.Models.MYDBEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MYDBEntities' 
        // connection string in the application configuration file.
        public MYDBEntities()
            : base("name=MYDBEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}